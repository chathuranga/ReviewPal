namespace ReviewPal.UI
{
    partial class ReviewEditor
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stsProject = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsLine = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnOk = new System.Windows.Forms.Button();
            this.grpReview = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbReExamined = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReviewerComments = new System.Windows.Forms.TextBox();
            this.txtRevieweeComments = new System.Windows.Forms.TextBox();
            this.cmbInjectedPhase = new System.Windows.Forms.ComboBox();
            this.cmbDefectType = new System.Windows.Forms.ComboBox();
            this.cmbSeverity = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbComment = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.grpReview.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(72, 86);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(506, 77);
            this.txtDescription.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsProject,
            this.stsFile,
            this.stsLine});
            this.statusStrip1.Location = new System.Drawing.Point(0, 361);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(591, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stsProject
            // 
            this.stsProject.Name = "stsProject";
            this.stsProject.Size = new System.Drawing.Size(53, 17);
            this.stsProject.Text = "Project : ";
            // 
            // stsFile
            // 
            this.stsFile.Name = "stsFile";
            this.stsFile.Size = new System.Drawing.Size(31, 17);
            this.stsFile.Text = "File: ";
            // 
            // stsLine
            // 
            this.stsLine.Name = "stsLine";
            this.stsLine.Size = new System.Drawing.Size(38, 17);
            this.stsLine.Text = "Line : ";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(421, 329);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // grpReview
            // 
            this.grpReview.Controls.Add(this.btnCancel);
            this.grpReview.Controls.Add(this.cmbReExamined);
            this.grpReview.Controls.Add(this.label9);
            this.grpReview.Controls.Add(this.txtReviewerComments);
            this.grpReview.Controls.Add(this.txtRevieweeComments);
            this.grpReview.Controls.Add(this.cmbInjectedPhase);
            this.grpReview.Controls.Add(this.cmbDefectType);
            this.grpReview.Controls.Add(this.cmbSeverity);
            this.grpReview.Controls.Add(this.cmbStatus);
            this.grpReview.Controls.Add(this.label8);
            this.grpReview.Controls.Add(this.label7);
            this.grpReview.Controls.Add(this.cmbComment);
            this.grpReview.Controls.Add(this.label6);
            this.grpReview.Controls.Add(this.label5);
            this.grpReview.Controls.Add(this.label4);
            this.grpReview.Controls.Add(this.label3);
            this.grpReview.Controls.Add(this.label2);
            this.grpReview.Controls.Add(this.label1);
            this.grpReview.Controls.Add(this.txtDescription);
            this.grpReview.Controls.Add(this.btnOk);
            this.grpReview.Location = new System.Drawing.Point(2, 2);
            this.grpReview.Name = "grpReview";
            this.grpReview.Size = new System.Drawing.Size(587, 358);
            this.grpReview.TabIndex = 4;
            this.grpReview.TabStop = false;
            this.grpReview.Text = "Review ID : ";
            this.grpReview.Enter += new System.EventHandler(this.grpReview_Enter);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(502, 329);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbReExamined
            // 
            this.cmbReExamined.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReExamined.FormattingEnabled = true;
            this.cmbReExamined.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbReExamined.Location = new System.Drawing.Point(502, 57);
            this.cmbReExamined.Name = "cmbReExamined";
            this.cmbReExamined.Size = new System.Drawing.Size(71, 21);
            this.cmbReExamined.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(423, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Re-Examined :";
            // 
            // txtReviewerComments
            // 
            this.txtReviewerComments.Location = new System.Drawing.Point(130, 250);
            this.txtReviewerComments.Multiline = true;
            this.txtReviewerComments.Name = "txtReviewerComments";
            this.txtReviewerComments.Size = new System.Drawing.Size(448, 77);
            this.txtReviewerComments.TabIndex = 19;
            // 
            // txtRevieweeComments
            // 
            this.txtRevieweeComments.Location = new System.Drawing.Point(130, 167);
            this.txtRevieweeComments.Multiline = true;
            this.txtRevieweeComments.Name = "txtRevieweeComments";
            this.txtRevieweeComments.Size = new System.Drawing.Size(448, 77);
            this.txtRevieweeComments.TabIndex = 18;
            // 
            // cmbInjectedPhase
            // 
            this.cmbInjectedPhase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInjectedPhase.FormattingEnabled = true;
            this.cmbInjectedPhase.Items.AddRange(new object[] {
            "Initial Project Setup",
            "Project Initiation",
            "Requirements Analysis",
            "Architecture and Design",
            "Implementation",
            "QA testing",
            "Transition Phase"});
            this.cmbInjectedPhase.Location = new System.Drawing.Point(100, 57);
            this.cmbInjectedPhase.Name = "cmbInjectedPhase";
            this.cmbInjectedPhase.Size = new System.Drawing.Size(117, 21);
            this.cmbInjectedPhase.TabIndex = 17;
            // 
            // cmbDefectType
            // 
            this.cmbDefectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDefectType.FormattingEnabled = true;
            this.cmbDefectType.Items.AddRange(new object[] {
            "Logical",
            "Incomplete",
            "UI",
            "Exception Handling",
            "Documentation "});
            this.cmbDefectType.Location = new System.Drawing.Point(300, 27);
            this.cmbDefectType.Name = "cmbDefectType";
            this.cmbDefectType.Size = new System.Drawing.Size(117, 21);
            this.cmbDefectType.TabIndex = 16;
            // 
            // cmbSeverity
            // 
            this.cmbSeverity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeverity.FormattingEnabled = true;
            this.cmbSeverity.Items.AddRange(new object[] {
            "Major",
            "Medium",
            "Minor"});
            this.cmbSeverity.Location = new System.Drawing.Point(300, 57);
            this.cmbSeverity.Name = "cmbSeverity";
            this.cmbSeverity.Size = new System.Drawing.Size(117, 21);
            this.cmbSeverity.TabIndex = 15;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Open",
            "On hold",
            "Closed",
            "Rejected"});
            this.cmbStatus.Location = new System.Drawing.Point(502, 26);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(71, 21);
            this.cmbStatus.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Reviewer\'s Comments";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(453, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Status :";
            // 
            // cmbComment
            // 
            this.cmbComment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComment.FormattingEnabled = true;
            this.cmbComment.Items.AddRange(new object[] {
            "Error",
            "Suggestion"});
            this.cmbComment.Location = new System.Drawing.Point(100, 26);
            this.cmbComment.Name = "cmbComment";
            this.cmbComment.Size = new System.Drawing.Size(117, 21);
            this.cmbComment.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Reviewee\'s Comments";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Injected Phase :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Defect Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Severity :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Comments :";
            // 
            // ReviewEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 383);
            this.Controls.Add(this.grpReview);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReviewEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReviewEditor";
            this.TopMost = true;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpReview.ResumeLayout(false);
            this.grpReview.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stsLine;
        private System.Windows.Forms.ToolStripStatusLabel stsFile;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ToolStripStatusLabel stsProject;
        private System.Windows.Forms.GroupBox grpReview;
        private System.Windows.Forms.ComboBox cmbComment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbInjectedPhase;
        private System.Windows.Forms.ComboBox cmbDefectType;
        private System.Windows.Forms.ComboBox cmbSeverity;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtReviewerComments;
        private System.Windows.Forms.TextBox txtRevieweeComments;
        private System.Windows.Forms.ComboBox cmbReExamined;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancel;

    }
}