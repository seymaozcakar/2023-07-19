class Kisi
{
    public int SiraNo { get; set; }
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public void Hakkinda()
    {
        Console.WriteLine(Adi+" "+Soyadi);
    }

}
class Matematik
{
    public static double PI = 3.14;
    public static int Karesi(int sayi)
    {
        return sayi * sayi;
    }

}

class Program
{

    static void Main(string[] args)
    {
        Kisi kisi1 = new Kisi() { Adi = "aaaa", Soyadi = "bbbb" };
        Kisi kisi2 = new Kisi() { Adi = "cccc", Soyadi = "ddd" };
        kisi1.Hakkinda();
        kisi2.Hakkinda();

        Matematik.Karesi(5);
        Console.WriteLine(2.5*Matematik.PI);
        
    }
}
