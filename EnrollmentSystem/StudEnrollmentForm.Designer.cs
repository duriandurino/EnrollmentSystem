namespace EnrollmentSystem
{
    partial class StudEnrollmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudEnrollmentForm));
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IdNumTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CourseLabel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EdpCodeTextBox = new System.Windows.Forms.TextBox();
            this.EnrollmentFormTable = new System.Windows.Forms.DataGridView();
            this.EdpCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.UnitsLabel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EncodedTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UCLogo = new System.Windows.Forms.PictureBox();
            this.ModeButton = new System.Windows.Forms.Button();
            this.PrevButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EnrollmentFormTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UCLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Yellow;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(17, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(256, 27);
            this.label12.TabIndex = 6;
            this.label12.Text = "Student Enrollment Form";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID Number";
            // 
            // IdNumTextBox
            // 
            this.IdNumTextBox.Location = new System.Drawing.Point(70, 11);
            this.IdNumTextBox.Name = "IdNumTextBox";
            this.IdNumTextBox.Size = new System.Drawing.Size(144, 20);
            this.IdNumTextBox.TabIndex = 10;
            this.IdNumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdNumTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(70, 37);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.ReadOnly = true;
            this.NameLabel.Size = new System.Drawing.Size(235, 20);
            this.NameLabel.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Course";
            // 
            // CourseLabel
            // 
            this.CourseLabel.Location = new System.Drawing.Point(115, 73);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.ReadOnly = true;
            this.CourseLabel.Size = new System.Drawing.Size(60, 20);
            this.CourseLabel.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Year";
            // 
            // YearLabel
            // 
            this.YearLabel.Location = new System.Drawing.Point(220, 73);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.ReadOnly = true;
            this.YearLabel.Size = new System.Drawing.Size(66, 20);
            this.YearLabel.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "EDP Code";
            // 
            // EdpCodeTextBox
            // 
            this.EdpCodeTextBox.Location = new System.Drawing.Point(70, 133);
            this.EdpCodeTextBox.Name = "EdpCodeTextBox";
            this.EdpCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.EdpCodeTextBox.TabIndex = 10;
            // 
            // EnrollmentFormTable
            // 
            this.EnrollmentFormTable.AllowUserToAddRows = false;
            this.EnrollmentFormTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EnrollmentFormTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EdpCodeColumn,
            this.SubjectCodeColumn,
            this.StartTimeColumn,
            this.EndTimeColumn,
            this.DaysColumn,
            this.RoomColumn,
            this.UnitsColumn});
            this.EnrollmentFormTable.Location = new System.Drawing.Point(9, 14);
            this.EnrollmentFormTable.Name = "EnrollmentFormTable";
            this.EnrollmentFormTable.RowHeadersVisible = false;
            this.EnrollmentFormTable.Size = new System.Drawing.Size(796, 150);
            this.EnrollmentFormTable.TabIndex = 11;
            // 
            // EdpCodeColumn
            // 
            this.EdpCodeColumn.HeaderText = "EDP Code";
            this.EdpCodeColumn.Name = "EdpCodeColumn";
            // 
            // SubjectCodeColumn
            // 
            this.SubjectCodeColumn.HeaderText = "Subject Code";
            this.SubjectCodeColumn.Name = "SubjectCodeColumn";
            this.SubjectCodeColumn.Width = 150;
            // 
            // StartTimeColumn
            // 
            this.StartTimeColumn.HeaderText = "Start Time";
            this.StartTimeColumn.Name = "StartTimeColumn";
            // 
            // EndTimeColumn
            // 
            this.EndTimeColumn.HeaderText = "End Time";
            this.EndTimeColumn.Name = "EndTimeColumn";
            // 
            // DaysColumn
            // 
            this.DaysColumn.HeaderText = "Days";
            this.DaysColumn.Name = "DaysColumn";
            // 
            // RoomColumn
            // 
            this.RoomColumn.HeaderText = "Room";
            this.RoomColumn.Name = "RoomColumn";
            // 
            // UnitsColumn
            // 
            this.UnitsColumn.HeaderText = "Units";
            this.UnitsColumn.Name = "UnitsColumn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.IdNumTextBox);
            this.panel1.Controls.Add(this.EdpCodeTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.YearLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CourseLabel);
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 172);
            this.panel1.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.EnrollmentFormTable);
            this.panel3.Location = new System.Drawing.Point(12, 233);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(818, 176);
            this.panel3.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(654, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total Units";
            // 
            // UnitsLabel
            // 
            this.UnitsLabel.Location = new System.Drawing.Point(718, 415);
            this.UnitsLabel.Name = "UnitsLabel";
            this.UnitsLabel.Size = new System.Drawing.Size(100, 20);
            this.UnitsLabel.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 469);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Encoded By:";
            // 
            // EncodedTextBox
            // 
            this.EncodedTextBox.Location = new System.Drawing.Point(101, 469);
            this.EncodedTextBox.Name = "EncodedTextBox";
            this.EncodedTextBox.Size = new System.Drawing.Size(100, 20);
            this.EncodedTextBox.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Date";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(357, 469);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DateTimePicker.TabIndex = 13;
            // 
            // UCLogo
            // 
            this.UCLogo.Image = ((System.Drawing.Image)(resources.GetObject("UCLogo.Image")));
            this.UCLogo.Location = new System.Drawing.Point(430, 36);
            this.UCLogo.Name = "UCLogo";
            this.UCLogo.Size = new System.Drawing.Size(298, 169);
            this.UCLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UCLogo.TabIndex = 14;
            this.UCLogo.TabStop = false;
            // 
            // ModeButton
            // 
            this.ModeButton.BackColor = System.Drawing.Color.DarkCyan;
            this.ModeButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeButton.Location = new System.Drawing.Point(749, 16);
            this.ModeButton.Name = "ModeButton";
            this.ModeButton.Size = new System.Drawing.Size(75, 53);
            this.ModeButton.TabIndex = 15;
            this.ModeButton.Text = "Dark Mode";
            this.ModeButton.UseVisualStyleBackColor = false;
            this.ModeButton.Click += new System.EventHandler(this.ModeButton_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PrevButton.Location = new System.Drawing.Point(668, 472);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(75, 23);
            this.PrevButton.TabIndex = 22;
            this.PrevButton.Text = "Prev";
            this.PrevButton.UseVisualStyleBackColor = false;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.Salmon;
            this.NextButton.Location = new System.Drawing.Point(749, 472);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 21;
            this.NextButton.Text = "Close";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(584, 477);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Form 3 out of 3";
            // 
            // StudEnrollmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 501);
            this.ControlBox = false;
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ModeButton);
            this.Controls.Add(this.UCLogo);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EncodedTextBox);
            this.Controls.Add(this.UnitsLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "StudEnrollmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Enrollment Form";
            this.Load += new System.EventHandler(this.StudEnrollmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EnrollmentFormTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UCLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdNumTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CourseLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox YearLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EdpCodeTextBox;
        private System.Windows.Forms.DataGridView EnrollmentFormTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn EdpCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitsColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UnitsLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EncodedTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.PictureBox UCLogo;
        private System.Windows.Forms.Button ModeButton;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label label9;
    }
}