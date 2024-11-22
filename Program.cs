using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook;

    class PhoneBook
    {
        static List<Contact> phoneBook = new List<Contact>();

        static void Main(string[] args)
        {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        while (true)
            {
                Console.WriteLine("\nТелефонная книга:");
                Console.WriteLine("1. Добавить контакт");
                Console.WriteLine("2. Удалить контакт");
                Console.WriteLine("3. Обновить контакт");
                Console.WriteLine("4. Поиск по телефону");
                Console.WriteLine("5. Посмотреть телефонную книгу");
                Console.WriteLine("6. Выход");
                Console.Write("Выберите действие: ");

                string yourAction = Console.ReadLine();

                switch (yourAction)
                {
                    case "1":
                        AddContact();
                        break;
                    case "2":
                        DeleteContact();
                        break;
                    case "3":
                        UpdateContact();
                        break;
                    case "4":
                        SearchContact();
                        break;
                    case "5":
                        DisplayPhoneBook();
                        break;
                    case "6":
                        Console.WriteLine("Выход из приложения.");
                        return;
                    default:
                        Console.WriteLine("Что-то пошло не так" +
                            ". Попробуйте снова.");
                        break;
                }
            }
        }

        static void AddContact()
        {
            Console.Write("Введите имя: ");
            string firstName = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string lastName = Console.ReadLine();
            Console.Write("Введите номер телефона: ");
            string phoneNumber = Console.ReadLine();

            phoneBook.Add(new Contact(firstName, lastName, phoneNumber));
            Console.WriteLine("Контакт добавлен.");
        }

        static void DeleteContact()
        {
            Console.Write("Введите номер телефона для удаления: ");
            string phoneNumber = Console.ReadLine();

            Contact contact = phoneBook.Find(c => c.PhoneNumber == phoneNumber);
            //Contact contact = phoneBook.phoneNumber.Contains(phoneNumber) ;   
            if (contact != null)
            {
                phoneBook.Remove(contact);
                Console.WriteLine("Контакт удален.");
            }
            else
            {
                Console.WriteLine("Контакт не найден.");
            }
        }

        static void UpdateContact()
        {
            Console.Write("Введите номер телефона для обновления: ");
            string phoneNumber = Console.ReadLine();

            Contact contact = phoneBook.Find(c => c.PhoneNumber == phoneNumber);
            if (contact != null)
            {
                Console.Write("Введите новое имя: ");
                contact.FirstName = Console.ReadLine();
                Console.Write("Введите новую фамилию: ");
                contact.LastName = Console.ReadLine();
                Console.Write("Введите новый номер телефона: ");
                contact.PhoneNumber = Console.ReadLine();

                Console.WriteLine("Контакт обновлен.");
            }
            else
            {
                Console.WriteLine("Контакт не найден.");
            }
        }

        static void SearchContact()
        {
            Console.Write("Введите номер телефона для поиска: ");
            string phoneNumber = Console.ReadLine();

            Contact contact = phoneBook.Find(c => c.PhoneNumber == phoneNumber);
            if (contact != null)
            {
                Console.WriteLine("Контакт найден: " + contact);
            }
            else
            {
                Console.WriteLine("Контакт не найден.");
            }
        }

        static void DisplayPhoneBook()
        {
            if (phoneBook.Count > 0)
            {
                Console.WriteLine("Список контактов:");
                foreach (var contact in phoneBook)
                {
                    Console.WriteLine(contact);
                }
            }
            else
            {
                Console.WriteLine("Телефонная книга пуста.");
            }
        }
    }

