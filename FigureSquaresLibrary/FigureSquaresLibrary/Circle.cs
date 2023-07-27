using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquaresLibrary
{
    public class Circle : Shape
    {
        private const string SHAPE_NAME = "Круг";

        public double Radius { get; private set; }
        public Circle(double radius) : base(SHAPE_NAME)
        {
            if (IsCorrectRadius(radius))
            {
                Radius = radius;
            }          
        }

        /// <summary>
        /// Метод возвращающий площадь окружности
        /// </summary>
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        //Проверка на корректность радиуса
        private bool IsCorrectRadius(double radius)
        {
            if (radius < 0)
            {
                throw new ShapeException("Радиус не может быть отрицательным!");
            }
            else if (radius == 0)
            {
                throw new ShapeException("Радиус равен нулю!");
            }
            return true;
        }
    }
}
