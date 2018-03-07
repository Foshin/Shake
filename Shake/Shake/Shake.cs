using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shake
{
    class Shake:Figur
    {
        public Shake(Point End,int Rzm, Direct Direct)
        {
            pList = new List<Point>();
            for (int i=0;i<Rzm;i++)
            {
                Point p = new Point(End);
                p.Move(i, Direct);
                pList.Add(p);
            }
        }
    }
}
