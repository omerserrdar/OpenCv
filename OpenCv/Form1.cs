using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

// Projenizin adı ne olursa olsun, bu kod çalışacaktır.
namespace YeniSansurProjesi // (Burası sizde "WindowsFormsApp1" vb. olabilir, sorun değil)
{
    public partial class Form1 : Form
    {
        private CascadeClassifier _faceCascade;
        private Image<Bgr, byte> _originalImage;

        public Form1()
        {
            InitializeComponent(); // Burası Tasarım ekranını (Adım 4) koda bağlar
            try
            {
                // Burası Model dosyasını (Adım 3) yükler
                _faceCascade = new CascadeClassifier("haarcascade_frontalface_default.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: 'haarcascade_frontalface_default.xml' dosyası 'bin/Debug' klasöründe bulunamadı.\n" + ex.Message);
            }
        }

        // "Resim Aç" butonu için kod
        private void btnResimAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları (*.jpg; *.png; *.bmp)|*.jpg; *.png; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _originalImage = new Image<Bgr, byte>(ofd.FileName);
                    pictureBox1.Image = _originalImage.ToBitmap();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Resim yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }

        // "Yüzleri Sansürle" butonu için kod
        private void btnSansurle_Click(object sender, EventArgs e)
        {
            if (_originalImage == null)
            {
                MessageBox.Show("Lütfen önce bir resim açın!");
                return;
            }
            try
            {
                Image<Bgr, byte> censoredImage = _originalImage.Clone();
                Image<Gray, byte> grayImage = censoredImage.Convert<Gray, byte>();

                Rectangle[] faces = _faceCascade.DetectMultiScale(grayImage, 1.1, 5, new Size(20, 20));

                if (faces.Length == 0)
                {
                    MessageBox.Show("Resimde hiç yüz bulunamadı.");
                    return;
                }
                foreach (Rectangle face in faces)
                {
                    ApplyMosaic(censoredImage, face, 15); // 15: Mozaik boyutu
                }
                pictureBox1.Image = censoredImage.ToBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sansürleme sırasında hata: " + ex.Message);
            }
        }

        // Mozaikleme fonksiyonu
        private void ApplyMosaic(Image<Bgr, byte> image, Rectangle area, int pixelSize)
        {
            if (pixelSize <= 0) pixelSize = 1;
            if (area.Width <= 0 || area.Height <= 0) return;
            Image<Bgr, byte> faceArea = image.GetSubRect(area);
            Size smallSize = new Size(faceArea.Width / pixelSize, faceArea.Height / pixelSize);
            if (smallSize.Width == 0) smallSize.Width = 1;
            if (smallSize.Height == 0) smallSize.Height = 1;
            Image<Bgr, byte> smallFace = new Image<Bgr, byte>(smallSize);
            CvInvoke.Resize(faceArea, smallFace, smallSize, 0, 0, Inter.Nearest);
            CvInvoke.Resize(smallFace, faceArea, area.Size, 0, 0, Inter.Nearest);
        }

        private void btnResimAc_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSansurle_Click_1(object sender, EventArgs e)
        {

        }
    }
}