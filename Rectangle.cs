using System;
using System.Diagnostics;

namespace Practice2
{
    public class Rectangle : Figure
    {
        private double a;
        private double b;
        public Rectangle() { }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="recA">Первая сторона прямоугольника</param>
        /// <param name="recB">Вторая сторона прямоугольника</param>
        public Rectangle(double recA, double recB)
        {
            a = recA;
            b = recB;
        }


        /// <summary>
        /// Проверка на отрицательность первой стороны прямоугольника
        /// </summary>
        public double A
        {
            set
            {
                if (A > 0) a = value;
                else Console.WriteLine("Неправильно введенные данные");
            }
            get { return a; }
        }

        /// <summary>
        /// Проверка на отрицательность второй стороны прямоугольника
        /// </summary>
        public double B
        {
            set
            {
                if (B > 0) b = value;
                else Console.WriteLine("Неправильно введенные данные");
            }
            get { return b; }
        }

        /// <summary>
        /// Вычисление площади прямоугольника
        /// </summary>
        /// <returns>Площадь прямоугольника</returns>
        public override string Area()
        {
            string ar = Math.Round((a * b), 2).ToString();
            Trace.WriteLine("Rectangle area " + ar);
            return ar;
        }

        /// <summary>
        /// Вычисление периметра прямоугольника
        /// </summary>
        /// <returns>Периметр прямоугольника</returns>
        public override string Perimeter()
        {
            string pe = Math.Round((a * 2 + b * 2), 2).ToString();
            Trace.WriteLine("Rectangle perimeter " + pe);
            return pe;
        }

        /// <summary>
        /// Присвоение названия фигуры (прямоугольник)
        /// </summary>
        /// <returns>Название фигуры (прямоугольник)</returns>
        public override string ShapeName()
        {
            return "Прямоугольник";
        }
    }
}