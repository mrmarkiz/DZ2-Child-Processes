using System.Diagnostics;

namespace Task4Window
{
    public partial class Task4Form : Form
    {
        private Form _baseForm;
        public Task4Form()
        {
            InitializeComponent();
            _baseForm = null;
        }

        public Task4Form(Form baseForm)
        {
            InitializeComponent();
            _baseForm = baseForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                return;
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "text docs|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Process child = new Process();
                child.StartInfo = new ProcessStartInfo(@"D:\VisualStudio\ItStep\SystemProgramming\DZ2\Task4Child\bin\Debug\net6.0\Task4Child.exe", $"{openFileDialog.FileName} {textBox1.Text}");
                child.Start();
            }
        }

        private void Task4Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            _baseForm.Enabled = true;
            _baseForm.Show();
        }
    }
}