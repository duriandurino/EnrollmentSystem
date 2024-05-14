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

        private void SubjectEntryButton_MouseEnter(object sender, EventArgs e)
        {
            SubjectEntryButton.SetBounds(SubjectEntryButton.Location.X+20, SubjectEntryButton.Location.Y, SubjectEntryButton.Width, SubjectEntryButton.Height) ;
            SubjectEntryButton.BackColor= Color.Yellow;
        }

        private void SubjectEntryButton_Click(object sender, EventArgs e)
        {
            StudEnrollmentForm ShowSubjEntry = new StudEnrollmentForm();
            ShowSubjEntry.Show();
        }

        private void SubjectEntryButton_MouseLeave(object sender, EventArgs e)
        {
            SubjectEntryButton.SetBounds(SubjectEntryButton.Location.X - 20, SubjectEntryButton.Location.Y, SubjectEntryButton.Width, SubjectEntryButton.Height);
            SubjectEntryButton.BackColor = Color.PaleTurquoise;
        }
    }
}
