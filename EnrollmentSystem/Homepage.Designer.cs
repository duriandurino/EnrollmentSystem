namespace EnrollmentSystem
{
    partial class Homepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SubjectEntryButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SubjectEntryButton
            // 
            this.SubjectEntryButton.AutoSize = true;
            this.SubjectEntryButton.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectEntryButton.Location = new System.Drawing.Point(334, 197);
            this.SubjectEntryButton.Name = "SubjectEntryButton";
            this.SubjectEntryButton.Size = new System.Drawing.Size(128, 37);
            this.SubjectEntryButton.TabIndex = 0;
            this.SubjectEntryButton.Text = "Mulihok";
            this.SubjectEntryButton.Click += new System.EventHandler(this.SubjectEntryButton_Click);
            this.SubjectEntryButton.MouseEnter += new System.EventHandler(this.SubjectEntryButton_MouseEnter);
            this.SubjectEntryButton.MouseLeave += new System.EventHandler(this.SubjectEntryButton_MouseLeave);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubjectEntryButton);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubjectEntryButton;
    }
}