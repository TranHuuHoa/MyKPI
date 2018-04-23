
using System.Windows.Forms;

namespace MyKPI.Common
{  
    public static class CommonFunctions
    {
        public static void ShowErrorDialog(string message)
        {
            MessageBox.Show(message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
