using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Valid
{
    public static class Validator
    {
        public static void Validate(IFigure fig)
        {
            switch (fig)
            {
                case Circle:
                    var circle = (Circle)fig;
                    if (circle.R < 0) throw new Exception("Отрицательный радисус");
                    break;
                case Triangle:
                    var triangle = (Triangle)fig;
                    if (triangle.A1 < 0 || triangle.A2 < 0 || triangle.A3 < 0) throw new Exception("Отрицательные значения");
                    break;
            }
        }
    }
}
