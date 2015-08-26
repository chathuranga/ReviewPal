using System.Windows.Controls;

namespace ReviewPal.ReviewPal2012.UI
{
    class UIHelper
    {
        /// <summary>
        /// Sets the review status. This needs to be replaced with a better WPF approach
        /// </summary>
        /// <param name="statusString">The status string.</param>
        public static void SelectByString(ComboBox control, string statusString)
        {
            for (int i = 0; i < control.Items.Count; i++)
            {
                ComboBoxItem item = control.Items[i] as ComboBoxItem;
                if (item.Content.Equals(statusString))
                {
                    item.IsSelected = true;
                    return;
                }
            }
        }
    }
}
