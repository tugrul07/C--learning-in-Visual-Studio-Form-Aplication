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
                richTextBox1.Text = "Cumhuriyet hangi y�lda kuruldu?";
                btn_a.Text = "1920";
                btn_b.Text = "1921";
                btn_c.Text = "1922";
                btn_d.Text = "1923";
                label4.Text = "1923";
               
            }
            if (soruno==2)
            {
                richTextBox1.Text = "Hangi ilimiz ege b�lgesinde de�ildir?";
                btn_a.Text = "mu�la";
                btn_b.Text = "diyarbak�r";
                btn_c.Text = "izmir";
                btn_d.Text = "ayd�n";
                label4.Text = "diyarbak�r";
            }
            if(soruno==3)
            {
                richTextBox1.Text = "Hangisi evcil hayvand�r?";
                btn_a.Text = "kedi";
                btn_b.Text = "z�rafa";
                btn_c.Text = "puma";
                btn_d.Text = "yarasa";
                label4.Text = "kedi";
                button5.Text = "Sonu�lar";
            }
            if (soruno == 4)
            {
                button5.Enabled = false;
                btn_a.Enabled = false;
                btn_b.Enabled = false;
                btn_c.Enabled = false;
                btn_d.Enabled = false;
                MessageBox.Show("Do�ru: " + dogru +"\n"+ "Yanl��: "+ yanlis);
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