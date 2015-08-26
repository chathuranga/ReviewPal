using System;
using System.Windows;
using System.Windows.Controls;
using ReviewPal.Core;

namespace ReviewPal.ReviewPal2012.UI
{
    /// <summary>
    /// Interaction logic for Summary.xaml
    /// </summary>
    public partial class Summary : Window
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
        public void UpdateCodeReview()
        {
            try
            {
                _codeReview.ProjectName = txtProject.Text;
                _codeReview.ProjectCode = txtProjectCode.Text;
                _codeReview.WorkProductName = txtWorkProductName.Text;
                _codeReview.WorkProductVersion = txtWorkProductVersion.Text;
                _codeReview.WorkProductSize = txtWorkProductSize.Text;
                _codeReview.WorkProductReleaseDateForReview = dtWorkProductReleaseDateForReview.Text;

                _codeReview.ReviewedBy = txtReviewedBy.Text;
                _codeReview.ReviewedDate = dtReviewedDate.Text;
                _codeReview.ReviewStatus = cmbStatus.Text;
                _codeReview.ReviewActionTakenBy = txtReviewActionTakenBy.Text;
                _codeReview.ReviewActionTakenDate = dtReviewActionTakenDate.Text;
                _codeReview.ReviewPreparationEffort = txtReviewPreparationEffort.Text;
                _codeReview.ReviewEffort = txtReviewEffort.Text;
                _codeReview.ReworkEffrot = txtReworkEffort.Text;
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
                dtReviewedDate.Text = codeReview.ReviewedDate;
                UIHelper.SelectByString(cmbStatus, codeReview.ReviewStatus);
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
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            UpdateCodeReview();
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
            catch (Exception)
            {
                txtReviewEfficiency.Text = "";
            }
        }

        #endregion
    }
}
