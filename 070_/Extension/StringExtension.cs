using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyware.Extensions
{
    public static class StringExtensions //stringextensions yazarken static class kullanıyoruz.
    {
        public static int WordCount(this string str)
        {
            //return str.Split(' ').Length;
            var words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}
