using System;
using System.Collections.Generic;

namespace Homework8
{
    class Program
    {
        /// <summary>
        /// Метод для заполнения коллекции
        /// </summary>
        /// <param name="list">Коллекция, которую нужно заполнить</param>
        public static void Fill (List<int> list)
        {
            var rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                list.Add(rand.Next(0, 101));
            }
        }

        /// <summary>
        /// Метод для вывода коллекции в консоль
        /// </summary>
        /// <param name="list">Коллекция, которую нужно вывести</param>
        public static void Print (List<int> list)
        {
            for (int i = 0; i<list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
        }

        /// <summary>
        /// Метод для удаления чисел, которые больше 25, но меньше 50
        /// </summary>
        /// <param name="list">Коллекция из которой удаляем</param>
        public static void DeleteSome (List<int> list)
        {
            for (int i = 0; i <list.Count; i++)
            {
                if (25 < list[i] & list[i] < 50)
                {
                    list.Remove(list[i]);
                    i -= 1;
                }
            }
        }


        static void Main(string[] args)
        {
            try 
            {                
                List<int> list = new List<int>();
                Fill(list);


                Console.WriteLine("Коллекция чисел:");
                Print(list);
                Console.WriteLine("\nВсего элементов: " + list.Count);

                DeleteSome(list);

                Console.WriteLine("Коллекция после удаления чисел которые были больше 25, но меньше 50:");
                Print(list);
                Console.WriteLine("\nВсего элементов: " + list.Count);

            }
            
            catch (Exception ex)
            {
                Console.WriteLine("Возникла ошибка:" + ex.Message);
            }
        }
    }
}
