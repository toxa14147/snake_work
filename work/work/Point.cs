using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work
{
    class Point
    {
        int x;
        int y;
        char sym;
        public Point(int x_,int y_,char sym_)
        {
            x = x_;
            y = y_;
            sym = sym_;

           
        }
        public void Drow()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public void Move (int offset,Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            if (direction == Direction.UP)
            {
                y = y + offset;
            }
            if (direction == Direction.DOWN)
            {
                y = y - offset;
            }
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
     
        }
    } 
   
}
