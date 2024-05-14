using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ModeButton_Click(object sender, EventArgs e)
        {

            if (StudEnrollmentForm.ActiveForm.BackColor == Color.White)
            {
                StudEnrollmentForm.ActiveForm.BackColor = Color.DarkCyan;
                UCLogo.BackColor = Color.DarkCyan;
                ModeButton.BackColor = Color.White;
                ModeButton.Text = "Light Mode";
            }
            else {
                StudEnrollmentForm.ActiveForm.BackColor = Color.White;
                UCLogo.BackColor = Color.White;
                ModeButton.BackColor = Color.DarkCyan;
                ModeButton.Text = "Dark Mode";

            }
        }
    }
}
