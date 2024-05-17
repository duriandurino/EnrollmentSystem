using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystem
{
    public partial class SubjSchedEntry : Form
    {
        public SubjSchedEntry()
        {
            InitializeComponent();
        }

        //string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\Server2\second semester 2023-2024\LAB802\79866_CC_APPSDEV22_1200_0130_PM_TTH\79866-23237761\Desktop\FINALS\EnrollmentSystem\Alejandrino.accdb";
        string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\AppsDevFinals\EnrollmentSystem\Alejandrino.accdb";// laptop conStr

        OleDbConnection thisConnection;
        OleDbDataAdapter thisAdapter;
        OleDbCommandBuilder thisBuilder;
        DataSet thisDataSet;

        private void SubjSchedEntry_Load(object sender, EventArgs e)
        {

        }

        private void ModeButton_Click(object sender, EventArgs e)
        {
            if (SubjSchedEntry.ActiveForm.BackColor == Color.White)
            {
                SubjSchedEntry.ActiveForm.BackColor = Color.DarkCyan;
                ModeButton.BackColor = Color.White;
                ModeButton.Text = "Light Mode";
            }
            else
            {
                SubjSchedEntry.ActiveForm.BackColor = Color.White;
                ModeButton.BackColor = Color.DarkCyan;
                ModeButton.Text = "Dark Mode";

            }
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            SubjectEntry SE = new SubjectEntry();
            Hide();
            SE.ShowDialog();
            Close();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            StudEnrollmentForm SEF = new StudEnrollmentForm();
            Hide();
            SEF.ShowDialog();
            Close();
        }

        public void SaveSchedEntry()
        {
            thisConnection = new OleDbConnection(connectionString);
            string Ole = "SELECT * FROM SUBJECTSCHEDFILE";
            thisAdapter = new OleDbDataAdapter(Ole, connectionString);
            thisBuilder = new OleDbCommandBuilder(thisAdapter);
            thisDataSet = new DataSet();
            thisAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            thisAdapter.Fill(thisDataSet, "SUBJECTSCHEDFILE");

            DataRow thisRow = thisDataSet.Tables["SUBJECTSCHEDFILE"].NewRow();

            thisRow["SSFEDPCODE"] = EdpTextBox.Text;
            thisRow["SSFSUBJCODE"] = SubjCodeTextBox.Text;
            thisRow["SSFSTARTTIME"] = StartTimeTextBox.Text;
            thisRow["SSFENDTIME"] = EndTimeTextBox.Text;
            thisRow["SSFDAYS"] = DaysTextBox.Text;
            thisRow["SSFROOM"] = RoomTextBox.Text;
            thisRow["SSFMAXSIZE"] = 0;
            thisRow["SSFCLASSSIZE"] = 0;
            thisRow["SSFSTATUS"] = "";
            thisRow["SSFXM"] = AmPmComboBox.Text;
            thisRow["SSFSECTION"] = SectionTextBox.Text;
            thisRow["SSFSCHOOLYEAR"] = SYTextBox.Text;


            thisDataSet.Tables["SUBJECTSCHEDFILE"].Rows.Add(thisRow);
            thisAdapter.Update(thisDataSet, "SUBJECTSCHEDFILE");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            OleDbConnection thisConnection = new OleDbConnection(connectionString);
            thisConnection.Open();
            OleDbCommand thisCommand = thisConnection.CreateCommand();
            string subjSchFile = "SELECT * FROM SUBJECTSCHEDFILE";
            thisCommand.CommandText = subjSchFile;
            OleDbDataReader thisDataReader = thisCommand.ExecuteReader();

            string edp = "";

            while (thisDataReader.Read())
            {
                if ((thisDataReader["SSFEDPCODE"].ToString().Trim().ToUpper() == EdpTextBox.Text.Trim().ToUpper()))
                {
                    edp = thisDataReader["SSFEDPCODE"].ToString();

                    break;
                }
            }
            if (EdpTextBox.Text != string.Empty)
            { 
                if (EdpTextBox.Text != edp)
                {
                    SaveSchedEntry();

                    MessageBox.Show("Saved Entry");
                }
                else
                {
                    MessageBox.Show("EDP Code already exists!");
                }
            }
            else
            {
                MessageBox.Show("Form not complete!");
            }

        }

        

        private void SubjCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                thisConnection = new OleDbConnection(connectionString);
                thisConnection.Open();
                OleDbCommand thisCommand = thisConnection.CreateCommand();
                string subjFile = "SELECT * FROM SUBJECTFILE";
                thisCommand.CommandText = subjFile;
                OleDbDataReader thisDataReader = thisCommand.ExecuteReader();

                while (thisDataReader.Read())
                {
                    if ((thisDataReader["SFSUBJCODE"].ToString().Trim().ToUpper() == SubjCodeTextBox.Text.Trim().ToUpper()))
                    {
                        DescLabel.Text = thisDataReader["SFSUBJDESC"].ToString();
                        break;
                    }
                    else
                    {
                        DescLabel.Text = "";
                    }
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            EdpTextBox.Text = string.Empty;
            SubjCodeTextBox.Text = string.Empty;
            DescLabel.Text = string.Empty;
            StartTimeTextBox.Text = string.Empty;
            EndTimeTextBox.Text = string.Empty;
            AmPmComboBox.SelectedIndex = 0;
            DaysTextBox.Text = string.Empty;
            SectionTextBox.Text = string.Empty;
            RoomTextBox.Text = string.Empty;
            SYTextBox.Text = string.Empty;
        }
    }
}
