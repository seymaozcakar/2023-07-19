enum Gunler
{
    pazartesi,
    sali,
    carsamba,
    persembe,
    cuma
}
enum Mevsim  //genel olarak çoğul kullanılmaz.
{
    ilkbahar = 10,
    yaz = 11,
    sonbahar = 12,
    kıs = 13
}

class Program
{
    static void Main(string[] args)
    {
        Gunler gun = Gunler.cuma;

        if (gun == Gunler.cuma)
        {
            Console.WriteLine("Bu gün = " + gun);
        }

        Mevsim mevsim = Mevsim.ilkbahar;
        switch (mevsim)
        {
            case Mevsim.ilkbahar:
                Console.WriteLine("İlkbahar Geldi");
                break;
            case Mevsim.yaz:
                break;
            case Mevsim.sonbahar:
                break;
            case Mevsim.kıs:
                break;
            default:
                break;
        }

        Console.WriteLine($"Adi={mevsim}, Değeri = {(int)mevsim}");

    }
}
