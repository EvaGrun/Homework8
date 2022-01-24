using System;
using System.Collections.Generic;

namespace Homework8._3
{
    class Program
    {
        /// <summary>
        /// Метод для повтора программы
        /// </summary>
        /// <returns>переменная отвечающая за то, потворять или нет</returns>
        static string Repeat()
        {
            Console.WriteLine("\nЕсли хотите продолжить - напишите \"да\", если заврешить программу - нажмите любую клавишу");
            string userChoice = Console.ReadLine();
            return userChoice;
        }

        static void Print(HashSet<int> db)
        {
            Console.WriteLine("Сейчас коллекция содержит следующие цифры: ");
            foreach (var x in db)
            {
                Console.Write(x + " ");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                string[] da = { "lf", "l", "да", "д", "дл", "lk" };
                string userChoice = "да";
                HashSet<int> db = new HashSet<int>();

                while (Array.Exists(da, element => element == userChoice.ToLower()))
                {
                    Console.WriteLine("\nВведите число: ");
                    int num = Int32.Parse(Console.ReadLine());

                    if (db.Contains(num)) { Console.WriteLine("Такое число в коллекции уже есть\n"); }
                    else { db.Add(num);}
                    Print(db);
                    userChoice =  Repeat();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
