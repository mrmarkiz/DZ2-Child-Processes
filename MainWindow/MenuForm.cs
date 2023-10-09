using Task1Window;
using Task2Window;
using Task3Window;
using Task4Window;

namespace MainWindow
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void buttonTask_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            Form newForm = null;
            switch (clicked.Tag.ToString())
            {
                case "1":
                    newForm = new Task1Form(this);
                    break;
                case "2":
                    newForm = new Task2Form(this);
                    break;
                case "3":
                    newForm = new Task3Form(this);
                    break;
                case "4":
                    newForm = new Task4Form(this);
                    break;
            }
            if (newForm != null)
            {
                this.Enabled = false;
                this.Hide();
                newForm.Show();
            }
        }
    }
}