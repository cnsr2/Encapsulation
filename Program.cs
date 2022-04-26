class Program
{
    static void Main(string[] args)
    {
        Ogrenci ogrenci1 = new Ogrenci();
        ogrenci1.Isim = "Emre Can";
        ogrenci1.SoyIsım = "Sarı";
        ogrenci1.No = 760;
        ogrenci1.Sinif = 2;
        ogrenci1.OgrenciBilgileriniGetir();
        Ogrenci ogrenci2 = new Ogrenci("Derya","Deniz",234,4);
        ogrenci2.OgrenciBilgileriniGetir();
        Ogrenci ogrenci3 = new Ogrenci("Kaan","Berk",222,1);
        ogrenci3.OgrenciBilgileriniGetir();
        ogrenci3.Sinifatlat();
        ogrenci3.OgrenciBilgileriniGetir();
        ogrenci3.Sinifdusur();
        ogrenci3.Sinifdusur();
        ogrenci3.OgrenciBilgileriniGetir();
    }
}
class Ogrenci
{
    private string _isim;
    private string _soyisim;
    private int _no;
    private int _sinif;

    public string Isim {get => _isim; set => _isim = value; }
    public string SoyIsım {get => _soyisim; set => _soyisim = value; }
    public int No {get => _no; set => _no = value; }
    public int Sinif 
    {get => _sinif;
    set
    {
        if(value < 1)
        {
            Console.WriteLine("Sınıf 1 den Küçük Olamaz!");
        }
        else
            _sinif = value; 
        }
    }
    
    public Ogrenci()
    {}
    public Ogrenci(string _isim, string _soyisim, int _no, int _sinif)
    {
        Isim = _isim;
        SoyIsım = _soyisim;
        No = _no;
        Sinif = _sinif;
    }
    public void OgrenciBilgileriniGetir()
    {
        Console.WriteLine("**********Öğrenci Bilgileri********");
        Console.WriteLine("Öğrencinin Adı      : {0}",Isim);
        Console.WriteLine("Öğrencinin SoyAdı   : {0}",SoyIsım);
        Console.WriteLine("Öğrencinin Numarası : {0}", No);
        Console.WriteLine("Öğrencinin Sınıfı   : {0}",Sinif);
    }
    public void Sinifdusur()
    {
        Sinif = Sinif -1;
    }
    public void Sinifatlat()
    {
        Sinif = Sinif +1;
    }
}
    