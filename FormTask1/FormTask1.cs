using System.Diagnostics;

namespace Task1Window
{
    public partial class FormTask1 : Form
    {
        public FormTask1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process child = new Process();
            child.StartInfo = new ProcessStartInfo("calc.exe");
            child.WaitForExit();
            MessageBox.Show($"Exit code: {child.ExitCode}", "Exit info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}