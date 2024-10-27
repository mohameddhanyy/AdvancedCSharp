using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_
{
    class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int _X , int _Y)
        {
            X = _X;
            Y = _Y;
        }

        public override string ToString()
        {
            return $"({X} , {Y})";
        }

        //public int CompareTo(object? obj)
        //{
        //    Point PassedPoint = obj as Point;
        //    if (PassedPoint != null)
        //    {
        //        if (this.X.Equals(PassedPoint.X))
        //            return Y.CompareTo(PassedPoint.Y);
        //        else
        //            return X.CompareTo(PassedPoint.X);
        //    }
        //    else return -1;

        //}

        public int CompareTo(Point? PassedPoint)
        {
            if (PassedPoint != null)
            {
                if (this.X.Equals(PassedPoint.X))
                    return Y.CompareTo(PassedPoint.Y);
                else
                    return X.CompareTo(PassedPoint.X);
            }
            else return -1;


        }
    }
}
