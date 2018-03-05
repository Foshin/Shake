﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point t1 = new Point(0, 3, '@');
            Point t2 = new Point(1, 5, '#');
            Point t3 = new Point(2, 2, '$');

            List<Point> LP = new List<Point>();
            LP.Add(t1);
            LP.Add(t2);
            LP.Add(t3);

            foreach (Point i in LP) i.Draw();

            HorLine lineG = new HorLine(8,19,10,'$');
            lineG.Draw();

            VerLine  lineV= new VerLine(20, 5, 20, '@');
            lineV.Draw();

            Console.ReadLine();
        }

    }
}
