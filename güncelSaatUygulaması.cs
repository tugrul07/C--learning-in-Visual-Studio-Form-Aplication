using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Güncel_saat_uygulaması
{
    public partial class Form1 : Form
    {

        int second;
        int minute ;
        int hour ;

        Label lblsecond = new Label();
        Label lblminute = new Label();
        Label lblhour = new Label();
        public Form1()
        {
            InitializeComponent();
            
            lblsecond.Font = new Font("Corbel", 24, FontStyle.Bold);
            lblsecond.Height = 50;
            lblsecond.Width = 80;
            lblsecond.Left = 300;
            lblsecond.Top = 200;
            lblsecond.Text = "0";

            this.Controls.Add(lblsecond);
            lblminute.Font = new Font("Corbel", 24, FontStyle.Bold);
            lblminute.Height = 50;
            lblminute.Width = 80;
            lblminute.Left = lblsecond.Left-50;
            lblminute.Top = lblsecond.Top;
            lblminute.Text = "0";

            this.Controls.Add(lblminute);
            lblhour.Font = new Font("Corbel", 24, FontStyle.Bold);
            lblhour.Height = 50;
            lblhour.Width = 80;
            lblhour.Left = lblminute.Left-50;
            lblhour.Top = lblminute.Top;
            lblhour.Text = "0";
            this.Controls.Add(lblhour);


        }

      
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            second++;
            lblsecond.Text = second.ToString();
            
            if (second == 60)
            {
                second = 0;
                minute++;
                lblminute.Text = minute.ToString();
                if (minute == 60)
                {
                    minute = 0;
                    hour++;
                    lblhour.Text = hour.ToString();
                    if (hour == 24)
                    {
                        hour = 0;
                       
                    }
                }
                

            }
            


        }
    }
}
