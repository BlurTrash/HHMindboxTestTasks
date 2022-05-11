using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquaresLibrary
{
    public class Circle : Figure
    {
        private double _radius;
        public Circle(double radius) 
        {
            if (IsCorrectRadius(radius))
            {
                _radius = radius;
            }          
        }
        /// <summary>
        /// Метод возвращающий площадь окружности
        /// </summary>
        public override double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
        /// <summary>
        /// Метод возвращающий имя фигуры
        /// </summary>
        public override string GetName()
        {
            return "Окружность";
        }

        /// <summary>
        /// Метод возвращающий периметр окружности
        /// </summary>
        public override double GetPerimetr()
        {
            return Math.PI * _radius * 2;
        }

        //Проверка на корректность радиуса
        private bool IsCorrectRadius(double radius)
        {
            if (radius < 0)
            {
                throw new FigureException("Радиус не может быть отрицательным!");
            }
            else if (radius == 0)
            {
                throw new FigureException("Радиус равен нулю!");
            }
            return true;
        }
    }
}
