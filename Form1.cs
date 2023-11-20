namespace Practica_9._2__unidad_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ulong numero = ulong.Parse(textBox1.Text);
            ulong factorial = 1;
            for (ulong i = 1; i<= numero; i++)
            {
                listBox1.Items.Add(i);
                factorial = factorial * i;
            }
            textBox2.Text = numero.ToString();
            textBox3.Text = factorial.ToString();
        }
    }
}