using System;
using System.Windows.Forms;
using ReviewPal.Core;

namespace ReviewPal.UI
{
    /// <summary>
    /// Individual review editor window.
    /// </summary>
    public partial class ReviewEditor : Form
    {
        #region Private members

        /// <summary>
        /// reviewId currently being edited.
        /// </summary>
        private int _reviewId;

        #endregion

        #region Public members

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewEditor"/> class.
        /// </summary>
        public ReviewEditor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the review properties in the ReviewEditor window.
        /// </summary>
        /// <param name="rev">The rev.</param>
        /// <param name="isNew">if set to <c>true</c> [is new].</param>
        public void SetReview(Review rev, bool isNew)
        {
            _reviewId = rev.ReviewId;
            grpReview.Text = "Review ID : " + _reviewId;
            if(isNew)
            {

                cmbComment.SelectedIndex = 0;
                cmbStatus.SelectedIndex = 0;
                cmbReExamined.SelectedIndex = 0;
                cmbSeverity.SelectedIndex = 0;
                cmbDefectType.SelectedIndex = 0;
                cmbInjectedPhase.SelectedIndex = 0;
            }
            else
            {
                cmbComment.SelectedValue = rev.Comment;
                cmbStatus.SelectedValue = rev.Status;
                cmbReExamined.SelectedValue = rev.ReExamined;
                cmbSeverity.SelectedValue = rev.Severity;
                cmbDefectType.SelectedValue = rev.DefectType;
                cmbInjectedPhase.SelectedValue = rev.InjectedPhase;
            }

            txtDescription.Text = rev.Description;
            txtRevieweeComments.Text = rev.RevieweeComment;
            txtReviewerComments.Text = rev.ReviewerComment;

            stsProject.Text = "Project : " + rev.Project;
            stsFile.Text = "File: " + rev.File;
            stsLine.Text = "Line : " + rev.Line.ToString();
        }

        /// <summary>
        /// Updates the review properties.
        /// </summary>
        /// <param name="review">The review.</param>
        public void UpdateReview(Review review)
        {
            review.Comment = cmbComment.Text;
            review.Status = cmbStatus.Text;

            review.ReExamined = cmbReExamined.SelectedItem.ToString();
            review.Severity = cmbSeverity.SelectedItem.ToString();
            review.DefectType = cmbDefectType.SelectedItem.ToString();
            review.InjectedPhase = cmbInjectedPhase.SelectedItem.ToString();

            review.Description = txtDescription.Text;
            review.RevieweeComment = txtRevieweeComments.Text;
            review.ReviewerComment = txtReviewerComments.Text;

            review.Line = int.Parse(stsLine.Text.Substring(6));
            review.File = stsFile.Text.Substring(6);
            review.Project = stsProject.Text.Substring(10);
        }

        #endregion

        #region Event handlers

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text.Length > 0)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please input description.", Utils.AssemblyTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void grpReview_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #endregion
    }
}
