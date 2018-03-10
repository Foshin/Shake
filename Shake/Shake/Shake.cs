using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shake
{
    class Shake:Figur
    {
        public Direct Direct;

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

        public void PressKey(ConsoleKey k)
        {
            if (k == ConsoleKey.LeftArrow)
                Direct = Direct.LEFT;
            else if (k == ConsoleKey.RightArrow)
                Direct = Direct.RIGHT;
            else if (k == ConsoleKey.UpArrow)
                Direct = Direct.UP;
            else if (k == ConsoleKey.DownArrow)
                Direct = Direct.DOWN;
        }

    }
}
