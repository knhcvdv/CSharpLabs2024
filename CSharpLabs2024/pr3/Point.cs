using System;

namespace pr3
{
    public class Point
    {
        private int x; // Координата X точки
        private int y; // Координата Y точки
        private string name; // Назва точки (необов'язково)

        // Конструктор для ініціалізації координат і, можливо, назви точки
        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        // Властивість для доступу до координати X
        public int X
        {
            get { return x; }
        }

        // Властивість для доступу до координати Y
        public int Y
        {
            get { return y; }
        }

        // Властивість для доступу до назви точки (необов'язково)
        public string Name
        {
            get { return name; }
        }
    }
}