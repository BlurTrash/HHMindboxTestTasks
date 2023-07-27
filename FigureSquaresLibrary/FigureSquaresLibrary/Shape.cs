using System;

namespace FigureSquaresLibrary
{
    /// <summary>
    /// Абстрактный класс Фигуры, для создания новой фигуры достаточно реализовать его
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Имя фигуры
        /// </summary>
        public string Name { get; private set; }

        public Shape(string shapeName)
        {
            Name = shapeName;
        }

        /// <summary>
        /// Метод возвращающий площадь
        /// </summary>
        public abstract double GetArea();
        
        /// <summary>
        /// Метод возвращающий информацию о фигуре
        /// </summary>
        public virtual string FigureInfo()
        {
            return $"Фигура - {Name} Площадь - {GetArea()}";
        }
    }
}
