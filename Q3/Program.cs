using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string values = "asdfghjk12345" ;
            string result = Q2String.Left(values,5);
            string result2 = values.Left(10);
            string result3 = values.Left(20);


            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

        }
    }
    public static class Q2String
    {
        public static string Left(this string values, int lenght)
        {
            if (string.IsNullOrEmpty(values)) return string.Empty;
            if(lenght<= 0) return string.Empty;
            if(values.Length <= lenght) 
                return values;



            return values.Substring(0,lenght);
        }

    }
}
