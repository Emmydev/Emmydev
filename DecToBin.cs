using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecToBin
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please input Integer Value");
                int dec = int.Parse(Console.ReadLine());
                string number = Convert.ToString(dec, 2);
                Console.WriteLine("Binary: "+number);
                Console.Read();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
