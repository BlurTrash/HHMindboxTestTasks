using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquaresLibrary
{
    public class Triangle : Shape
    {
        private const string SHAPE_NAME = "Треугольник";

        public double ASide { get; private set; }
        public double BSide { get; private set; }
        public double CSide { get; private set; }

        public Triangle(double aSide, double bSide, double cSide) : base(SHAPE_NAME)
        {
            if (IsCorrectSides(aSide, bSide, cSide))
            {
                ASide = aSide;
                BSide = bSide;
                CSide = cSide;
            }
        }
        /// <summary>
        /// Метод возвращающий площадь треугольника
        /// </summary>
        public override double GetArea()
        {
            double p = (ASide + BSide + CSide) / 2; //p - полупериметр
            return Math.Sqrt(p * (p - ASide) * (p - BSide) * (p - CSide));
        }
       
       
        //проверка корректности сторон треугольника
        private bool IsCorrectSides(double aSide, double bSide, double cSide)
        {
            if(aSide <= 0 || bSide <= 0 || cSide <= 0)
            {
                throw new ShapeException("Одна из сторон треугольника меньше или равно нулю!");
            }
            else if (aSide >= (bSide + cSide) || bSide >= (aSide + cSide) || cSide >= (aSide + bSide))
            {
                throw new ShapeException("Треугольника не существует - одна из сторон больше или равно двум другим сторонам!");
            }
            return true;
        }
        /// <summary>
        /// Метод определяет является ли треугольник - Равносторонним
        /// </summary>
        /// <returns>Возвращает true - если треугольник прямоугольный, иначе false</returns>
        public bool IsRightTriangle()
        {
            bool isRight = Math.Pow(ASide, 2) == (Math.Pow(BSide, 2) + Math.Pow(CSide, 2)) ||
                Math.Pow(BSide, 2) == (Math.Pow(ASide, 2) + Math.Pow(CSide, 2)) ||
                Math.Pow(CSide, 2) == (Math.Pow(ASide, 2) + Math.Pow(BSide, 2));

            return isRight;
        }
    }
}
