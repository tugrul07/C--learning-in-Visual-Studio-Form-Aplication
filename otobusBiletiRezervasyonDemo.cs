namespace otobüs_bileti_rezervasyon_otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            

              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1.adım: combobox2 nin textini label 6 nın textine ata.
            label6.Text = comboBox2.Text;
            // 2.adım: combobox1 in textini combobox2 nin textine ata.
            comboBox2.Text = comboBox1.Text;          
            // 3.adım: label 6 nın textini combobox1 e ata.
            comboBox1.Text = label6.Text;
            // 1.ve 2. adımın yerleri önemli, adım sırası değişirse iki comboboxa da aynı deger atar
            // Atamaların sıralaması  bu şekildedir. 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşleminiz Başarıyla Gerçekleştirilmiştir!");
        }
    }
}