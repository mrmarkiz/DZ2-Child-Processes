using System.Diagnostics;

namespace Task3Window
{
    public partial class Task3Form : Form
    {
        private Form _baseForm;
        public Task3Form()
        {
            InitializeComponent();
            _baseForm = null;
        }

        public Task3Form(Form baseForm)
        {
            InitializeComponent();
            _baseForm = baseForm;
            comboBox1.SelectedIndex = 0;
            numericUpDown1.Minimum = int.MinValue;
            numericUpDown1.Maximum = int.MaxValue;
            numericUpDown2.Minimum = int.MinValue;
            numericUpDown2.Maximum = int.MaxValue;
        }

        private void Task3Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            _baseForm.Enabled = true;
            _baseForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process child = new Process();
            child.StartInfo = new ProcessStartInfo(@"D:\VisualStudio\ItStep\SystemProgramming\DZ2\Task3Child\bin\Debug\net6.0\Task3Child.exe", $"{numericUpDown1.Value} {numericUpDown2.Value} {comboBox1.SelectedItem.ToString()}");
            child.Start();
        }
    }
}