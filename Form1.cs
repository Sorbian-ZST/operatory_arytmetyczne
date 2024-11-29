namespace operatory_arytmetyczne
{
    public partial class Form1 : Form
    {
        private int a = 0, b = 0, wynik = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            wynik = a + b;
            label1.Text = "Wynik dodawania: " + wynik.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            wynik = a / b;
            label1.Text = "Wynik dzielenia: " + wynik.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            wynik = a * b;
            label1.Text = "Wynik mno¿enia: " + wynik.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            wynik = a - b;
            label1.Text = "Wynik odejmowania: " + wynik.ToString();
        }
    }
}
