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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void SubjectEntryButton_MouseEnter(object sender, EventArgs e)
        {
            SubjectEntryButton.SetBounds(SubjectEntryButton.Location.X+50, SubjectEntryButton.Location.Y, SubjectEntryButton.Width, SubjectEntryButton.Height) ;
        }

        private void SubjectEntryButton_Click(object sender, EventArgs e)
        {

        }

        private void SubjectEntryButton_MouseLeave(object sender, EventArgs e)
        {
            SubjectEntryButton.SetBounds(SubjectEntryButton.Location.X - 50, SubjectEntryButton.Location.Y, SubjectEntryButton.Width, SubjectEntryButton.Height);
        }
    }
}
