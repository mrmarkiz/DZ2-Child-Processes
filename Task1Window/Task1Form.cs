using System.Diagnostics;

namespace Task1Window
{
    public partial class Task1Form : Form
    {
        private Form _baseForm;

        public Task1Form()
        {
            InitializeComponent();
            _baseForm = null;
        }
        public Task1Form(Form baseForm)
        {
            InitializeComponent();
            _baseForm = baseForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process child = new Process();
            child.StartInfo = new ProcessStartInfo("cmd.exe");
            child.Start();
            child.WaitForExit();
            label1.Text = $"Exit code: {child.ExitCode}";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _baseForm.Enabled = true;
            _baseForm.Show();
        }
    }
}