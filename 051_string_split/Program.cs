class Program
{
    static void Main(string[] args)
    {
        string cumle = "Mecidiyeköy   istanbul/Türkiye No:30/6";
        Console.WriteLine(cumle);
        Console.WriteLine("------------------------------------");
        var seperators = new char[] { ' ', ',', '!', ':', '/' };

        var kelimeler = cumle.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

        int ndx = 1;

        foreach (var item in kelimeler)
        {
            Console.WriteLine(ndx++ + "." + item);
        }
    }
}
