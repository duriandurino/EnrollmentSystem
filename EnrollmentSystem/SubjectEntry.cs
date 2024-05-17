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
    public partial class SubjectEntry : Form
    {
        public SubjectEntry()
        {
            InitializeComponent();
        }

        public void ScanSubjFile(OleDbDataReader thisDataReader)
        {

            while (thisDataReader.Read())
            {
                found = false;
                subjectCode = "";
                description = "";
                units = "";
                if (thisDataReader["SFSUBJCODE"].ToString().Trim().ToUpper() == RequisiteTextBox.Text.Trim().ToUpper())

                {
                    found = true;
                    subjectCode = thisDataReader["SFSUBJCODE"].ToString();
                    description = thisDataReader["SFSUBJDESC"].ToString();
                    units = thisDataReader["SFSUBJUNITS"].ToString();
                    found = true;
                    break;
                }
                else
                {
                    found = false;
                }
            }
        }

        public void ScanReqFile(OleDbDataReader reqDataReader)
        {
            requisite = "";
            while (reqDataReader.Read())
            {
                if ((reqDataReader["SUBJCODE"].ToString().Trim().ToUpper() == RequisiteTextBox.Text.Trim().ToUpper()))
                {
                    requisite = reqDataReader["SUBJPRECODE"].ToString();
                    break;
                }
            }
        }

        public void ToSubjFile(DataSet thisDataSet, OleDbDataAdapter thisAdapter, DataRow thisRow) {
            thisRow["SFSUBJCODE"] = SubjectCodeTextBox.Text;
            thisRow["SFSUBJDESC"] = DescriptionTextBox.Text;
            thisRow["SFSUBJUNITS"] = UnitsTextBox.Text;
            thisRow["SFSUBJREGOFRNG"] = OfferingComboBox.Text.Substring(0, 1);
            thisRow["SFSUBJCATEGORY"] = CategoryComboBox.Text;
            thisRow["SFSUBJCOURSECODE"] = CourseCodeComboBox.Text;
            thisRow["SFSUBJCURRYEAR"] = CurriculumYearTextBox.Text;

            thisDataSet.Tables["SUBJECTFILE"].Rows.Add(thisRow);
            thisAdapter.Update(thisDataSet, "SUBJECTFILE");
        }

        //string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\Server2\second semester 2023-2024\LAB802\79866_CC_APPSDEV22_1200_0130_PM_TTH\79866-23237761\Desktop\FINALS\EnrollmentSystem\Alejandrino.accdb";
        string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\AppsDevFinals\EnrollmentSystem\Alejandrino.accdb";// laptop conStr
        private void SaveButton_Click(object sender, EventArgs e)
        {
            OleDbConnection thisConnection = new OleDbConnection(connectionString);
            string Ole = "SELECT * FROM SUBJECTFILE";
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(Ole, thisConnection);
            OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            thisAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            thisAdapter.Fill(thisDataSet, "SUBJECTFILE");

            DataRow findRow = thisDataSet.Tables["SUBJECTFILE"].Rows.Find(SubjectCodeTextBox.Text);

            if (findRow == null&&SubjectCodeTextBox.Text!=string.Empty)
            {
                DataRow thisRow = thisDataSet.Tables["SUBJECTFILE"].NewRow();

                ToSubjFile(thisDataSet, thisAdapter, thisRow);

                thisConnection = new OleDbConnection(connectionString);
                Ole = "SELECT * FROM SUBJECTPREQFILE";
                thisAdapter = new OleDbDataAdapter(Ole, thisConnection);
                thisBuilder = new OleDbCommandBuilder(thisAdapter);
                thisDataSet = new DataSet();
                thisAdapter.Fill(thisDataSet, "SUBJECTPREQFILE");

                thisRow = thisDataSet.Tables["SUBJECTPREQFILE"].NewRow();

                if (RequisiteTextBox.Text != string.Empty)
                {
                    thisRow["SUBJCODE"] = SubjectCodeTextBox.Text;
                    thisRow["SUBJPRECODE"] = RequisiteTextBox.Text;
                    if (PRRadioButton.Checked == true)
                    {
                        thisRow["SUBJCATEGORY"] = "PR";
                    }

                    else if (CRRadioButton.Checked == true)
                    {
                        thisRow["SUBJCATEGORY"] = "CR";
                    }

                    thisDataSet.Tables["SUBJECTPREQFILE"].Rows.Add(thisRow);
                    thisAdapter.Update(thisDataSet, "SUBJECTPREQFILE");
                }

                MessageBox.Show("RECORDED");
            }
            else
            {
                MessageBox.Show("Duplicate/Null Entry!");
            }
        }

        bool found = false;
        string subjectCode = "";
        string description = "";
        string units = "";
        string requisite = "";

        private void RequisiteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                OleDbConnection thisConnection = new OleDbConnection(connectionString);
                thisConnection.Open();
                
                OleDbCommand thisCommand = thisConnection.CreateCommand();
                OleDbCommand thisCommandPreq = thisConnection.CreateCommand();

                string subjPreq = "SELECT * FROM SUBJECTPREQFILE";
                thisCommandPreq.CommandText = subjPreq;

                string subjFile = "SELECT * FROM SUBJECTFILE";
                thisCommand.CommandText = subjFile;

                OleDbDataReader thisDataReader = thisCommand.ExecuteReader();
                OleDbDataReader reqDataReader = thisCommandPreq.ExecuteReader();

                ScanSubjFile(thisDataReader);
                ScanReqFile(reqDataReader);

                int index;
                if (found == false)
                { MessageBox.Show("Subject Code Not Found"); }
                else
                {
                    index = SubjectDataGridView.Rows.Add();
                    SubjectDataGridView.Rows[index].Cells["SubjectCodeColumn"].Value = subjectCode;
                    SubjectDataGridView.Rows[index].Cells["DescriptionColumn"].Value = description;
                    SubjectDataGridView.Rows[index].Cells["UnitsColumn"].Value = units;
                    SubjectDataGridView.Rows[index].Cells["PreRequisiteColumn"].Value = requisite;

                }
            }
        }

        private void SubjectEntry_Load(object sender, EventArgs e)
        {
            /*SubjSchedEntry subjSchedEntry = new SubjSchedEntry();
            subjSchedEntry.Show();*/
            PRRadioButton.Checked = true;
        }

        private void ModeButton_Click(object sender, EventArgs e)
        {
            if (SubjectEntry.ActiveForm.BackColor == Color.White)
            {
                SubjectEntry.ActiveForm.BackColor = Color.DarkCyan;
                ModeButton.BackColor = Color.White;
                ModeButton.Text = "Light Mode";
            }
            else
            {
                SubjectEntry.ActiveForm.BackColor = Color.White;
                ModeButton.BackColor = Color.DarkCyan;
                ModeButton.Text = "Dark Mode";

            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            SubjSchedEntry SSE = new SubjSchedEntry();
            Hide();
            SSE.ShowDialog();
            Close();
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            Homepage HP = new Homepage();
            Hide();
            HP.ShowDialog();
            Close();
        }
    }
}
