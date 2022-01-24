using System;
using System.Xml.Linq;

namespace Homework8._4
{

    class Program

    {   /// <summary>
        /// Метод для повторного ввода пользователя
        /// </summary>
        /// <returns>переменная отвечающая за то, потворять или нет</returns>
        static string Repeat()
        {
            Console.WriteLine("\nЕсли хотите продолжить - напишите \"да\", если заврешить программу - нажмите любую клавишу");
            string userChoice = Console.ReadLine();
            return userChoice;
        }

        /// <summary>
        /// Метод для заполнения контакта
        /// </summary>
        /// <returns>заполненный контакт</returns>
        public static XElement fillInfo()
        {
            XElement person = new XElement("Person");
            Console.WriteLine("ФИО контакта: ");
            string fio = Console.ReadLine();
            XAttribute name = new XAttribute("name", fio);

            Console.WriteLine("Улица: ");
            string street = Console.ReadLine();
            XElement address = new XElement("Address");
            XElement streetX = new XElement("Street", street);

            Console.WriteLine("Номер дома: ");
            string houseNumber = Console.ReadLine();
            XElement houseNumberX = new XElement("HouseNumber", houseNumber);

            Console.WriteLine("Номер квартиры: ");
            string flatNumber = Console.ReadLine();
            XElement flatNumberX = new XElement("FlatNumber", flatNumber);

            address.Add(streetX);
            address.Add(houseNumberX);
            address.Add(flatNumberX);

            XElement phones = new XElement("Phones");

            Console.WriteLine("Номер сотового телефона: ");
            string mobilePhone = Console.ReadLine();
            XElement mobilePhoneX = new XElement("MobilePhone", mobilePhone);

            Console.WriteLine("Номер домашнего телефона: ");
            string flatPhone = Console.ReadLine();

            XElement flatPhoneX = new XElement("FlatPhone", flatPhone);

            phones.Add(mobilePhoneX);
            phones.Add(flatPhoneX);

            person.Add(name);
            person.Add(address);
            person.Add(phones);
            return person;
        }

        static void Main(string[] args)
        {
            string[] da = { "lf", "l", "да", "д", "дл", "lk" };
            string userChoice = "да";

            try
            {
                XElement persons = new XElement("Persons");

                while (Array.Exists(da, element => element == userChoice.ToLower()))
                {   
                    XElement person = fillInfo();
                    persons.Add(person);
                    userChoice = Repeat();
                }               

                persons.Save("_persons.xml");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
