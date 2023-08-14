class Kisi
{
    public int SiraNo { get; private set; }

    //private static int sonSiraNo = 0; // aslında dışarıya kapalı olmalı
    public static int sonSiraNo = 0;

    public string Adi { get; set; }
    public string Soyadi { get; set; }

    public Kisi()
    {
        SiraNo = sonSiraNo++;
    }
    public void Hakkinda()
    {
        Console.WriteLine(SiraNo + " - " + Adi + " " + Soyadi);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kisi kisi1 = new Kisi { Adi = "Şeyma", Soyadi = "aaa" };
        Console.WriteLine("ssn=>" + Kisi.sonSiraNo);
        Kisi kisi2 = new Kisi { Adi = "Kübra", Soyadi = "aaa" };
        Kisi.sonSiraNo = 100;
        Kisi kisi3 = new Kisi { Adi = "Berat", Soyadi = "aaa" };
        Console.WriteLine("ssn=>" + Kisi.sonSiraNo);
        Kisi kisi4 = new Kisi { Adi = "İsmail", Soyadi = "aaa" };

        //kisi1.SiraNo = kisi2.SiraNo = 0;
        kisi1.Hakkinda();
        kisi2.Hakkinda();
        kisi3.Hakkinda();
        kisi4.Hakkinda();
        Console.WriteLine("------------------");

        Kisiler();
    }

    private static void Kisiler()
    {
        List<Kisi> list = new List<Kisi>();
        for (int i = 0; i < 10; i++)
        {
            list.Add(new Kisi { Adi = "aaa-" + i, Soyadi = "bbb" });
        }
        foreach (var item in list)
        {
            item.Hakkinda();
        }
    }
}
