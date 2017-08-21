using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleChallenge
{
    public enum triType
    {
        Scalene = 1,
        Isosceles = 2,
        Equilateral = 3,
        Oops = 4,
    }
    public class TypeControl
    {
        public triType triangleType(decimal[] triangle)
        {
            switch (triangle.Distinct().Count())
            {
                case 1:
                    return triType.Equilateral;
                case 2:
                    return triType.Isosceles;
                case 3:
                    return triType.Scalene;
                default:
                    return triType.Oops;
            }
        }
    }
}
