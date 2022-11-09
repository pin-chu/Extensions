using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> items = new List<string> { "45","gf","56","4","","2","59","99"," "};
           
            
            foreach(var item in items)
            {
                Console.WriteLine(item);
            }

        }
    }
    public static class stringExtensions
    {
        public static int ToInt(this string source,int defaulValue)
        {
            bool isInt =int.TryParse(source, out int num);
            return isInt ? num : defaulValue;
        }
        

    }

}
