using System;
using System.Linq;

namespace Figures
{
    public class Triangle : IFigure
    {
        public double A1 { get; set; }
        public double A2 { get; set; }
        public double A3 { get; set; }
        public bool IsRectangular
        {
            get
            {
                if (A1 > A2)
                {
                    if (A1 > A3) { return A1 * A1 == A2 * A2 + A3 * A3; }
                    else { return A3 * A3 == A2 * A2 + A1 * A1; }
                }
                else
                {
                    if (A2 > A3) { return A2 * A2 == A1 * A1 + A3 * A3; }
                    else { return A3 * A3 == A2 * A2 + A1 * A1; }
                }
            }
        }
        public Triangle(params double[] values)
        {
            if (values.Count() != 3) throw new Exception("Треугольник содержит менее и более 3х сторон");
            A1 = values[0];
            A2 = values[1];
            A3 = values[2];
            Valid.Validator.Validate(this);
        }
        public double GetSquare()
        {
            var p = GetSemiPerimetr();
            return Math.Sqrt(p * (p - A1) * (p - A2) * (p - A3));
        }
        private double GetSemiPerimetr()
        {
            return (A1 + A2 + A3) / 3;
        }
    }
}
