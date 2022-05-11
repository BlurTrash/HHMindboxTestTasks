using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquaresLibrary
{
    //Не совсем понятно что имеется ввиду в дополнительной задаче:
    //"Вычисление площади фигуры без знания типа фигуры в compile-time" - compile-time это время компиляции,
    //если имеется ввиду, что не известно какая будет фигура на момент выполнения, насколько я знаю - это
    //называется рантайм компиляцией (когда тип на момент выполнения неизвестен)

    /// <summary>
    /// Статический класс для работы с обьектами типа Figure
    /// </summary>
    public static class FigurePrototype
    {
        /// <summary>
        /// Статический метод возвращающий площадь фигуры, если тип фигуры на момент выполнения не известен
        /// </summary>
        /// <param name="figure">Принимает на вход абстрактную фигуру</param>
        public static double GetAreaFigure(Figure figure)
        {
            return figure.GetArea();
        }
        /// <summary>
        /// Статический метод возвращающий периметр фигуры, если тип фигуры на момент выполнения не известен
        /// </summary>
        /// <param name="figure">Принимает на вход абстрактную фигуру</param>
        public static double GetPerimetrFigure(Figure figure)
        {
            return figure.GetPerimetr();
        }
    }
}
