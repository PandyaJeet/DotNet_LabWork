namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
            if (checkBox1.Checked)
            {
                str += "Hobby 1 \n";
            }
            if (checkBox2.Checked)
            {
                str += "Hobby 2 \n";
            }
            if (checkBox3.Checked)
            {
                str += "Hobby 3 \n";
            }
            MessageBox.Show(str);
        }
    }
}
