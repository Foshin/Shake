using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shake
{
    class Shake:Figur
    {
        Direct Direct;

        public Shake(Point End,int Rzm, Direct _Direct)
        {
            Direct = _Direct;
            pList = new List<Point>();
            for (int i=0;i<Rzm;i++)
            {
                Point p = new Point(End);
                p.Move(i, Direct);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();

        }

        public  Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, Direct);
            return nextPoint;

        }
    }
}
