# Taş Kağıt Makas Oyunu Unity Projesi

Bu proje dizini, "Taş Kağıt Makas" adlı Unity oyununun/uygulamasının kaynak kodlarını ve çalıştırılabilir Windows build sürümünü içermektedir.

## 📂 Dosya ve Klasör Yapısı

Proje, standart bir Unity klasör hiyerarşisine ek olarak derlenmiş oyun dosyalarını da barındırır:

* **`Assets/`**: Projeye ait tüm oyun içi kaynaklar (Sahneler, C# Scriptleri, 3D Modeller, Prefablar, Sesler vb.).
* **`Exe/`**: Projenin Windows platformu için alınmış derlenmiş (build) sürümü.
    * `rp.exe`: Oyunu veya uygulamayı başlatan ana çalıştırılabilir dosya.
    * `rp_Data/`: Derlenmiş oyun verilerini, sahneleri ve bağımlılıkları içeren klasör.
    * `UnityPlayer.dll`, `UnityCrashHandler64.exe` ve DirectX 12 (`D3D12`) kütüphaneleri gibi çalışma zamanı dosyaları.
* **`Logs/`**: Projenin çalışma ve hata kayıtları (loglar).
* **`Packages/`**: Unity Package Manager tarafından yönetilen proje bağımlılıkları.
* **`ProjectSettings/`**: Unity motoru tarafından kullanılan yapılandırma ve proje genel ayarları.
* **`UserSettings/`**: Editör içi kişisel çalışma alanı ayarları.
* **`*.csproj` / `.slnx`**: Visual Studio veya benzeri IDE'ler için C# proje çözüm (solution) dosyaları.

## 🚀 Başlangıç ve Kullanım

### 🎮 Uygulamayı Çalıştırmak (Build Sürümü)
Projeyi düzenlemeden, sadece son halini oynamak veya test etmek istiyorsanız Unity'ye ihtiyacınız yoktur:
1. `Exe/` klasörüne girin.
2. **`rp.exe`** dosyasına çift tıklayarak uygulamayı başlatın.

### 🛠️ Projeyi Geliştirmek (Unity Editör)
Projeyi Unity içinde açmak ve geliştirmeye devam etmek için:
1. Bilgisayarınızda **Unity Hub**'ı başlatın.
2. Sağ üstten **Open (Aç)** butonuna tıklayın ve bu dosyanın bulunduğu kök dizini  seçin.
3. Unity Hub, projenin hangi sürümle yapıldığını otomatik algılayacaktır. İlgili sürüm yüklü değilse indirip kurmanız istenebilir.
4. Proje açıldıktan sonra `Assets/` klasörü altındaki sahneleri (Scenes) bularak çalışmaya başlayabilirsiniz.

---
#Proje Yapımcısı:
Emirhan Yeni
---
