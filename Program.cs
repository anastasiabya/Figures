using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Xml;

namespace Practice2
{
    /// <summary>
    /// Абстрактный класс Figure
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Вычисление площади фигуры
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        public abstract string Area();


        /// <summary>
        /// Вычисление периметра фигуры
        /// </summary>
        /// <returns>Периметр фигуры</returns>
        public abstract string Perimeter();


        /// <summary>
        /// Присвоение названия фигуры
        /// </summary>
        /// <returns>Название фигуры</returns>
        public abstract string ShapeName();


        /// <summary>
        /// Вывод информации о фигуре на экран
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine(
                $"Название фигуры: {ShapeName()}\n" +
                $"Площадь: {Area()}\n" +
                $"Периметр: {Perimeter()}");
            Console.WriteLine();
        }
    }


    class Program
    {
        static List<Figure> myFigure = new List<Figure>();


        /// <summary>
        /// Чтение из файла
        /// </summary>
        internal static void ReadFile()
        {
            double a, b, c, n;
            string[] inputStrs = File.ReadAllLines("input.txt", Encoding.Default);
            foreach (string i in inputStrs)
            {
                if (i == inputStrs[0]) continue;
                string[] str = i.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                switch (str[0])
                {
                    case "Rectangle":
                        a = Convert.ToDouble(str[1]);
                        b = Convert.ToDouble(str[2]);
                        Trace.WriteLine("Стороны прямоугольника " + a + " и " + b);
                        myFigure.Add(new Rectangle(a, b));
                        break;
                    case "Triangle":
                        a = Convert.ToDouble(str[1]);
                        b = Convert.ToDouble(str[2]);
                        c = Convert.ToDouble(str[3]);
                        Trace.WriteLine("Стороны треугольника " + a + ", " + b + " и " + c);
                        myFigure.Add(new Triangle(a, b, c));
                        break;
                    case "Circle":
                        a = Convert.ToDouble(str[1]);
                        Trace.WriteLine("Радиус круга " + a);
                        myFigure.Add(new Circle(a));
                        break;
                    default:
                        n = Convert.ToInt32(inputStrs[0]);
                        Trace.WriteLine("Количество фигур " + n);
                        break;
                }
            }
        }

        /// <summary>
        /// Точка входа для программы
        /// </summary>
        public static void Main()
        {
            ReadFile();

            ser(myFigure);
   
            foreach (Figure figure in myFigure)
            {
                figure.ShowInfo();
            }
        }

        /// <summary>
        /// Сериализация в файл output.txt
        /// </summary>
        /// <param name="f">Лист фигур</param>
        private static void ser(List<Figure> f)
        {
            Type[] types = new Type[] { typeof(Rectangle), typeof(Triangle), typeof(Circle) };
            var serializer = new XmlSerializer (typeof(Figure),types);
            using (StreamWriter streamWriter = new StreamWriter("output.txt"))
            {
                foreach (var item in f)
                {
                    serializer.Serialize(streamWriter, item);
                }
            }
        }
    }
}
