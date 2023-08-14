using Easyware.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        int[] sayilar = { 1, 2, };
        try
        {
            Console.WriteLine("işlem başlıyor");
            Console.WriteLine(sayilar[10]);
            Console.WriteLine("sayiyi gösterdik");
        }
        catch (Exception ex)
        {
            Console.WriteLine("hata var");
            Ekran.CizgiCiz();
            Console.WriteLine("MESSAGE\t\t= " + ex.Message);
            Console.WriteLine("STACKTRACE\t=" + ex.StackTrace);
            Console.WriteLine("SOURCE\t\t=" + ex.Source);
            Console.WriteLine("HELPLINK\t=" + ex.HelpLink);
        }
        finally
        {
            Console.WriteLine("bitti.");
        }
    }
}

