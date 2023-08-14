class Program
{
    static void Swap(ref int value1, ref int value2)
    {
        int tmp = value1;
        value1 = value2;
        value2 = tmp;
    }
    static void Main(string[] args)
    {
        int sayi1 = 10;
        int sayi2 = 20;
        int no1 = 1;
        int no2 = 2;
        int tmp = 0;

        Console.WriteLine("sayi1 = " + sayi1);
        Console.WriteLine("sayi2 = " + sayi2);
        Console.WriteLine("-----------------------------");

        Swap(ref sayi1, ref sayi2);

        Console.WriteLine("sayi1 = " + sayi1);
        Console.WriteLine("sayi2 = " + sayi2);
        Console.WriteLine(); Console.WriteLine();

        Console.WriteLine("no1 = " + no1);
        Console.WriteLine("no2 = " + no2);
        Console.WriteLine("-----------------------------");

        Swap(ref no1, ref no2);

        Console.WriteLine("no1 = " + no1);
        Console.WriteLine("no2 = " + no2);


    }
}
