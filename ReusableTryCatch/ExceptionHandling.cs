using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableTryCatch
{
    public class ExceptionHandling
    {
        public static void ReTry(Action<string, DateTime> repositoryMethod, string name, DateTime birthDate)
        {
            try
            {
                repositoryMethod(name, birthDate);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

        }
    }
}
