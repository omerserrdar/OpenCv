C# ile OpenCV Yüz Sansürleme Uygulaması
Bu proje, C# Windows Forms (.NET Framework 4.8) kullanarak Emgu.CV (OpenCV) kütüphanesi aracılığıyla bir resimdeki insan yüzlerini tespit eden ve bu yüzlere mozaik (pikselleme) efekti uygulayarak sansürleyen basit bir masaüstü uygulamasıdır.

Bu rehber, özellikle .NET Framework 4.8 ile Emgu.CV uyumluluğu konusunda yaşanan zorlukları aşmak için hazırlanmıştır.

📸 Uygulamanın Özellikleri
Kullanıcının bilgisayarından .jpg, .png gibi resim dosyalarını açması.

Resim üzerindeki tüm insan yüzlerini tespit etme.

Tespit edilen her yüz bölgesine mozaik (pikselleme) efekti uygulama.

Sonucu arayüzde gösterme.

🛠️ Kullanılan Teknolojiler
C# (.NET Framework 4.8)

Windows Forms (WinForms)

Emgu.CV (Sürüm 3.4.3.3016) - OpenCV kütüphanesinin .NET için uyumlu eski sürümü.

OpenCV Haar Cascade - Yüz tespiti için önceden eğitilmiş model (haarcascade_frontalface_default.xml).

🚀 Kurulum ve Çalıştırma Adımları
Bu projeyi sıfırdan kurmak veya mevcut bir projeyi düzeltmek için bu adımları sırasıyla ve dikkatlice takip edin.

1. Adım: Projeyi Hazırlama
Visual Studio'yu açın.

Yeni bir "Windows Forms App (.NET Framework)" projesi oluşturun.

Framework sürümü olarak .NET Framework 4.8 (veya 4.7.2) seçtiğinizden emin olun.

2. Adım: Emgu.CV NuGet Paketlerini Yükleme (ÇOK ÖNEMLİ)
.NET Framework 4.8, Emgu.CV'nin en yeni sürümleriyle (v4.x, v5.x) uyumlu DEĞİLDİR. Projenin çalışması için doğru (eski) sürümü yüklemeniz şarttır.

Visual Studio'da üst menüden Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution... gidin.

Browse (Gözat) sekmesine tıklayın.

Arama kutusuna Emgu.CV yazın.

Çıkan Emgu.CV paketini seçin.

Sağ taraftaki Version (Sürüm) açılır listesinden 3.4.3.3016 (veya 3.4.3.2994) sürümünü bulun ve seçin.

Install (Yükle) butonuna basın.

ÖNEMLİ NOT: Emgu.CV.runtime.windows paketini ayrıca aramanıza veya yüklemenize gerek yoktur. Emgu.CV (v3.4.3) paketi, ihtiyaç duyduğu doğru runtime sürümünü otomatik olarak (bağımlılık olarak) kendisi kuracaktır.

3. Adım: Yüz Tespiti Modelini Ekleme (.xml Dosyası)
OpenCV'nin yüzleri bulabilmesi için bir model dosyasına ihtiyacı vardır.

haarcascade_frontalface_default.xml (İndirme Linki)

Bu linke sağ tıklayın ve "Bağlantıyı farklı kaydet..." seçeneğini seçin.

Bu .xml dosyasını, projenizin bin/Debug klasörünün içine kaydedin.

Klasörü Bulmak İçin: Visual Studio'da sağdaki "Solution Explorer" penceresinde projenizin adına sağ tıklayın -> Open Folder in File Explorer -> açılan klasörden bin -> Debug klasörüne girin.
