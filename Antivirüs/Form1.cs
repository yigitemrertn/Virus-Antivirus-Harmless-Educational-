using System.Diagnostics;

namespace Antivirüs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string hedefVirusAdi = "Virus"; // Örnek virüs adı

        private void VirusTemizle()
        {
            // Bilgisayardaki o isimdeki tüm süreçleri bul
            Process[] virusler = Process.GetProcessesByName(hedefVirusAdi);

            if (virusler.Length > 0)
            {
                foreach (var virus in virusler)
                {
                    try
                    {
                        // ACIMASIZ KOMUT: KILL
                        // Bu komut FormClosing eventini tetiklemez, direkt process'i RAM'den siler.
                        // Dolayısıyla virüs çoğalamadan yok olur.
                        virus.Kill();

                        lblDurum.Text = "TEHDİT ALGILANDI VE SİLİNDİ!";
                        lblDurum.ForeColor = Color.Red;

                        // Kullanıcıya bilgi verelim
                        MessageBox.Show("Zararlı yazılım (" + hedefVirusAdi + ") tespit edildi ve sonlandırıldı.",
                                        "Antivirüs Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Bazen erişim hatası olabilir, program patlamasın
                    }
                }
            }
            else
            {
                // Eğer virüs yoksa durumu normale döndür
                lblDurum.Text = "Sistem Taranıyor... Temiz.";
                lblDurum.ForeColor = Color.Blue;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDurum.Text = "Sistem Güvenli. Taramak için butona bas.";
            lblDurum.ForeColor = Color.Green;
        }

        private void btnTara_Click(object sender, EventArgs e)
        {
            VirusTemizle();
            tmrKoruma.Start();
            btnTara.Text = "Gerçek Zamanlı Koruma Aktif";
            btnTara.Enabled = false; // Sürekli basmasın diye pasife çektim
        }

        private void tmrKoruma_Tick(object sender, EventArgs e)
        {
            VirusTemizle();
        }
    }
}
