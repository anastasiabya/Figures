using System;
using System.Diagnostics;

namespace Practice2
{
    public class Triangle : Figure
    {
        private double a;
        private double b;
        private double c;
        public Triangle() { }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="trA">Первая сторона треугольника</param>
        /// <param name="trB">Вторая сторона треугольника</param>
        /// <param name="trC">Третья сторона треугольника</param>
        public Triangle(double trA, double trB, double trC)
        {
            a = trA;
            b = trB;
            c = trC;
        }

        /// <summary>
        /// Проверка на отрицательность первой стороны треугольника
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
        /// Проверка на отрицательность второй стороны треугольника
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
        /// Проверка на отрицательность третьей стороны треугольника
        /// </summary>
        public double C
        {
            set
            {
                if (C > 0) c = value;
                else Console.WriteLine("Неправильно введенные данные");
            }
            get { return c; }
        }

        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public override string Area()
        {
            double p = (a + b + c) / 2;
            string ar = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2).ToString();
            Trace.WriteLine("Triangle area " + ar);
            return ar;

        }

        /// <summary>
        /// Вычисление периметра треугольника
        /// </summary>
        /// <returns>Периметр треугольника</returns>
        public override string Perimeter()
        {
            string pe = Math.Round((a + b + c), 3).ToString();
            Trace.WriteLine("Triangle perimeter " + pe);
            return pe;
        }

        /// <summary>
        /// Присвоение названия фигуры (треугольник)
        /// </summary>
        /// <returns>Название фигуры (треугольник)</returns>
        public override string ShapeName()
        {
            return "Треугольник";
        }
    }
}