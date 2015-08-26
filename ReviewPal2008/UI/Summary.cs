using System;
using System.Windows.Forms;
using ReviewPal.Core;

namespace ReviewPal.UI
{
    public partial class Summary : Form
    {
        #region Private members

        /// <summary>
        /// Reference to the CodeReview object
        /// </summary>
        private CodeReview _codeReview;

        #endregion

        #region Public members

        /// <summary>
        /// Initializes a new instance of the <see cref="Summary"/> class.
        /// </summary>
        public Summary()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Updates the code review.
        /// </summary>
        /// <param name="codeReview">The code review.</param>
        public void UpdateCodeReview(CodeReview codeReview)
        {
            try
            {
                codeReview.ProjectName = txtProject.Text;
                codeReview.ProjectCode = txtProjectCode.Text;
                codeReview.WorkProductName = txtWorkProductName.Text;
                codeReview.WorkProductVersion = txtWorkProductVersion.Text;
                codeReview.WorkProductSize = txtWorkProductSize.Text;
                codeReview.WorkProductReleaseDateForReview = dtWorkProductReleaseDateForReview.Text;

                codeReview.ReviewedBy = txtReviewedBy.Text;
                codeReview.ReviewedDate = dateTimePicker2.Text;
                codeReview.ReviewStatus = cmbStatus.Text;
                codeReview.ReviewActionTakenBy = txtReviewActionTakenBy.Text;
                codeReview.ReviewActionTakenDate = dtReviewActionTakenDate.Text;
                codeReview.ReviewPreparationEffort = txtReviewPreparationEffort.Text;
                codeReview.ReviewEffort = txtReviewEffort.Text;
                codeReview.ReworkEffrot = txtReworkEffort.Text;
            }
            catch (Exception ex)
            {
                Utils.HandleException(ex);
            }
        }


        /// <summary>
        /// Sets the summary.
        /// </summary>
        /// <param name="codeReview">The code review.</param>
        public void SetSummary(CodeReview codeReview)
        {
            try
            {
                _codeReview = codeReview;

                txtProject.Text = codeReview.ProjectName;
                txtProjectCode.Text = codeReview.ProjectCode;
                txtWorkProductName.Text = codeReview.WorkProductName;
                txtWorkProductVersion.Text = codeReview.WorkProductVersion;
                txtWorkProductSize.Text = codeReview.WorkProductSize;
                dtWorkProductReleaseDateForReview.Text = codeReview.WorkProductReleaseDateForReview;

                txtReviewedBy.Text = codeReview.ReviewedBy;
                dateTimePicker2.Text = codeReview.ReviewedDate;
                cmbStatus.SelectedIndex = cmbStatus.FindStringExact(codeReview.ReviewStatus);
                txtReviewActionTakenBy.Text = codeReview.ReviewActionTakenBy;
                dtReviewActionTakenDate.Text = codeReview.ReviewActionTakenDate;
                txtReviewPreparationEffort.Text = codeReview.ReviewPreparationEffort;
                txtReviewEffort.Text = codeReview.ReviewEffort;
                txtReworkEffort.Text = codeReview.ReworkEffrot;
                
                CalculateReviewEfficiency(codeReview);
            }
            catch (Exception ex)
            {
                Utils.HandleException(ex);
            }
        }

        #endregion

        #region Event handlers

        /// <summary>
        /// Handles the Load event of the Summary control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void Summary_Load(object sender, EventArgs e)
        {
            txtProject.Focus();
        }

        /// <summary>
        /// Handles the TextChanged event of the txtReviewPreparationEffort control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void txtReviewPreparationEffort_TextChanged(object sender, EventArgs e)
        {
            CalculateReviewEfficiency(_codeReview);
        }

        /// <summary>
        /// Handles the TextChanged event of the txtReviewEffort control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void txtReviewEffort_TextChanged(object sender, EventArgs e)
        {
            CalculateReviewEfficiency(_codeReview);
        }

        /// <summary>
        /// Handles the Click event of the btnOk control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion

        #region Private helpers

        /// <summary>
        /// Calculates the review efficiency.
        /// </summary>
        /// <param name="codeReview">The code review.</param>
        private void CalculateReviewEfficiency(CodeReview codeReview)
        {
            try
            {
                double reviewEfficiency = ((double.Parse(txtReviewEffort.Text) +
                                            double.Parse(txtReviewPreparationEffort.Text)) * 100 /
                                           codeReview.Reviews.Count);
                reviewEfficiency = Math.Round(reviewEfficiency, 2);
                txtReviewEfficiency.Text = Convert.ToString(reviewEfficiency);
            }
            catch (Exception ex)
            {
                txtReviewEfficiency.Text = "Data Invalid";
            }
        }

        #endregion
    }
}
