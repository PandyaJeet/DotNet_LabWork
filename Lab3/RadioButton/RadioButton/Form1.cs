using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str ="";
            if (radioButton1.Checked)
            {
                str += "Male \n";
            }
            else
            {
                str += "Female\n";
            }
            MessageBox.Show(str);
        }
    }
}
