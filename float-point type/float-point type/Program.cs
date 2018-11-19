using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace float_point_type
{
    class Program
    {
        static void Main(string[] args)
        {
            float flmin = float.MinValue;
            float flmax = float.MaxValue;
            Console.WriteLine("\n The Float : \n min value = {0}\n max value = {1}", flmin, flmax);

            double dlmin = double.MinValue;
            double dlmax = double.MaxValue;
            Console.WriteLine("\n The Double : \n min value = {0}\n max value = {1}", dlmin, dlmax);

            decimal dcmin = decimal.MinValue;
            decimal dcmax = decimal.MaxValue;
            Console.WriteLine("\n The Decimal :\n min value = {0}\n max value = {1}", dcmin, dcmax);




            float flvar = 1F / 3;
            double dlvar = 1D / 3;
            decimal dcvar = 1M / 3;

            Console.WriteLine("\n float value = {0} \n double value = {1} \n decimal value = {2}", flvar, dlvar, dcvar);    
            

            Console.WriteLine("The Txet ( Char - String ):-");

            int charmin = char.MinValue;
            int charmax = char.MaxValue;

            char myvar = 'A';
            Console.WriteLine("\n Char min = {0}\n Char max = {1}\n My Character = {2}", charmin, charmax, myvar);

            Console.ReadKey();

        }
    }
}
