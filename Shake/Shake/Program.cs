using System;
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
            Console.SetBufferSize(80,25);

            HorLine lineGU = new HorLine(0,78,0,'#');
            lineGU.Draw();
            HorLine lineGD = new HorLine(0,78,24,'#');
            lineGD.Draw();
            VerLine lineVL = new VerLine(0, 0, 24, '#');
            lineVL.Draw();
            VerLine lineVR = new VerLine(78, 0, 24, '#');
            lineVR.Draw();

            Point p = new Point(4, 5, '@');
            Shake Sh = new Shake(p, 10, Direct.RIGHT);
            Sh.Draw();

            Console.ReadLine();
        }

    }
}
