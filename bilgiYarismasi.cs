namespace bilgi_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;
        

        private void button5_Click(object sender, EventArgs e)
        {
            
            soruno++;
            lbl_srno.Text = soruno.ToString();
            button5.Text = "sonraki";
            btn_a.Enabled = true;
            btn_b.Enabled = true;
            btn_c.Enabled = true;
            btn_d.Enabled = true;
            button5.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

           

            if (soruno==1)
            {
                richTextBox1.Text = "Cumhuriyet hangi yýlda kuruldu?";
                btn_a.Text = "1920";
                btn_b.Text = "1921";
                btn_c.Text = "1922";
                btn_d.Text = "1923";
                label4.Text = "1923";
               
            }
            if (soruno==2)
            {
                richTextBox1.Text = "Hangi ilimiz ege bölgesinde deðildir?";
                btn_a.Text = "muðla";
                btn_b.Text = "diyarbakýr";
                btn_c.Text = "izmir";
                btn_d.Text = "aydýn";
                label4.Text = "diyarbakýr";
            }
            if(soruno==3)
            {
                richTextBox1.Text = "Hangisi evcil hayvandýr?";
                btn_a.Text = "kedi";
                btn_b.Text = "zürafa";
                btn_c.Text = "puma";
                btn_d.Text = "yarasa";
                label4.Text = "kedi";
                button5.Text = "Sonuçlar";
            }
            if (soruno == 4)
            {
                button5.Enabled = false;
                btn_a.Enabled = false;
                btn_b.Enabled = false;
                btn_c.Enabled = false;
                btn_d.Enabled = false;
                MessageBox.Show("Doðru: " + dogru +"\n"+ "Yanlýþ: "+ yanlis);
            }
        }

        private void btn_b_Click(object sender, EventArgs e)
        {
            label5.Text = btn_b.Text;
            btn_a.Enabled = false;
            btn_b.Enabled = false;
            btn_c.Enabled = false;
            btn_d.Enabled = false;
            button5.Enabled = true;

            if (label4.Text == label5.Text)
            {
                dogru++;
                lbl_dgr.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lbl_ynls.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            label5.Text = btn_c.Text;
            btn_a.Enabled = false;
            btn_b.Enabled = false;
            btn_c.Enabled = false;
            btn_d.Enabled = false;
            button5.Enabled = true;

            if (label4.Text == label5.Text)
            {
                dogru++;
                lbl_dgr.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lbl_ynls.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btn_d_Click(object sender, EventArgs e)
        {
            label5.Text = btn_d.Text;
            btn_a.Enabled = false;
            btn_b.Enabled = false;
            btn_c.Enabled = false;
            btn_d.Enabled = false;
            button5.Enabled = true;

            if (label4.Text == label5.Text)
            {
                dogru++;
                lbl_dgr.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lbl_ynls.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btn_a_Click(object sender, EventArgs e)
        {
            label5.Text = btn_a.Text;
            btn_a.Enabled = false;
            btn_b.Enabled = false;
            btn_c.Enabled = false;
            btn_d.Enabled = false;
            button5.Enabled = true;

            if (label4.Text == label5.Text)
            {
                dogru++;
                lbl_dgr.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lbl_ynls.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
            
          
        }
    }
}