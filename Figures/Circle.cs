using Figures.Valid;
using System;

namespace Figures
{
    public class Circle : IFigure
    {

        public double R { get; set; }
        public Circle(double r)
        {
            R = r;
            Validator.Validate(this);
        }
        public double GetSquare()
        {
            return Math.PI * R * R;
        }
    }
}
