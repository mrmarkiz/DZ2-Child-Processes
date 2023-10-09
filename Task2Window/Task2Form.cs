using System.Diagnostics;

namespace Task2Window
{
    public partial class Task2Form : Form
    {
        private Form _baseForm;
        private Process _child;
        public Task2Form()
        {
            InitializeComponent();
            _baseForm = null;
            comboBox1.SelectedIndex = 0;
        }

        public Task2Form(Form baseForm)
        {
            InitializeComponent();
            _baseForm = baseForm;
            comboBox1.SelectedIndex = 0;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            _child = new Process();
            _child.StartInfo = new ProcessStartInfo($"{comboBox1.SelectedItem.ToString()}.exe");
            _child.Start();
            if (radioButton1.Checked)
            {
                _child.WaitForExit(5000);
                _child.Kill();
            }
            else
            {
                _child.WaitForExit();
            }
            labelCode.Text = $"Exit code: {_child.ExitCode}";
        }

        private void Task2Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            _baseForm.Enabled = true;
            _baseForm.Show();
        }
    }
}