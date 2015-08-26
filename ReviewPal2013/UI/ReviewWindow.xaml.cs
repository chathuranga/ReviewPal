using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;
using System.Xml.Xsl;
using EnvDTE;
using EnvDTE80;
using ReviewPal.Core;
using DataGrid = System.Windows.Controls.DataGrid;
using MessageBox = System.Windows.MessageBox;
using UserControl = System.Windows.Controls.UserControl;
using Window = System.Windows.Window;

namespace ReviewPal.ReviewPal2012.UI
{
    /// <summary>
    /// Interaction logic for ReviewWindow.xaml
    /// </summary>
    public partial class ReviewWindow : UserControl
    {
        private static ReviewEditor ReviewEditor;
        private static Summary Summary;
        private readonly ReviewRepository _reviewRepo = new ReviewRepositoryInMemory();

        private string _fileLocation;

        private const string SolutionNotOpen = "Please open the solution in Visial Studio";
        private const string NoFileOpen = "Please open the file in the IDE to add review comment";

        public ReviewWindow()
        {
            InitializeComponent();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions")]
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(string.Format(System.Globalization.CultureInfo.CurrentUICulture, "We are inside {0}.button1_Click()", this.ToString()),
                            "ReviewWindow");

        }

        #region Event handlers

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (VSIDEHelper.VisualStudioInstance.Solution.IsOpen)
                {
                    OpenFileDialog fDialog = new OpenFileDialog();
                    fDialog.Title = "Open Review";
                    fDialog.Filter = "html file (*.html)|*.html";
                    //fDialog.InitialDirectory = @"C:\";
                    if (fDialog.ShowDialog() == DialogResult.OK)
                    {
                        _fileLocation = fDialog.FileName;
                        LoadDataFromReviewPalFile();
                        var solutionConfig = SolutionConfig.GetSolutionConfig();
                        if(solutionConfig == null)
                            solutionConfig = new SolutionConfig();
                        solutionConfig.ReviewPalFileLocation = _fileLocation;
                        solutionConfig.Save();
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

        private void LoadDataFromReviewPalFile()
        {
            XmlDocument reviewHtml = new XmlDocument();
            if (File.Exists(_fileLocation))
            {
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
            else
            {
                MessageBox.Show( string.Format("Previously saved ReviewPal file not found at \n {0}.",_fileLocation));
            }
        }

        /// <summary>
        /// Handles the Click event of the btnSave control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (VSIDEHelper.VisualStudioInstance.Solution.IsOpen)
                {
                    if (0 == _reviewRepo.GetCount())
                    {
                        return;
                    }

                    SolutionConfig solutionConfig = SolutionConfig.GetSolutionConfig();
                    if (solutionConfig == null)
                    {
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                        saveFileDialog1.Filter = "html file (*.html)|*.html";
                        saveFileDialog1.FilterIndex = 2;
                        saveFileDialog1.RestoreDirectory = true;
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            _fileLocation = saveFileDialog1.FileName;
                            // save user selected file location the solution config file
                            solutionConfig = new SolutionConfig { ReviewPalFileLocation = _fileLocation};
                            solutionConfig.Save();
                        }
                    }

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
                    xslTrans.Load(Utils.AssemblyPath + "\\" + "ReviewPal.xsl");

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

                    VSIDEHelper.VisualStudioInstance.StatusBar.Text = "Review List saved at " + _fileLocation + " successfully";
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
        /// Handles the Click event of the btnSummary control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void btnSummary_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (VSIDEHelper.VisualStudioInstance.Solution.IsOpen)
                {
                    Summary = new Summary() { Owner = Window.GetWindow(this) };
                    Summary.SetSummary(_reviewRepo.CodeReview);
                    Summary.ShowDialog();
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (VSIDEHelper.VisualStudioInstance.Solution.IsOpen)
                {
                    if (VSIDEHelper.VisualStudioInstance.ActiveDocument != null)
                    {
                        ReviewEditor = new ReviewEditor(_reviewRepo) { Owner = Window.GetWindow(this) };
                        ReviewEditor.SetReview(null);
                        ReviewEditor.ShowDialog();
                        RefreshReviewList();
                    }
                    else
                    {
                        MessageBox.Show(NoFileOpen);
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

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Review review = (Review)ReviewGrid.SelectedItem;
                if (review != null)
                {
                    ReviewEditor = new ReviewEditor(_reviewRepo) { Owner = Window.GetWindow(this) };
                    ReviewEditor.SetReview(review);
                    ReviewEditor.ShowDialog();
                    RefreshReviewList();
                }
                else
                {
                    MessageBox.Show("No current row to Edit", Utils.AssemblyTitle);
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ex);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Review review = (Review)ReviewGrid.SelectedItem;
                if (review != null)
                {
                    //TODO: Add a confirmation here.
                    //DialogResult result = MessageBox.Show("Are you sure to delete this item?", Utils.AssemblyTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //if (DialogResult.Yes == result)
                    //{
                        Review reviewToDelete = _reviewRepo.Get(review.ReviewId);
                        _reviewRepo.Delete(reviewToDelete);
                        RefreshReviewList();
                    //}
                }
                else
                {
                    MessageBox.Show("No current row to Delete", Utils.AssemblyTitle);
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ex);
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (0 == _reviewRepo.GetCount())
                {
                    return;
                }
                //TODO: Adda aconfirmation here.
                //DialogResult result = MessageBox.Show("Are you sure to clear all items?", Utils.AssemblyTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (DialogResult.Yes == result)
                //{
                    _reviewRepo.Clear();
                    RefreshReviewList();
                    var solutionConfig = SolutionConfig.GetSolutionConfig();
                    if (solutionConfig != null)
                    {
                        solutionConfig.Delete();
                    }
                //}
            }
            catch (Exception ex)
            {
                Utils.HandleException(ex);
            }
        }

        /// <summary>
        /// Handles the MouseDoubleClick event of the ReviewGrid control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Input.MouseButtonEventArgs"/> instance containing the event data.</param>
        private void ReviewGrid_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            try
            {
                Review review = (Review)((DataGrid)sender).SelectedItem;
                bool itemFound = false;
                foreach (Project project in VSIDEHelper.VisualStudioInstance.Solution.Projects)
                {
                    VSIDEHelper.ScanForProjectItems(project, review, HandleProjectItem, out itemFound);
                    if (itemFound)
                        return;
                }
                if (!itemFound)
                {
                    MessageBox.Show("Project item not found", Utils.AssemblyTitle);
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ex);
            }
        }

        #endregion

        /// <summary>
        /// Refreshes the review list.
        /// </summary>
        private void RefreshReviewList()
        {
            ReviewGrid.ItemsSource = _reviewRepo.CodeReview.Reviews;
            ReviewGrid.Items.Refresh();
            ReviewGrid.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Handles the project item.
        /// </summary>
        /// <param name="projectItem">The project item.</param>
        /// <param name="review">The review.</param>
        private void HandleProjectItem(ProjectItem projectItem, Review review)
        {
            VSIDEHelper.VisualStudioInstance.ItemOperations.OpenFile(projectItem.get_FileNames(0), Constants.vsViewKindPrimary);
            Document document = projectItem.Document;
            document.Activate();
            TextSelection textSelection = (TextSelection)VSIDEHelper.VisualStudioInstance.ActiveDocument.Selection;
            textSelection.GotoLine(review.Line, false);
            textSelection.SetBookmark();
        }
        
        public void LoadXmlData()
        {
            try
            {
                if (VSIDEHelper.VisualStudioInstance.Solution.IsOpen)
                {
                    var solutionConfig = SolutionConfig.GetSolutionConfig();

                    if (solutionConfig != null)
                    {
                        _fileLocation = (string)solutionConfig.ReviewPalFileLocation;
                        LoadDataFromReviewPalFile();
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ex);
            }
        }

        public void UnloadXmlData()
        {
            try
            {
                _reviewRepo.CodeReview.Reviews.Clear();
                ReviewGrid.ItemsSource = _reviewRepo.CodeReview.Reviews;
                ReviewGrid.Items.Refresh();
                ReviewGrid.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {
                Utils.HandleException(ex);
            }
        }
    }
}