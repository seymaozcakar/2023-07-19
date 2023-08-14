class Program
{
    static void Main(string[] args)
    {
        string cumle = "Yeni Firma   Hayırlı,,,Uğurlu Olsun";
        Console.WriteLine(cumle);
        Console.WriteLine("------------------------------------");
        var kelimeler = cumle.Split(new char[] { ' ',','}, StringSplitOptions.RemoveEmptyEntries);

        foreach (var item in kelimeler)
        {
            Console.WriteLine(item);
        }

    }
}
