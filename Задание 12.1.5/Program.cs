using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Задание_12._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> userList = new List<User>()
        {
            new User() { Login = "Patt", Name = "Иванов", IsPremium = true },
            new User() { Login = "Sqo", Name = "Орлова", IsPremium = false },
            new User() { Login = "Cristal", Name = "Орджоникидзе", IsPremium = false },
            new User() { Login = "Elf", Name = "Джуро", IsPremium = true },
            new User() { Login = "Bee", Name = "Симоньян", IsPremium = false },
            new User() { Login = "MiB", Name = "Лавров", IsPremium = false },
        };
            SomeAction(userList);

            Console.ReadKey();
        }
        static void SomeAction(List<User> usersList)
        {
            Ads ads = new ShowAds();
            foreach (User user in usersList)
            {
                if (user.IsPremium == false)
                {
                    Console.WriteLine($"Здравствуйте, тов. {user.Name}. Реклама для Вас:");
                    ads.ShowAds();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"\tДобро пожаловать, тов. {user.Name}");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\tОчень рады видеть Вас на сайте снова\"");
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
