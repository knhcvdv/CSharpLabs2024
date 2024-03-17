using System;

namespace pr3.bookDescription
{
    class Content
    {
        private string bookContent;

        // Конструктор класу, який приймає зміст книги
        public Content(string content)
        {
            bookContent = content;
        }

        // Метод для зміни змісту книги
        public void SetContent(string content)
        {
            bookContent = content;
        }

        // Метод для відображення змісту книги
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red; // Встановлюємо колір тексту
            Console.WriteLine($"Content: {bookContent}"); // Виводимо зміст книги
            Console.ResetColor(); // Скидаємо колір тексту на стандартний
        }
    }
}