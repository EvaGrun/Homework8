using System;
using System.Collections.Generic;

namespace Homework8._2
{
    class Program
    {

        /// <summary>
        /// Метод для вывода имени владельца по номеру телефона
        /// </summary>
        /// <param name="phoneBook">коллекция в которой идет поиск владельца</param>
        /// <param name="key">телефон по которому идет поиск</param>
        static void ShowInfo(Dictionary<string, string> phoneBook, string key)
        {
            string value = "";
            if (phoneBook.TryGetValue(key, out value))
            {
                Console.WriteLine("Хозяин номера " + key + " - " + value);
            }
            else
            {
                Console.WriteLine("Хозяин этого номера в базе не найден");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Dictionary<string, string> phoneBook = new Dictionary<string, string>();

                string phoneNum;
                string name;

                for (; ; )
                {
                    Console.WriteLine("Введите номер телефона");
                    phoneNum = Console.ReadLine();
                    if (phoneNum == "") break;

                    Console.WriteLine("Введите имя человека, которому этот номер принадлежит");
                    name = Console.ReadLine();
                    if (name == "") break;

                    phoneBook.Add(phoneNum, name);
                }


                Console.WriteLine("Введите номер, владельца которого надо найти");
                string key = Console.ReadLine();
                
                ShowInfo(phoneBook, key);


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fatal error: {ex.Message}");
            }
        }
    }
}
