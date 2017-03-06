using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Train
    {

        public List<Point> points = new List<Point>();
        char sign;
        char golova;
        public int dx;
        public int dy;

        public Train()
        {
            this.sign = '#';
            this.points.Add(new Point(4,10));
            this.points.Add(new Point(5,10));
            this.points.Add(new Point(6,10));
            this.points.Add(new Point(7,10));
            this.points.Add(new Point(8, 10));
            this.points.Add(new Point(9, 10));
        
        }
        public void Move()
        {
            while (true)
            {
                if (points[0].x + dx < 0) break;
                if (points[0].y + dy < 0) break;
                if (points[0].x + dx > 39) break;
                if (points[0].y + dy > 39) break;


                Clear();
                for (int i = points.Count - 1; i > 0; --i)
                {
                    points[i].x = points[i - 1].x;
                    points[i].y = points[i - 1].y;
                }

                points[0].x = points[0].x + dx;
                points[0].y = points[0].y + dy;

                Draw();
                Thread.Sleep(100);
            }
        }
        public void Clear()
        {
            for (int i = 0; i < points.Count; ++i)
            {
                Console.SetCursorPosition(points[i].x, points[i].y);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(' ');
            }
        }
        public void Draw()
        {
         

            for (int i = 0; i < points.Count; ++i)
            {
                Console.SetCursorPosition(points[i].x, points[i].y);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(sign);
            }
        }
    }
}
