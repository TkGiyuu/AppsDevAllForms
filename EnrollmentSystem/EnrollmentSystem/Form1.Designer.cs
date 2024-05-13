namespace EnrollmentSystem
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OfferingComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CourseCodeComboBox = new System.Windows.Forms.ComboBox();
            this.SubjectCodeTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.UnitsTextBox = new System.Windows.Forms.TextBox();
            this.CurriculumYearTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SubjectCodeRequisiteTextBox = new System.Windows.Forms.TextBox();
            this.PreRequisiteRadioButton = new System.Windows.Forms.RadioButton();
            this.CoRequisiteRadioButton = new System.Windows.Forms.RadioButton();
            this.SubjectDataGridView = new System.Windows.Forms.DataGridView();
            this.SubjectCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoPreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(181, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SpringGreen;
            this.label2.Location = new System.Drawing.Point(293, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SpringGreen;
            this.label3.Location = new System.Drawing.Point(298, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SpringGreen;
            this.label4.Location = new System.Drawing.Point(327, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Units:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SpringGreen;
            this.label5.Location = new System.Drawing.Point(314, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Offering:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SpringGreen;
            this.label6.Location = new System.Drawing.Point(309, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Category:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SpringGreen;
            this.label7.Location = new System.Drawing.Point(293, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "CourseCode:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SpringGreen;
            this.label8.Location = new System.Drawing.Point(277, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Curriculum Year:";
            // 
            // OfferingComboBox
            // 
            this.OfferingComboBox.FormattingEnabled = true;
            this.OfferingComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.OfferingComboBox.Location = new System.Drawing.Point(388, 178);
            this.OfferingComboBox.Name = "OfferingComboBox";
            this.OfferingComboBox.Size = new System.Drawing.Size(121, 21);
            this.OfferingComboBox.TabIndex = 8;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "Lec",
            "Lab"});
            this.CategoryComboBox.Location = new System.Drawing.Point(388, 205);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(95, 21);
            this.CategoryComboBox.TabIndex = 9;
            // 
            // CourseCodeComboBox
            // 
            this.CourseCodeComboBox.FormattingEnabled = true;
            this.CourseCodeComboBox.Items.AddRange(new object[] {
            "BSIT",
            "BSIS",
            "ACT"});
            this.CourseCodeComboBox.Location = new System.Drawing.Point(388, 232);
            this.CourseCodeComboBox.Name = "CourseCodeComboBox";
            this.CourseCodeComboBox.Size = new System.Drawing.Size(121, 21);
            this.CourseCodeComboBox.TabIndex = 10;
            // 
            // SubjectCodeTextBox
            // 
            this.SubjectCodeTextBox.Location = new System.Drawing.Point(388, 100);
            this.SubjectCodeTextBox.Name = "SubjectCodeTextBox";
            this.SubjectCodeTextBox.Size = new System.Drawing.Size(81, 20);
            this.SubjectCodeTextBox.TabIndex = 11;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(388, 126);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(121, 20);
            this.DescriptionTextBox.TabIndex = 12;
            // 
            // UnitsTextBox
            // 
            this.UnitsTextBox.Location = new System.Drawing.Point(388, 152);
            this.UnitsTextBox.Name = "UnitsTextBox";
            this.UnitsTextBox.Size = new System.Drawing.Size(58, 20);
            this.UnitsTextBox.TabIndex = 13;
            // 
            // CurriculumYearTextBox
            // 
            this.CurriculumYearTextBox.Location = new System.Drawing.Point(388, 259);
            this.CurriculumYearTextBox.Name = "CurriculumYearTextBox";
            this.CurriculumYearTextBox.Size = new System.Drawing.Size(95, 20);
            this.CurriculumYearTextBox.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Font = new System.Drawing.Font("Script MT Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label9.Location = new System.Drawing.Point(257, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 44);
            this.label9.TabIndex = 15;
            this.label9.Text = "Subject Entry";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.DimGray;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(184, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(370, 221);
            this.label10.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.DarkGray;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(120, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(511, 184);
            this.label11.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(120, 297);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Requisite Information";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.SpringGreen;
            this.label13.Location = new System.Drawing.Point(158, 331);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Subject Code:";
            // 
            // SubjectCodeRequisiteTextBox
            // 
            this.SubjectCodeRequisiteTextBox.Location = new System.Drawing.Point(238, 328);
            this.SubjectCodeRequisiteTextBox.Name = "SubjectCodeRequisiteTextBox";
            this.SubjectCodeRequisiteTextBox.Size = new System.Drawing.Size(111, 20);
            this.SubjectCodeRequisiteTextBox.TabIndex = 20;
            this.SubjectCodeRequisiteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SubjectCodeRequisiteTextBox_KeyPress);
            // 
            // PreRequisiteRadioButton
            // 
            this.PreRequisiteRadioButton.AutoSize = true;
            this.PreRequisiteRadioButton.BackColor = System.Drawing.Color.SpringGreen;
            this.PreRequisiteRadioButton.Location = new System.Drawing.Point(388, 327);
            this.PreRequisiteRadioButton.Name = "PreRequisiteRadioButton";
            this.PreRequisiteRadioButton.Size = new System.Drawing.Size(88, 17);
            this.PreRequisiteRadioButton.TabIndex = 21;
            this.PreRequisiteRadioButton.TabStop = true;
            this.PreRequisiteRadioButton.Text = "Pre-Requisite";
            this.PreRequisiteRadioButton.UseVisualStyleBackColor = false;
            // 
            // CoRequisiteRadioButton
            // 
            this.CoRequisiteRadioButton.AutoSize = true;
            this.CoRequisiteRadioButton.BackColor = System.Drawing.Color.SpringGreen;
            this.CoRequisiteRadioButton.Location = new System.Drawing.Point(388, 350);
            this.CoRequisiteRadioButton.Name = "CoRequisiteRadioButton";
            this.CoRequisiteRadioButton.Size = new System.Drawing.Size(85, 17);
            this.CoRequisiteRadioButton.TabIndex = 22;
            this.CoRequisiteRadioButton.TabStop = true;
            this.CoRequisiteRadioButton.Text = "Co-Requisite";
            this.CoRequisiteRadioButton.UseVisualStyleBackColor = false;
            // 
            // SubjectDataGridView
            // 
            this.SubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectCodeColumn,
            this.DescriptionColumn,
            this.UnitsColumn,
            this.CoPreColumn});
            this.SubjectDataGridView.Location = new System.Drawing.Point(161, 373);
            this.SubjectDataGridView.Name = "SubjectDataGridView";
            this.SubjectDataGridView.Size = new System.Drawing.Size(440, 92);
            this.SubjectDataGridView.TabIndex = 23;
            // 
            // SubjectCodeColumn
            // 
            this.SubjectCodeColumn.HeaderText = "Subject Code";
            this.SubjectCodeColumn.Name = "SubjectCodeColumn";
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.Name = "DescriptionColumn";
            // 
            // UnitsColumn
            // 
            this.UnitsColumn.HeaderText = "Units";
            this.UnitsColumn.Name = "UnitsColumn";
            // 
            // CoPreColumn
            // 
            this.CoPreColumn.HeaderText = "Co/Pre";
            this.CoPreColumn.Name = "CoPreColumn";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SaveButton.Location = new System.Drawing.Point(174, 484);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 24;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CancelButton.Location = new System.Drawing.Point(454, 484);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 25;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(731, 545);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SubjectDataGridView);
            this.Controls.Add(this.CoRequisiteRadioButton);
            this.Controls.Add(this.PreRequisiteRadioButton);
            this.Controls.Add(this.SubjectCodeRequisiteTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CurriculumYearTextBox);
            this.Controls.Add(this.UnitsTextBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.SubjectCodeTextBox);
            this.Controls.Add(this.CourseCodeComboBox);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.OfferingComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox OfferingComboBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.ComboBox CourseCodeComboBox;
        private System.Windows.Forms.TextBox SubjectCodeTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox UnitsTextBox;
        private System.Windows.Forms.TextBox CurriculumYearTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox SubjectCodeRequisiteTextBox;
        private System.Windows.Forms.RadioButton PreRequisiteRadioButton;
        private System.Windows.Forms.RadioButton CoRequisiteRadioButton;
        private System.Windows.Forms.DataGridView SubjectDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoPreColumn;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
    }
}

