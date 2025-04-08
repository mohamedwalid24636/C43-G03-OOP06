using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    internal class calss_Math
    {
        public static float Add(float num1, float num2)
        {
            return num1 + num2;
        }




        public static float Subtract(float num1, float num2)
        {
            return num1 - num2;
        }
        public static float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }
        public static float Divide(float num1, float num2)
        {
            return num1 / num2;
        }

    };




    internal class _3D_point : IComparable<_3D_point> , ICloneable  
    {
        public _3D_point(int p1, int p2, int p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
        }

        public int P1 { set; get; }
        public int P2 { set; get; }
        public int P3 { set; get; }
        public _3D_point ()
        {

        }
        public object Clone()
        {
                return new _3D_point()
                { 
                 P1 =this.P1,
                 P2=this.P2,
                 P3=this.P3,
 
                };

        }

        public int CompareTo(_3D_point? point)
        {
                return this.P1.CompareTo(point?.P1);
        }

        public override string ToString()
        {
            return $"(Point Coordinates: ({P1},{P2},{P3})";
        }






        public static bool operator ==(_3D_point p1, _3D_point p2)
        {
            if (p1.P1 == p2.P1 && p1.P2 == p2.P2 && p1.P3 == p2.P3)
                return true;
            else return false;
        }


        public static bool operator !=(_3D_point p1, _3D_point p2)
        {
            if (p1.P1 != p2.P1 && p1.P2 != p2.P2 && p1.P3 != p2.P3)
                return true;
            else return false;
        }

        

    } 
}
