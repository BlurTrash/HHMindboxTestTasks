using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquaresLibrary
{
    public class Triangle : Figure
    {
        private double _aSide;
        private double _bSide;
        private double _cSide;
        public Triangle(double aSide, double bSide, double cSide)
        {
            if (IsCorrectSides(aSide, bSide, cSide))
            {
                _aSide = aSide;
                _bSide = bSide;
                _cSide = cSide;
            }
        }
        /// <summary>
        /// Метод возвращающий площадь треугольника
        /// </summary>
        public override double GetArea()
        {
            //p - полупериметр
            double p = (_aSide + _bSide + _cSide) / 2;
            return Math.Sqrt(p * (p - _aSide) * (p - _bSide) * (p - _cSide));
        }
        /// <summary>
        /// Метод возвращающий имя фигуры
        /// </summary>
        public override string GetName()
        {
            return "Треугольник";
        }
        /// <summary>
        /// Метод возвращающий периметр треугольника
        /// </summary>
        public override double GetPerimetr()
        {
            return _aSide + _bSide + _cSide;
        }
        //проверка корректности сторон треугольника
        private bool IsCorrectSides(double aSide, double bSide, double cSide)
        {
            if(aSide <= 0 || bSide <= 0 || cSide <= 0)
            {
                throw new FigureException("Одна из сторон треугольника меньше или равно нулю!");
            }
            else if (aSide >= (bSide + cSide) || bSide >= (aSide + cSide) || cSide >= (aSide + bSide))
            {
                throw new FigureException("Треугольника не существует - одна из сторон больше или равно двум другим сторонам!");
            }
            return true;
        }
        /// <summary>
        /// Метод определяет является ли треугольник - Равносторонним
        /// </summary>
        /// <returns>Возвращает true - если треугольник прямоугольный, иначе false</returns>
        public bool IsRightTriangle()
        {
            bool isRight = Math.Pow(_aSide, 2) == (Math.Pow(_bSide, 2) + Math.Pow(_cSide, 2)) ||
                Math.Pow(_bSide, 2) == (Math.Pow(_aSide, 2) + Math.Pow(_cSide, 2)) ||
                Math.Pow(_cSide, 2) == (Math.Pow(_aSide, 2) + Math.Pow(_bSide, 2));

            return isRight;
        }
    }
}
