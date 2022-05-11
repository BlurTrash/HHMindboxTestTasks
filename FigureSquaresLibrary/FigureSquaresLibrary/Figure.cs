using System;

namespace FigureSquaresLibrary
{
    /// <summary>
    /// Абстрактный класс Фигуры, для создания новой фигуры достаточно реализовать его
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Метод возвращающий имя фигуры
        /// </summary>
        public abstract string GetName();
        /// <summary>
        /// Метод возвращающий площадь
        /// </summary>
        public abstract double GetArea();
        /// <summary>
        /// Метод возвращающий периметр
        /// </summary>
        public abstract double GetPerimetr();
        /// <summary>
        /// Метод возвращающий информацию о фигуре
        /// </summary>
        public virtual void FigureInfo()
        {
            Console.WriteLine($"Фигура - { GetName()}\nПлощадь - {GetArea()}\nПериметр - {GetPerimetr()}");
        }
    }
}
