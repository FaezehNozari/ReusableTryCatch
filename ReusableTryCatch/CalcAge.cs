using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableTryCatch
{
    public class CalculateAge
    {
        public static void CalcAge(string name, DateTime birthYear)
        {
            int age;
            UserRepository userRepository = new UserRepository
            {
                Name = name,
                BirthYear = birthYear
            };

            if (birthYear.Year == DateTime.Now.Year)
                Console.WriteLine("Year is Incorrect!");
            else
            {
                age = DateTime.Now.Year - birthYear.Year;
                Console.WriteLine($"age is: {age}");
            }
        }
    }
}
