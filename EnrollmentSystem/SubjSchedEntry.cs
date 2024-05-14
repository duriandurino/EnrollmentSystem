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
    public partial class SubjSchedEntry : Form
    {
        public SubjSchedEntry()
        {
            InitializeComponent();
        }

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
    }
}
