using System.Windows;
using EnvDTE;
using ReviewPal.Core;
using MessageBox = System.Windows.MessageBox;
using Window = System.Windows.Window;

namespace ReviewPal.ReviewPal2012.UI
{
    /// <summary>
    /// Interaction logic for ReviewEditor.xaml
    /// </summary>
    public partial class ReviewEditor : Window
    {
        #region Private members

        /// <summary>
        /// reviewId currently being edited.
        /// </summary>
        private int _reviewId;

        private bool _isNew;

        private Review _review;

        private readonly ReviewRepository _reviewRepo;

        #endregion

        #region Public members

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewEditor"/> class.
        /// </summary>
        /// <param name="reviewRepo"></param>
        public ReviewEditor(ReviewRepository reviewRepo)
        {
            InitializeComponent();
            _reviewRepo = reviewRepo;
        }

        /// <summary>
        /// Sets the review properties in the ReviewEditor window.
        /// </summary>
        /// <param name="rev">The rev.</param>
        public void SetReview(Review rev)
        {
            //if this a new addition, passed in Review will be null
            if(rev == null)
            {
                _isNew = true;
                // TODO: this needs to be moved into the VSIDEHelper
                TextSelection textSelection = (TextSelection)VSIDEHelper.VisualStudioInstance.ActiveDocument.Selection;
                int line = textSelection.CurrentLine;
                int col = textSelection.CurrentColumn;
                string file = VSIDEHelper.VisualStudioInstance.ActiveDocument.Name;
                string project = VSIDEHelper.VisualStudioInstance.ActiveDocument.ProjectItem.ContainingProject.Name;

                rev = new Review()
                {
                    ReviewId = _reviewRepo.GetNextReviewId(),
                    Project = project,
                    File = file,
                    Line = line
                };
            }
            else
            {
                _isNew = false;
            }
            _reviewId = rev.ReviewId;
            grpReview.Header = "Review ID : " + _reviewId;
            if (!_isNew)
            {
                UIHelper.SelectByString(cmbComment, rev.Comment);
                UIHelper.SelectByString(cmbStatus, rev.Status);
                UIHelper.SelectByString(cmbReExamined, rev.ReExamined);
                UIHelper.SelectByString(cmbSeverity, rev.Severity);
                UIHelper.SelectByString(cmbDefectType, rev.DefectType);
                UIHelper.SelectByString(cmbInjectedPhase, rev.InjectedPhase);
            }

            txtDescription.Text = rev.Description;
            txtRevieweeComments.Text = rev.RevieweeComment;
            txtReviewerComments.Text = rev.ReviewerComment;

            stsProject.Text = "Project : " + rev.Project;
            stsFile.Text = "File: " + rev.File;
            stsLine.Text = "Line : " + rev.Line;

            _review = rev;
        }

        /// <summary>
        /// Updates the review properties.
        /// </summary>
        /// <param name="review">The review.</param>
        private void UpdateReview(Review review)
        {
            review.Comment = cmbComment.Text;
            review.Status = cmbStatus.Text;

            review.ReExamined = cmbReExamined.Text;
            review.Severity = cmbSeverity.Text;
            review.DefectType = cmbDefectType.Text;
            review.InjectedPhase = cmbInjectedPhase.Text;

            review.Description = txtDescription.Text;
            review.RevieweeComment = txtRevieweeComments.Text;
            review.ReviewerComment = txtReviewerComments.Text;

            review.Line = int.Parse(stsLine.Text.Substring(6));
            review.File = stsFile.Text.Substring(6);
            review.Project = stsProject.Text.Substring(10);
        }

        #endregion

        #region Event handlers
        
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (txtDescription.Text.Length > 0)
            {
                UpdateReview(_review);
                if (_isNew)
                {
                    _reviewRepo.Add(_review);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Please input description.", Utils.AssemblyTitle);
            }
        }

        #endregion
    }
}
