using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystem
{
    public partial class StudEnrollmentForm : Form
    {
        public StudEnrollmentForm()
        {
            InitializeComponent();
        }

        private void ModeButton_Click(object sender, EventArgs e)
        {

            if (StudEnrollmentForm.ActiveForm.BackColor == Color.White)
            {
                StudEnrollmentForm.ActiveForm.BackColor = Color.DarkCyan;
                ModeButton.BackColor = Color.White;
                ModeButton.Text = "Light Mode";
            }
            else {
                StudEnrollmentForm.ActiveForm.BackColor = Color.White;
                ModeButton.BackColor = Color.DarkCyan;
                ModeButton.Text = "Dark Mode";

            }
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            SubjSchedEntry SSE = new SubjSchedEntry();
            Hide();
            SSE.ShowDialog();
            Close();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StudEnrollmentForm_Load(object sender, EventArgs e)
        {

        }

        //string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\Server2\second semester 2023-2024\LAB802\79866_CC_APPSDEV22_1200_0130_PM_TTH\79866-23237761\Desktop\FINALS\EnrollmentSystem\Alejandrino.accdb";
        string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\AppsDevFinals\EnrollmentSystem\Alejandrino.accdb";// laptop conStr
        OleDbConnection thisConnection;

        private void IdNumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                thisConnection = new OleDbConnection(connectionString);
                thisConnection.Open();
                OleDbCommand thisCommand = thisConnection.CreateCommand();

                string sql = "SELECT * FROM STUDENTFILE";
                thisCommand.CommandText = sql;

                OleDbDataReader thisDataReader = thisCommand.ExecuteReader();

                bool found = false;

                string name = "";
                string course = "";
                string yrlevel = "";

                while (thisDataReader.Read())
                {

                    if (thisDataReader["STFSTUDID"].ToString().Trim().ToUpper() == IdNumTextBox.Text.Trim().ToUpper())
                    {
                        found = true;

                        name = thisDataReader["STFSTUDLNAME"].ToString() + " " +
                               thisDataReader["STFSTUDFNAME"].ToString() + " " +
                               thisDataReader["STFSTUDMNAME"].ToString().Substring(0, 1);
                        course = thisDataReader["STFSTUDCOURSE"].ToString();
                        yrlevel = thisDataReader["STFSTUDYEAR"].ToString();
                        break;

                    }

                }


                if (found == false)
                {
                    MessageBox.Show("Subject Code Not Found");
                }
                else
                {
                    NameLabel.Text = name;
                    CourseLabel.Text = course;
                    YearLabel.Text = yrlevel;
                }
            }
        }

        int totalUnits = 0;
        int index=0;

        private void EdpCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                bool edpCheck = false;
                bool timeCheck = false;
                thisConnection = new OleDbConnection(connectionString);
                thisConnection.Open();

                OleDbCommand thisCommand = thisConnection.CreateCommand();
                string subjSchedFile = "SELECT * FROM SUBJECTSCHEDFILE";
                thisCommand.CommandText = subjSchedFile;
                OleDbDataReader thisDataReader = thisCommand.ExecuteReader();

                OleDbCommand sfCommand = thisConnection.CreateCommand();
                string subjFile = "SELECT * FROM SUBJECTFILE";
                sfCommand.CommandText = subjFile;
                OleDbDataReader sfReader = sfCommand.ExecuteReader();

                for (int size =0; size<=SubjectDataGridView.Rows.Count;size++) {
                    if (SubjectDataGridView.Rows.Count==0) {
                        while (thisDataReader.Read())
                        {
                            if (EdpCodeTextBox.Text != thisDataReader["SSFEDPCODE"].ToString().Trim().ToUpper())
                            {

                                edpCheck = false;

                            }
                            else
                            {
                                edpCheck=true;
                                break;
                            }
                        }
                        timeCheck = true;
                    }
                    else
                    {
                        while (thisDataReader.Read())
                        {
                            if (EdpCodeTextBox.Text != thisDataReader["SSFEDPCODE"].ToString().Trim().ToUpper())
                            {
                                edpCheck = false;
                            }
                            else
                            {
                                edpCheck = true;
                                break;
                            }
                            
                        }
                        
                        try
                        {
                            if (EdpCodeTextBox.Text == SubjectDataGridView.Rows[size].Cells["EdpCodeColumn"].Value.ToString())
                            {
                                edpCheck = false;
                                break;
                            }
                        }
                        catch
                        {
                            break;
                        }

                        while (thisDataReader.Read())
                        {
                            if (thisDataReader["SSFSTARTTIME"].ToString().Substring(10, 4) == SubjectDataGridView.Rows[size].Cells["StartTimeColumn"].Value.ToString()
                                && thisDataReader["SSFENDTIME"].ToString().Substring(10, 4) == SubjectDataGridView.Rows[size].Cells["EndTimeColumn"].Value.ToString())
                            {
                                MessageBox.Show("Time Conflict!");
                                timeCheck = false;
                                break;
                            }
                            else
                            {
                                timeCheck = true;
                            }
                        }                        
                    }
                    if (edpCheck && timeCheck)
                    {
                        break;
                    }

                }

                if (edpCheck==false) {
                    MessageBox.Show("EDP Code conflict!");
                }

                if ((edpCheck&&timeCheck==true)) {
                    OleDbCommand ssfCmd = thisConnection.CreateCommand();
                    string ssf = "SELECT * FROM SUBJECTSCHEDFILE";
                    ssfCmd.CommandText = ssf;
                    OleDbDataReader ssfRead = ssfCmd.ExecuteReader();

                    OleDbCommand sfCmd = thisConnection.CreateCommand();
                    string sf = "SELECT * FROM SUBJECTFILE";
                    sfCmd.CommandText = sf;
                    OleDbDataReader sfRead = sfCmd.ExecuteReader();

                    ToSubjDGV(ssfRead, sfRead);
                    MessageBox.Show("Subject Added");
                    UnitsLabel.Text=totalUnits.ToString();
                }
            }
        }



        public void ToSubjDGV(OleDbDataReader thisDataReader, OleDbDataReader sfReader)
        {
            string temp="";
            while (thisDataReader.Read())
            {

                if (thisDataReader["SSFEDPCODE"].ToString() == EdpCodeTextBox.Text)

                {
                    index = SubjectDataGridView.Rows.Add();
                    SubjectDataGridView.Rows[index].Cells["EdpCodeColumn"].Value = thisDataReader["SSFEDPCODE"].ToString();
                    SubjectDataGridView.Rows[index].Cells["SubjectCodeColumn"].Value = thisDataReader["SSFSUBJCODE"].ToString();
                    SubjectDataGridView.Rows[index].Cells["StartTimeColumn"].Value = thisDataReader["SSFSTARTTIME"].ToString().Substring(10, 4);
                    SubjectDataGridView.Rows[index].Cells["EndTimeColumn"].Value = thisDataReader["SSFENDTIME"].ToString().Substring(10, 4);
                    SubjectDataGridView.Rows[index].Cells["DaysColumn"].Value = thisDataReader["SSFDAYS"].ToString();
                    SubjectDataGridView.Rows[index].Cells["RoomColumn"].Value = thisDataReader["SSFROOM"].ToString();

                    temp= thisDataReader["SSFSUBJCODE"].ToString();

                    break;
                }
            }
            while (sfReader.Read()) {
                
                if (temp == sfReader["SFSUBJCODE"].ToString()) {

                    SubjectDataGridView.Rows[index].Cells["UnitsColumn"].Value = sfReader["SFSUBJUNITS"].ToString();

                    int units = Convert.ToInt16(SubjectDataGridView.Rows[index].Cells["UnitsColumn"].Value);
                    totalUnits = totalUnits + units;

                    break;
                }
                
            }
        }
    }
}
