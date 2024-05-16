using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
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
    }
}
