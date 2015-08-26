using EnvDTE;
using EnvDTE80;

namespace ReviewPal.Core
{

    /// <summary>
    ///  the following delegate is what must be changed for the
    ///  project you are working on
    /// </summary>
    public delegate void ProcessProjectItemScanResult(ProjectItem pi, Review review);

    /// <summary>
    ///  This class processes project items and when
    ///  a lowest level project item is found, it does
    ///  a call back to the caller thru invoking a delegate. 
    /// code contribution from to http://www.knowdotnet.com/articles/nestedprojectitems.html
    /// </summary>
    public class VSIDEHelper
    {
        public static DTE2 VisualStudioInstance;

        /// <summary>
        /// Scans for project items.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="review">The review.</param>
        /// <param name="processProjectItemScanResult">The PSR.</param>
        /// <param name="itemFound">if set to <c>true</c> [item found].</param>
        public static void ScanForProjectItems(Project project, Review review, ProcessProjectItemScanResult processProjectItemScanResult, out bool itemFound)
        {
            ProjectItems projItems;
            foreach (ProjectItem projItem in project.ProjectItems)
            {
                projItems = projItem.ProjectItems;
                if ((projItems != null
                     && (projItems.Count > 0)))
                {
                    bool found;
                    DrillDownInProjectItems(projItems, review, processProjectItemScanResult, out found);
                    if (found)
                    {
                        itemFound = true;
                        return;
                    }
                }
                else if (projItem.SubProject != null)
                {
                    //try to find the item from project under solutoin folders
                    projItems = projItem.SubProject.ProjectItems;
                    if ((projItems != null
                         && (projItems.Count > 0)))
                    {
                        bool found;
                        DrillDownInProjectItems(projItems, review, processProjectItemScanResult, out found);
                        if (found)
                        {
                            itemFound = true;
                            return;
                        }
                    }
                }
                else if (projItem.Name == review.File && projItem.ContainingProject.Name == review.Project)
                {
                    //  call back to the user function delegated to 
                    //  handle a single project item
                    processProjectItemScanResult.Invoke(projItem, review);
                    itemFound = true;
                    return;
                }
            }
            itemFound = false;
        }

        private static void DrillDownInProjectItems(ProjectItems projectItems, Review review, ProcessProjectItemScanResult psr, out bool found)
        {
            found = false;
            ProjectItems projItems;
            ProjectItem projectItem = projectItems.Parent as ProjectItem;
            //Check if the parent itself matches before searching for the parent's children. 
            if (projectItem.Name == review.File)
            {
                psr.Invoke(projectItem, review);
                found = true;
                return;
            }
            foreach (ProjectItem projItem in projectItems)
            {
                projItems = projItem.ProjectItems;
                if ((projItems != null
                     && (projItems.Count > 0)))
                {
                    //  recurse to get to the bottom of the tree
                    DrillDownInProjectItems(projItems, review, psr, out found);
                    if (found)
                    {
                        return;
                    }
                }
                else if (projItem.Name == review.File && projItem.ContainingProject.Name == review.Project)
                {
                    //  call back to the user function delegated to 
                    //  handle a single project item
                    psr.Invoke(projItem, review);
                    found = true;
                    return;
                }
            }
        }
    }
}