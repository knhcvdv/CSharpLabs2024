using System;

namespace pr3.bookDescription
{
    class Title
    {
        private string bookTitle;

        // Конструктор класу, який приймає назву книги
        public Title(string title)
        {
            bookTitle = title;
        }

        // Метод для відображення назви книги
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue; // Встановлюємо колір тексту
            Console.WriteLine($"Title: {bookTitle}"); // Виводимо назву книги
            Console.ResetColor(); // Скидаємо колір тексту на стандартний
        }

    }
}