using System.Windows.Forms;

namespace MockupVisProg
{
    public class BaseChildForm : Form
    {
        protected string FormTitle { get; set; }

        public virtual void LoadData() { }

        protected void ShowStatus(string message)
        {
            MessageBox.Show(message, FormTitle ?? "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
