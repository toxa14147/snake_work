using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80,25);
            Point p = new Point(3,3,'*');
            p.Drow();

            HorisontalLine upline = new HorisontalLine(1, 78, 1, '*');
            HorisontalLine downline = new HorisontalLine(1, 78, 23, '*');
            Verticalline leftline = new Verticalline(1, 24, 1, '*');
            Verticalline rightline = new Verticalline(1, 24, 78, '*');

            upline.Drow();
            downline.Drow();
            leftline.Drow();
            rightline.Drow();
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            Console.ReadLine();
            
          
        }
    }
}
