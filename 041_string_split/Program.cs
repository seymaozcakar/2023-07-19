using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string cumle = "Yeni Firma   Hayırlı,,,Uğurlu Olsun";
        Console.WriteLine(cumle);
        Console.WriteLine("------------------------------------");
        
        foreach (var kelime in cumle.Split(new char[] { ' ' }))
        {
            Console.WriteLine(kelime);
        }
        Console.WriteLine("------------------------------------");
        foreach (var kelime in cumle.Split(new char[] { ' ', ',' }))
        {
            Console.WriteLine(kelime);
        }
        Console.WriteLine("------------------------------------");

        var kelimeler = cumle.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var kelime in kelimeler)
        {
            Console.WriteLine(kelime);
        }

    }
}

