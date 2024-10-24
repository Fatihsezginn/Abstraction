class Program
{
    static void Main(string[] args)
    {
        // Yazılım Geliştirici oluşturma
        YazilimGelistirici yazilimci = new YazilimGelistirici
        {
            Ad = "Hasan",
            Soyad = "Çıldırmış",
            Departman = "Yazılım"
        };

        // Proje Yöneticisi oluşturma
        ProjeYoneticisi projeYonetici = new ProjeYoneticisi
        {
            Ad = "Ayşe",
            Soyad = "Yıldız",
            Departman = "Proje"
        };

        // Satış Temsilcisi oluşturma
        SatisTemsilcisi satisTemsilcisi = new SatisTemsilcisi
        {
            Ad = "Mehmet",
            Soyad = "Kara",
            Departman = "Satış"
        };

        // Görevlerini çağırma
        yazilimci.Gorev();
        projeYonetici.Gorev();
        satisTemsilcisi.Gorev();
    }
}
