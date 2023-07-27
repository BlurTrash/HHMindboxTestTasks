using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquaresLibrary
{
    /// <summary>
    /// Статический класс для работы с обьектами типа Figure
    /// </summary>
    public static class ShapePrototype
    {
        /// <summary>
        /// Статический метод возвращающий площадь фигуры, если тип фигуры на момент выполнения не известен
        /// </summary>
        /// <param name="figure">Принимает на вход абстрактную фигуру</param>
        public static double GetAreaFigure(Shape shape) => shape.GetArea();
        
    }
}
