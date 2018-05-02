
using System.Windows.Forms;

namespace MyKPI.Common
{  
    public static class CommonFunctions
    {
        public static void ShowErrorDialog(string message)
        {
            MessageBox.Show(message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowQuestionDialog(string message, string title)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
