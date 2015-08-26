using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using EnvDTE;
using EnvDTE80;
using ReviewPal.Core;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.XPath;

namespace ReviewPal.UI
{
    /// <summary>
    /// Main toolwindow for holding the review list.
    /// </summary>
    public partial class ReviewWindow : UserControl
    {
        #region Private fields

        public DTE2 VisualStudioInstance;

        private static readonly ReviewEditor ReviewEditor = new ReviewEditor();
        private static readonly Summary Summary = new Summary();
        private readonly ReviewRepository _reviewRepo = new ReviewRepositoryInMemory();
        private BindingSource _bindingSource;
        private string _fileLocation;

        private const string SolutionNotOpen = "Please open the solution in Visial Studio";

        #endregion

        #region Public members

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewWindow"/> class.
        /// </summary>
        public ReviewWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets the review grid.
        /// </summary>
        /// <value>The review grid.</value>
        public DataGridView ReviewGrid
        {
            get { return gvReviews; }            
        }

        #endregion

        #region Event handlers

        /// <summary>
        /// Handles the CellDoubleClick event of the gvReviews control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void gvReviews_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = ReviewGrid.Rows[e.RowIndex];
                var reviewId = int.Parse(row.Cells[Review.ColumnReviewId].Value.ToString());
                bool itemFound = false;
                foreach (Project project in VisualStudioInstance.Solution.Projects)
                {
                    VSIDEHelper.ScanForProjectItems(project, _reviewRepo.Get(reviewId), HandleProjectItem, out itemFound);
                    if(itemFound)
                        return;
                }
                if(!itemFound)
                {
                    MessageBox.Show("Project item not found", Utils.AssemblyTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ex);
            }
        }

        /// <summary>
        /// Handles the MouseDoubleClick event of the ReviewWindow control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        private void ReviewWindow_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Developed by\n" + "Chathuranga K. Wijeratna, chathurangaw@gmail.com\n" +
                            "Code contributions by Vincent Zhang,  seagele0128@gmail.com", "About " + Utils.AssemblyTitle,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        /// <summary>
        /// Handles the Click event of the tbtnClear control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void tbtnClear_Click(object sender, EventArgs e)
        {
            try
            {
                if (0 == _reviewRepo.GetCount())
                {
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure to clear all items?", Utils.AssemblyTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == result)
                {
                    _reviewRepo.Clear();
                    RefreshReviewList();
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of the tbtnDelete control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void tbtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var row = gvReviews.CurrentRow;
                if (row != null)
                {
                    DialogResult result = MessageBox.Show("Are you sure to delete this item?", Utils.AssemblyTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == result)
                    {
                        var reviewId = int.Parse(row.Cells[Review.ColumnReviewId].Value.ToString());
                        Review reviewToDelete = _reviewRepo.Get(reviewId);
                        _reviewRepo.Delete(reviewToDelete);
                        RefreshReviewList();
                    }
                }
                else
                {
                    MessageBox.Show("No current row to Delete", Utils.AssemblyTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of the tbtnEdit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void tbtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var row = gvReviews.CurrentRow;
                if (row != null)
                {
                    var reviewId = int.Parse(row.Cells[Review.ColumnReviewId].Value.ToString());
                    Review reviewToEdit = _reviewRepo.Get(reviewId);
                    ReviewEditor.SetReview(reviewToEdit, false);
                    DialogResult result = ReviewEditor.ShowDialog(this);
                    if (result == DialogResult.OK)
                    {
                        ReviewEditor.UpdateReview(reviewToEdit);
                        RefreshReviewList();
                    }
                }
                else
                {
                    MessageBox.Show("No current row to Edit", Utils.AssemblyTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of the tbtnAdd control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void tbtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (VisualStudioInstance.Solution.IsOpen)
                {
                    var test = VisualStudioInstance;
                    TextSelection textSelection = (TextSelection)VisualStudioInstance.ActiveDocument.Selection;
                    int line = textSelection.CurrentLine;
                    int col = textSelection.CurrentColumn;
                    string file = VisualStudioInstance.ActiveDocument.Name;
                    string project = VisualStudioInstance.ActiveDocument.ProjectItem.ContainingProject.Name;

                    Review newReview = new Review()
                                           {
                                               ReviewId = _reviewRepo.GetNextReviewId(),
                                               Project = project,
                                               File = file,
                                               Line = line
                                           };
                    ReviewEditor.SetReview(newReview, true);
                    DialogResult result = ReviewEditor.ShowDialog(this);
                    if (result == DialogResult.OK)
                    {
                        ReviewEditor.UpdateReview(newReview);
                        _reviewRepo.Add(newReview);

                        RefreshReviewList();
                    }
                }
                else
                {
                    MessageBox.Show(SolutionNotOpen);
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of the tbtnSummary control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void tbtnSummary_Click(object sender, EventArgs e)
        {
            try
            {
                if (VisualStudioInstance.Solution.IsOpen)
                {
                    Summary.SetSummary(_reviewRepo.CodeReview);
                    DialogResult result = Summary.ShowDialog(this);
                    if (result == DialogResult.OK)
                    {
                        Summary.UpdateCodeReview(_reviewRepo.CodeReview);
                    }
                }
                else
                {
                    MessageBox.Show(SolutionNotOpen);
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of the tbtnSave control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void tbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (VisualStudioInstance.Solution.IsOpen)
                {
                    if (0 == _reviewRepo.GetCount())
                    {
                        return;
                    }

                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "html file (*.html)|*.html";
                    saveFileDialog1.FilterIndex = 2;
                    saveFileDialog1.RestoreDirectory = true;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        _fileLocation = saveFileDialog1.FileName;

                        XmlSerializer s = new XmlSerializer(typeof(CodeReview));
                        string tmpFile = Path.GetTempFileName();
                        TextWriter w = new StreamWriter(tmpFile);
                        _reviewRepo.AdjustReviewId();
                        s.Serialize(w, _reviewRepo.CodeReview);
                        w.Close();

                        //load the Xml doc                    
                        XPathDocument xPathDoc = new XPathDocument(tmpFile);
                        File.Delete(tmpFile);

                        XslCompiledTransform xslTrans = new XslCompiledTransform();

                        //load the Xsl 
                        xslTrans.Load(Utils.AssemblyPath + "\\" + Utils.AssemblyTitle + ".xsl");

                        //create the output stream
                        XmlTextWriter xmlWriter = new XmlTextWriter(_fileLocation, null);

                        //do the actual transform of Xml
                        xslTrans.Transform(xPathDoc, null, xmlWriter);

                        xmlWriter.Close();

                        string xml = Utils.GetSerializedXml(_reviewRepo.CodeReview);
                        
                        // save the xml data as well within the html
                        XmlDocument reviewHtml = new XmlDocument();
                        reviewHtml.Load(_fileLocation);
                        XmlNode dataNode = CodeReview.GetDataNode(reviewHtml);
                        dataNode.InnerXml = xml;
                        reviewHtml.Save(_fileLocation);

                        VisualStudioInstance.StatusBar.Text = "Review List saved at " + _fileLocation + " successfully";
                    }
                }
                else
                {
                    MessageBox.Show(SolutionNotOpen);
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ex);
            }
        }

        /// <summary>
        /// Handles the Click event of the tbtnOpen control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void tbtnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (VisualStudioInstance.Solution.IsOpen)
                {
                    OpenFileDialog fDialog = new OpenFileDialog();
                    fDialog.Title = "Open Review";
                    fDialog.Filter = "html file (*.html)|*.html";
                    //fDialog.InitialDirectory = @"C:\";
                    if (fDialog.ShowDialog() == DialogResult.OK)
                    {
                        _fileLocation = fDialog.FileName;

                        XmlDocument reviewHtml = new XmlDocument();
                        reviewHtml.Load(_fileLocation);
                        XmlNode dataNode = CodeReview.GetDataNode(reviewHtml);
                        if (dataNode == null)
                        {
                            MessageBox.Show("Please select a valid ReviewPal file.");
                        }
                        else
                        {
                            string xml = dataNode.InnerXml;
                            _reviewRepo.CodeReview = Utils.LoadFromXml<CodeReview>(xml);
                            _reviewRepo.AdjustReviewId();
                            RefreshReviewList();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(SolutionNotOpen);
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ex);
            }
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Handles the project item.
        /// </summary>
        /// <param name="projectItem">The project item.</param>
        /// <param name="review">The review.</param>
        private void HandleProjectItem(ProjectItem projectItem, Review review)
        {
            VisualStudioInstance.ItemOperations.OpenFile(projectItem.get_FileNames(0), Constants.vsViewKindPrimary);
            Document document = projectItem.Document;
            document.Activate();
            TextSelection textSelection = (TextSelection)VisualStudioInstance.ActiveDocument.Selection;
            textSelection.GotoLine(review.Line, false);
            textSelection.SetBookmark();
        }

        /// <summary>
        /// Refreshes the review list.
        /// </summary>
        private void RefreshReviewList()
        {
            _bindingSource = new BindingSource();
            _bindingSource.DataSource = _reviewRepo.CodeReview.Reviews;
            ReviewGrid.DataSource = _bindingSource;
            ReviewGrid.Visible = true;
        }

        #endregion
    }
}
