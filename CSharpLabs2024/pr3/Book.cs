using pr3.bookDescription;
using System;


namespace pr3
{
    public class Book
    {
        private readonly Title title; // Об'єкт класу для збереження назви книги
        private Author author; // Об'єкт класу для збереження ім'я автора
        private Content content; // Об'єкт класу для збереження змісту книги

        // Конструктор класу, який приймає початкові значення для назви книги, автора та змісту
        public Book(string bookTitle, string authorName, string bookContent)
        {
            title = new Title(bookTitle); // Ініціалізуємо об'єкт назви книги
            author = new Author(authorName); // Ініціалізуємо об'єкт автора
            content = new Content(bookContent); // Ініціалізуємо об'єкт змісту книги
        }

        // Метод для зміни автора
        public void SetAuthor(string authorName)
        {
            author.SetAuthor(authorName);
        }

        // Метод для зміни змісту книги
        public void SetContent(string bookContent)
        {
            content.SetContent(bookContent);
        }

        // Метод для відображення всіх даних про книгу
        public void Show()
        {
            title.Show(); // Виводимо назву книги
            author.Show(); // Виводимо ім'я автора
            content.Show(); // Виводимо зміст книги
        }
    }
}
