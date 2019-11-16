using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public abstract class geom_fig : IComparable
    {
        public abstract double Area();
        public int CompareTo(object obj)
        {
            geom_fig f = (geom_fig)obj;
            if (this.Area() < f.Area()) return -1;
            else if (this.Area() == f.Area()) return 0;
            else return 1;
        }
    }
}
