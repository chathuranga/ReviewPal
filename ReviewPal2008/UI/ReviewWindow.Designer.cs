namespace ReviewPal.UI
{
    partial class ReviewWindow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewWindow));
            this.gvReviews = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Severity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefectType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InjectedPhase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RevieweeComments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReExamined = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewerComments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.tbtnClear = new System.Windows.Forms.ToolStripButton();
            this.tbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tbtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnSummary = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tbtnOpen = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvReviews)).BeginInit();
            this.toolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvReviews
            // 
            this.gvReviews.AllowUserToAddRows = false;
            this.gvReviews.AllowUserToDeleteRows = false;
            this.gvReviews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gvReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvReviews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Status,
            this.Description,
            this.Severity,
            this.DefectType,
            this.InjectedPhase,
            this.RevieweeComments,
            this.ReExamined,
            this.ReviewerComments});
            this.gvReviews.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvReviews.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gvReviews.Location = new System.Drawing.Point(3, 26);
            this.gvReviews.MultiSelect = false;
            this.gvReviews.Name = "gvReviews";
            this.gvReviews.RowHeadersVisible = false;
            this.gvReviews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvReviews.Size = new System.Drawing.Size(862, 417);
            this.gvReviews.TabIndex = 1;
            this.gvReviews.Visible = false;
            this.gvReviews.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvReviews_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ReviewId";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 30;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Severity
            // 
            this.Severity.DataPropertyName = "Severity";
            this.Severity.HeaderText = "Severity";
            this.Severity.Name = "Severity";
            this.Severity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Severity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DefectType
            // 
            this.DefectType.DataPropertyName = "DefectType";
            this.DefectType.HeaderText = "Defect Type";
            this.DefectType.Name = "DefectType";
            this.DefectType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DefectType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // InjectedPhase
            // 
            this.InjectedPhase.DataPropertyName = "InjectedPhase";
            this.InjectedPhase.HeaderText = "Injected Phace";
            this.InjectedPhase.Name = "InjectedPhase";
            this.InjectedPhase.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.InjectedPhase.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RevieweeComments
            // 
            this.RevieweeComments.DataPropertyName = "RevieweeComment";
            this.RevieweeComments.HeaderText = "Reviewee\'s Comments";
            this.RevieweeComments.Name = "RevieweeComments";
            this.RevieweeComments.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RevieweeComments.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ReExamined
            // 
            this.ReExamined.DataPropertyName = "ReExamined";
            this.ReExamined.HeaderText = "Re-Examined";
            this.ReExamined.Name = "ReExamined";
            this.ReExamined.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ReExamined.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ReviewerComments
            // 
            this.ReviewerComments.DataPropertyName = "ReviewerComment";
            this.ReviewerComments.HeaderText = "Reviewer\'s Comments";
            this.ReviewerComments.Name = "ReviewerComments";
            this.ReviewerComments.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ReviewerComments.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // toolbar
            // 
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnClear,
            this.tbtnDelete,
            this.tbtnEdit,
            this.tbtnAdd,
            this.toolStripSeparator1,
            this.tbtnSummary,
            this.toolStripSeparator2,
            this.tbtnSave,
            this.tbtnOpen});
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolbar.Size = new System.Drawing.Size(868, 25);
            this.toolbar.TabIndex = 10;
            this.toolbar.Text = "toolStrip1";
            // 
            // tbtnClear
            // 
            this.tbtnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnClear.Image = ((System.Drawing.Image)(resources.GetObject("tbtnClear.Image")));
            this.tbtnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnClear.Name = "tbtnClear";
            this.tbtnClear.Size = new System.Drawing.Size(23, 22);
            this.tbtnClear.Text = "Clear Review List";
            this.tbtnClear.Click += new System.EventHandler(this.tbtnClear_Click);
            // 
            // tbtnDelete
            // 
            this.tbtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tbtnDelete.Image")));
            this.tbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnDelete.Name = "tbtnDelete";
            this.tbtnDelete.Size = new System.Drawing.Size(23, 22);
            this.tbtnDelete.Text = "Delete Selected Review";
            this.tbtnDelete.Click += new System.EventHandler(this.tbtnDelete_Click);
            // 
            // tbtnEdit
            // 
            this.tbtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("tbtnEdit.Image")));
            this.tbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnEdit.Name = "tbtnEdit";
            this.tbtnEdit.Size = new System.Drawing.Size(23, 22);
            this.tbtnEdit.Text = "Edit Selected Review";
            this.tbtnEdit.Click += new System.EventHandler(this.tbtnEdit_Click);
            // 
            // tbtnAdd
            // 
            this.tbtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tbtnAdd.Image")));
            this.tbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAdd.Name = "tbtnAdd";
            this.tbtnAdd.Size = new System.Drawing.Size(23, 22);
            this.tbtnAdd.Text = "Add Review";
            this.tbtnAdd.Click += new System.EventHandler(this.tbtnAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnSummary
            // 
            this.tbtnSummary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnSummary.Image = ((System.Drawing.Image)(resources.GetObject("tbtnSummary.Image")));
            this.tbtnSummary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSummary.Name = "tbtnSummary";
            this.tbtnSummary.Size = new System.Drawing.Size(23, 22);
            this.tbtnSummary.Text = "Summary";
            this.tbtnSummary.Click += new System.EventHandler(this.tbtnSummary_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnSave
            // 
            this.tbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tbtnSave.Image")));
            this.tbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSave.Name = "tbtnSave";
            this.tbtnSave.Size = new System.Drawing.Size(23, 22);
            this.tbtnSave.Text = "Save Review List";
            this.tbtnSave.Click += new System.EventHandler(this.tbtnSave_Click);
            // 
            // tbtnOpen
            // 
            this.tbtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("tbtnOpen.Image")));
            this.tbtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnOpen.Name = "tbtnOpen";
            this.tbtnOpen.Size = new System.Drawing.Size(23, 22);
            this.tbtnOpen.Text = "Open Saved Review List";
            this.tbtnOpen.Click += new System.EventHandler(this.tbtnOpen_Click);
            // 
            // ReviewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.gvReviews);
            this.Name = "ReviewWindow";
            this.Size = new System.Drawing.Size(868, 445);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ReviewWindow_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.gvReviews)).EndInit();
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvReviews;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Severity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefectType;
        private System.Windows.Forms.DataGridViewTextBoxColumn InjectedPhase;
        private System.Windows.Forms.DataGridViewTextBoxColumn RevieweeComments;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReExamined;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewerComments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ToolStripButton tbtnClear;
        private System.Windows.Forms.ToolStripButton tbtnDelete;
        private System.Windows.Forms.ToolStripButton tbtnEdit;
        private System.Windows.Forms.ToolStripButton tbtnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbtnSummary;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbtnSave;
        private System.Windows.Forms.ToolStripButton tbtnOpen;

    }
}
