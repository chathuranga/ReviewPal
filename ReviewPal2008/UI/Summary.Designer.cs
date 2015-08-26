namespace ReviewPal.UI
{
    partial class Summary
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
            this.txtProject = new System.Windows.Forms.TextBox();
            this.txtReviewEffort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReworkEffort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtProjectCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWorkProductName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWorkProductVersion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWorkProductSize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReviewedBy = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtReviewEfficiency = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtReviewActionTakenBy = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtReviewPreparationEffort = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtWorkProductReleaseDateForReview = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtReviewActionTakenDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Project Name :";
            // 
            // txtProject
            // 
            this.txtProject.Location = new System.Drawing.Point(174, 32);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(224, 20);
            this.txtProject.TabIndex = 1;
            // 
            // txtReviewEffort
            // 
            this.txtReviewEffort.Location = new System.Drawing.Point(184, 171);
            this.txtReviewEffort.Name = "txtReviewEffort";
            this.txtReviewEffort.Size = new System.Drawing.Size(75, 20);
            this.txtReviewEffort.TabIndex = 13;
            this.txtReviewEffort.TextChanged += new System.EventHandler(this.txtReviewEffort_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Review effort :";
            // 
            // txtReworkEffort
            // 
            this.txtReworkEffort.Location = new System.Drawing.Point(184, 197);
            this.txtReworkEffort.Name = "txtReworkEffort";
            this.txtReworkEffort.Size = new System.Drawing.Size(75, 20);
            this.txtReworkEffort.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Rework effort :";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(359, 491);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtProjectCode
            // 
            this.txtProjectCode.Location = new System.Drawing.Point(174, 58);
            this.txtProjectCode.Name = "txtProjectCode";
            this.txtProjectCode.Size = new System.Drawing.Size(224, 20);
            this.txtProjectCode.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Project Code :";
            // 
            // txtWorkProductName
            // 
            this.txtWorkProductName.Location = new System.Drawing.Point(174, 84);
            this.txtWorkProductName.Name = "txtWorkProductName";
            this.txtWorkProductName.Size = new System.Drawing.Size(224, 20);
            this.txtWorkProductName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Work Product Name :";
            // 
            // txtWorkProductVersion
            // 
            this.txtWorkProductVersion.Location = new System.Drawing.Point(174, 110);
            this.txtWorkProductVersion.Name = "txtWorkProductVersion";
            this.txtWorkProductVersion.Size = new System.Drawing.Size(224, 20);
            this.txtWorkProductVersion.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Work Product Version :";
            // 
            // txtWorkProductSize
            // 
            this.txtWorkProductSize.Location = new System.Drawing.Point(245, 126);
            this.txtWorkProductSize.Name = "txtWorkProductSize";
            this.txtWorkProductSize.Size = new System.Drawing.Size(98, 20);
            this.txtWorkProductSize.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Work Product Size (EKLOC) :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Work Product Released Date For Review :";
            // 
            // txtReviewedBy
            // 
            this.txtReviewedBy.Location = new System.Drawing.Point(151, 231);
            this.txtReviewedBy.Name = "txtReviewedBy";
            this.txtReviewedBy.Size = new System.Drawing.Size(247, 20);
            this.txtReviewedBy.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Reviewed by :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Reviewed Date :";
            // 
            // txtReviewEfficiency
            // 
            this.txtReviewEfficiency.Location = new System.Drawing.Point(184, 223);
            this.txtReviewEfficiency.Name = "txtReviewEfficiency";
            this.txtReviewEfficiency.Size = new System.Drawing.Size(75, 20);
            this.txtReviewEfficiency.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(68, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Reviewed Efficiency :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(80, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Status :";
            // 
            // txtReviewActionTakenBy
            // 
            this.txtReviewActionTakenBy.Location = new System.Drawing.Point(184, 93);
            this.txtReviewActionTakenBy.Name = "txtReviewActionTakenBy";
            this.txtReviewActionTakenBy.Size = new System.Drawing.Size(192, 20);
            this.txtReviewActionTakenBy.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Review Action Taken By :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Review Action Taken Date :";
            // 
            // txtReviewPreparationEffort
            // 
            this.txtReviewPreparationEffort.Location = new System.Drawing.Point(184, 145);
            this.txtReviewPreparationEffort.Name = "txtReviewPreparationEffort";
            this.txtReviewPreparationEffort.Size = new System.Drawing.Size(75, 20);
            this.txtReviewPreparationEffort.TabIndex = 12;
            this.txtReviewPreparationEffort.TextChanged += new System.EventHandler(this.txtReviewPreparationEffort_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(44, 148);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Review Preparation Effort :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtWorkProductReleaseDateForReview);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtWorkProductSize);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 197);
            this.panel1.TabIndex = 39;
            // 
            // dtWorkProductReleaseDateForReview
            // 
            this.dtWorkProductReleaseDateForReview.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtWorkProductReleaseDateForReview.Location = new System.Drawing.Point(245, 155);
            this.dtWorkProductReleaseDateForReview.Name = "dtWorkProductReleaseDateForReview";
            this.dtWorkProductReleaseDateForReview.Size = new System.Drawing.Size(98, 20);
            this.dtWorkProductReleaseDateForReview.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dtReviewActionTakenDate);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.cmbStatus);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtReviewEfficiency);
            this.panel2.Controls.Add(this.txtReviewPreparationEffort);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtReviewEffort);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtReviewActionTakenBy);
            this.panel2.Controls.Add(this.txtReworkEffort);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(21, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 260);
            this.panel2.TabIndex = 40;
            // 
            // dtReviewActionTakenDate
            // 
            this.dtReviewActionTakenDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReviewActionTakenDate.Location = new System.Drawing.Point(184, 119);
            this.dtReviewActionTakenDate.Name = "dtReviewActionTakenDate";
            this.dtReviewActionTakenDate.Size = new System.Drawing.Size(98, 20);
            this.dtReviewActionTakenDate.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(129, 41);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.SystemColors.Window;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Release after correction",
            "Ready for Release",
            "Reject"});
            this.cmbStatus.Location = new System.Drawing.Point(129, 66);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(247, 21);
            this.cmbStatus.TabIndex = 9;
            // 
            // Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 526);
            this.Controls.Add(this.txtReviewedBy);
            this.Controls.Add(this.txtWorkProductVersion);
            this.Controls.Add(this.txtWorkProductName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProjectCode);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtProject);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Summary";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Summary";
            this.Load += new System.EventHandler(this.Summary_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.TextBox txtReviewEffort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReworkEffort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtProjectCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWorkProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWorkProductVersion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWorkProductSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReviewedBy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtReviewEfficiency;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtReviewActionTakenBy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtReviewPreparationEffort;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker dtWorkProductReleaseDateForReview;
        private System.Windows.Forms.DateTimePicker dtReviewActionTakenDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}