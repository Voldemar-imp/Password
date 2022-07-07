using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "qwerty";
            string message = "Проще - не значит хуже.";
            string userInput;
            int tryCount = 3;

            for (int i = 1; i <= tryCount; i++)
            {
                Console.WriteLine("Введите пароль: ");
                userInput = Console.ReadLine();

                if (userInput == password)
                {
                    Console.WriteLine(message);
                    break;
                }
                else
                {
                    Console.WriteLine("Неверно введен пароль. У вас остаось {0} попыток", (tryCount - i));
                }
            }
        }
    }
}
