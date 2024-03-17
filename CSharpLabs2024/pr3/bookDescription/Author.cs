using System;

namespace pr3.bookDescription
{
    class Author
    {
        private string authorName;

        // Конструктор класу, який приймає ім'я автора
        public Author(string name)
        {
            authorName = name;
        }

        // Метод для зміни ім'я автора
        public void SetAuthor(string name)
        {
            authorName = name;
        }

        // Метод для відображення ім'я автора
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green; // Встановлюємо колір тексту
            Console.WriteLine($"Author: {authorName}"); // Виводимо ім'я автора
            Console.ResetColor(); // Скидаємо колір тексту на стандартний
        }
    }
}