using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Q1
         

            bool result = Q1.IsEven(60);
            bool result2 = Q1.IsOdd(45);

            Console.WriteLine(result);
            Console.WriteLine(result2); 
            
            //Func<int, bool> funcIsEvan = (n) => n % 2 == 0;
            //bool isEvan = funcIsEvan(70);

            //Console.WriteLine(isEvan);

            //bool isOdd = Predicate(75,n=> n % 2 == 1);

            //Console.WriteLine(isOdd);


        }
        //static bool Predicate(int num, Func<int, bool> func)
        //{
        //    return func(num);
        //}
    }
    public static class Q1
    {
        public static bool IsEven(this int soource)
        {
            return soource%2 == 0;
        }
        public static bool IsOdd(this int soource)
        {
            return soource % 2 != 0;
        }

    }

}
