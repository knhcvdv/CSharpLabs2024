using pr3;
using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Console.WriteLine();
            Task2();
        }

        private static void Task1()
        {
            // Створюємо об'єкт класу Book з вказанням назви книги, імені автора та змісту
            Book book = new Book("Портрет Доріана Грея", "Оскар Уайльд", "Історія молодого аристократа, чия картинка старіє, а він залишається молодим.");

            // Показуємо початкові дані про книгу
            book.Show();

            // Змінюємо автора та зміст книги
            book.SetAuthor("Джеймс Джойс");
            book.SetContent("Ця книга розповідає історію молодої дівчини, яка вирішує виїхати з провінції до Дубліна.");

            // Показуємо оновлені дані про книгу
            book.Show();

            Console.ReadKey(); // Очікуємо натискання клавіші для завершення програми
        }
        private static void Task2()
        {
            // Створення точок, що утворюють багатокутник
            Point a = new Point(0, 0, "A");
            Point b = new Point(3, 0, "B");
            Point c = new Point(3, 4, "C");
            Point d = new Point(0, 4, "D");

            // Створення багатокутника з чотирьох точок та виведення периметру
            Figure figure1 = new Figure(a, b, c, d);
            Console.WriteLine("Polygon Name: ABCD");
            figure1.PerimeterCalculator();

            Console.ReadLine(); // Чекаємо натискання клавіші для завершення програми
        }
    }
}