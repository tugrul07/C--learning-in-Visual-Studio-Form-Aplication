namespace Sinema_Büfe_Satış_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        // kasa tutarı değişkenini globalde tanımlarsak sürekli elde edilen sonucu uzerine ekliyor
        // ama tanımlamaz button 1 ın clıck olayında tanımlarsak sürekli kendını tekrar edıyor.
        // (kasa tutarını 0 dan başlat) anlamına gelir.Sayaç olarak düşünebiliriz.
        int kasatutari = 0;
        private void button1_Click(object sender, EventArgs e)
        {// ilk adım değişkenleri tanımla
            int misir, kola, su, kahve, toplam;
            // 2. adım değişkenler strıng type ta oldugu ıcın ıntegera cevir

            misir = Convert.ToInt32(TxtMisir.Text);
            kola = Convert.ToInt32(TxtKola.Text);
            su = Convert.ToInt32(TxtSu.Text);
            kahve = Convert.ToInt32(TxtKahve.Text);
            //3. adım işlemi yaptır
            toplam = misir * 30 + kola * 10 + su * 4 + kahve * 7;
            //4. adım yaptıgın işlemleri uygulamada göstermek istediğin labela ata. 
            LblToplam.Text = toplam.ToString() + " TL";
            //0 ile başlayan kasa tutarına,  her defasında yeni kasatutarına yeni toplamı ekle
            kasatutari = kasatutari + toplam;

            LblKasa.Text = kasatutari.ToString() + " TL"; 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {// 1.adım text box takı textlere boşluk ataması yap

            TxtKahve.Text = "";
            TxtKola.Text = "";
            TxtMisir.Text = "";
            TxtSu.Text = "";
            LblToplam.Text = "";
            //2.adım focus methodunu yaz, bitir.
            TxtMisir.Focus();
        }

     
    }
}