using Easyware.ConsoleApp;

interface IAnaSayfa
{
    string Baslik { get; }
}
interface IRehber
{
    string Tel { set; get; }
    string RehberAdi { get; }
}

class Kisi
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public virtual void Hakkinda()
    {
        Console.WriteLine(Adi + " " + Soyadi);
    }
}
class Ogrenci : Kisi, IAnaSayfa, IRehber
{
    public string Okul { get; set; }
    public override void Hakkinda()
    {
        base.Hakkinda();
    }
    public string Baslik => $"{Adi} {Soyadi} - {Okul}";
    public string RehberAdi => $"{Adi} {Soyadi}";
    public string Tel { get; set; }
}
class Ders : IAnaSayfa
{
    public string Adi { get; set; }
    public string Baslik
    {
        get
        {
            return "Ders : " + Adi;
        }
    }
}
class Departman : IRehber
{
    public string Adi { get; set; }
    public string Tel { get; set; }
    public string RehberAdi
    {
        get { return Adi; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<IAnaSayfa> AnaSayfaListesi = new List<IAnaSayfa>();
        AnaSayfaListesi.Add(new Ogrenci { Adi = "Arda", Soyadi = "aaa", Okul = "IÜ" });
        AnaSayfaListesi.Add(new Ogrenci { Adi = "Yavuz", Soyadi = "aaa", Okul = "Trakya" });
        AnaSayfaListesi.Add(new Ders { Adi = "OS" });
        AnaSayfaListesi.Add(new Ders { Adi = "Veri Yapıları" });
        foreach (var item in AnaSayfaListesi)
        {
            Console.WriteLine(item.Baslik);
        }
        Ekran.CizgiCiz();
        List<IRehber> TelefonDefteri = new List<IRehber>();
        TelefonDefteri.Add(new Ogrenci { Adi = "Özge", Tel = "123123" });
        TelefonDefteri.Add(new Ogrenci { Adi = "Berat", Tel = "123123" });
        TelefonDefteri.Add(new Departman { Adi = "Öğrenci işleri", Tel = "456456" });
        TelefonDefteri.Add(new Departman { Adi = "Rektörlük", Tel = "456456" });

        foreach (var item in TelefonDefteri)
        {
            Console.WriteLine(item.Tel + " - " + item.RehberAdi);
        }
    }
}
