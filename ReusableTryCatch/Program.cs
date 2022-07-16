using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableTryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var birthDate = new DateTime(2002, 07, 14);
            var name = "Faezeh";

            ExceptionHandling.ReTry((s, d) => CalculateAge.CalcAge(s, d), name, birthDate);

            Console.ReadKey();

        }
    }
}
