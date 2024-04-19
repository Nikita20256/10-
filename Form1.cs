namespace _10_лаба
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string h1 = textBox1.Text;
            int h = Convert.ToInt32(h1);
            double t = Math.Sqrt((2*h)/10);
            textBox2.Text = t.ToString();
        }
    }
}