using System;
using System.Diagnostics;

namespace Practice2
{
    public class Circle : Figure
    {
        public Circle() { }
        private double r;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="cirR">Радиус круга</param>
        public Circle(double cirR)
        {
            r = cirR;
        }

        /// <summary>
        /// Проверка на отрицательность радиуса
        /// </summary>
        public double R
        {
            set
            {
                if (R > 0) r = value;
                else Console.WriteLine("Неправильно введенные данные");
            }
            get { return r; }
        }

        /// <summary>
        /// Вычисление площади круга
        /// </summary>
        /// <returns>Площадь круга</returns>
        public override string Area()
        {
            string ar = Math.Round((Math.PI * r * r), 2).ToString();
            Trace.WriteLine("Circle area " + ar);
            return ar;
        }

        /// <summary>
        /// Вычисление периметра круга
        /// </summary>
        /// <returns>Периметр круга</returns>
        public override string Perimeter()
        {
            string pe = Math.Round((2 * Math.PI * r), 2).ToString();
            Trace.WriteLine("Circle perimeter " + pe);
            return pe;
        }

        /// <summary>
        /// Присвоение названия фигуры (круг)
        /// </summary>
        /// <returns>Название фигуры (круг)</returns>
        public override string ShapeName()
        {
            return "Круг";
        }
    }
}