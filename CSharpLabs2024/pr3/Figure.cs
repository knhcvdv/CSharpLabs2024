using System;

namespace pr3
{
    public class Figure
    {
        private Point[] points; // Масив точок, які утворюють багатокутник

        // Конструктори, які приймають від 3 до 5 точок для утворення багатокутника
        public Figure(Point a, Point b, Point c)
        {
            points = new Point[] { a, b, c };
        }

        public Figure(Point a, Point b, Point c, Point d)
        {
            points = new Point[] { a, b, c, d };
        }

        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            points = new Point[] { a, b, c, d, e };
        }

        // Метод для розрахунку довжини сторони між двома точками
        public double LengthSide(Point A, Point B)
        {
            double dx = A.X - B.X;
            double dy = A.Y - B.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        // Метод для розрахунку периметру багатокутника
        public void PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length; i++)
            {
                Point a = points[i];
                Point b = points[(i + 1) % points.Length]; // Отримуємо наступну точку (закільцюємо, якщо доходимо до останньої точки)
                perimeter += LengthSide(a, b); // Додаємо довжину сторони до загального периметру
            }
            Console.WriteLine("Polygon perimeter: " + perimeter); // Виводимо результат
        }
    }
}