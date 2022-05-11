using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquaresLibrary
{
    public class FigureException : Exception
    {
        public FigureException(string message) : base(message) { }     
    }
}
