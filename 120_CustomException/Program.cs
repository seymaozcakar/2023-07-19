using Easyware.ConsoleApp;

class PlakaYoneticisi
{
    public void PlakaEkle(int plakaNo, string sehir)
    {
        if (sehir == "")
        {
            throw new Exception("Plaka Eklerken şehir boş geçilemez");
        }

        Console.WriteLine(plakaNo + " - " + sehir);
    }
}

class Program
{
    static void Main(string[] args)
    {
        PlakaYoneticisi plakaYoneticisi = new PlakaYoneticisi();
        Console.WriteLine("--Plaka Ekleme işlemi başladı");
        try
        {
            plakaYoneticisi.PlakaEkle(34, "");
        }
        catch (Exception e)
        {
            Console.WriteLine("plaka eklenemedi");
            Ekran.CizgiCiz();
            Console.WriteLine("MSG==" + e.Message);
        }
        finally
        {
            Console.WriteLine("--Plaka Ekleme işlemi Tamamlandı.....");
        }

    }
}
