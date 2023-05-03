namespace Okey_Hesaplama_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int atoplam, btoplam;
            int a1 = Convert.ToInt32(textBox1.Text);
            int a2 = Convert.ToInt32(textBox3.Text);
            int a3 = Convert.ToInt32(textBox7.Text);
            int a4 = Convert.ToInt32(textBox8.Text);
            int a5 = Convert.ToInt32(textBox9.Text);
            int a6 = Convert.ToInt32(textBox10.Text);
            int a7 = Convert.ToInt32(textBox11.Text);
            int a8 = Convert.ToInt32(textBox12.Text);
            int a9 = Convert.ToInt32(textBox14.Text);
            int a10 = Convert.ToInt32(textBox13.Text);
            int a11 = Convert.ToInt32(textBox17.Text);

            atoplam = a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11;

            int b1 = Convert.ToInt32(textBox22.Text);
            int b2 = Convert.ToInt32(textBox21.Text);
            int b3 = Convert.ToInt32(textBox20.Text);
            int b4 = Convert.ToInt32(textBox19.Text);
            int b5 = Convert.ToInt32(textBox18.Text);
            int b6 = Convert.ToInt32(textBox16.Text);
            int b7 = Convert.ToInt32(textBox15.Text);
            int b8 = Convert.ToInt32(textBox6.Text);
            int b9 = Convert.ToInt32(textBox4.Text);
            int b10 = Convert.ToInt32(textBox5.Text);
            int b11 = Convert.ToInt32(textBox2.Text);

            btoplam = b1 + b2 + b3 + b4 + b5 + b6 + b7 + b8 + b9 + b10 + b11;

            //listBox1.Items.Add("A Takımı: " + atoplam +"\n"+ "B Takımı: " + btoplam);
            comboBox1.Items.Add("A Takımı: " + atoplam);
            comboBox1.Items.Add("B Takımı: " + btoplam);
            if (atoplam < btoplam) 
            MessageBox.Show(" TEBRİKLER!!" + "\n" + " OYUNU KAZANAN: A TAKIMI " + "\n" + " OYUNU KAYBEDEN: B TAKIMI");
            else
                MessageBox.Show(" TEBRİKLER!!" + "\n" + " OYUNU KAZANAN: B TAKIMI " + "\n" + " OYUNU KAYBEDEN: A TAKIMI");
        }
    }
}