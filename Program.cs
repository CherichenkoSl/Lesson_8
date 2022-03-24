using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Properties.Settings.Default.Greeting);
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                Console.WriteLine("Введите имя:");
                Properties.Settings.Default.UserName=Console.ReadLine();
                Console.WriteLine("Введите ваш возраст:");
                Properties.Settings.Default.Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите ваш род деятельности:");
                Properties.Settings.Default.Occupation = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            else
            {
                Console.WriteLine(Properties.Settings.Default.UserName);
                Console.WriteLine(Properties.Settings.Default.Age);
                Console.WriteLine(Properties.Settings.Default.Occupation);
            }
            Console.ReadKey();
        }
    }
}
