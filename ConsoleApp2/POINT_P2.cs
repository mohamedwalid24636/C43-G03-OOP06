using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class POINT_P2 : IComparer<_3D_point>
    {
        public int Compare(_3D_point? x, _3D_point? y)
        {
            if (x?.P2 > y?.P2)
                return 1;
            else if (x?.P2 < y?.P2)
                return -1;
            else return 0; 
        }
    }
}
