using System;

namespace LabGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вивід вітального повідомлення
            Console.WriteLine("Привіт! Це моя перша програма для практичної роботи з Git.");

            Console.WriteLine("Це оновлена версія програми з новим повідомленням!");

            // Проста взаємодія з користувачем
            Console.Write("Введіть своє ім'я: ");
            string name = Console.ReadLine();

            Console.WriteLine("Радий знайомству, " + name + "!");

            // Проста арифметична операція
            Console.Write("Введіть перше число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введіть друге число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = a + b;
            Console.WriteLine("Сума чисел = " + sum);

            // Завершення програми
            Console.WriteLine("Дякую за використання програми!");
        }
    }
}
