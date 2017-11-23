using System;
using System.Linq;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var rect1Args = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rect2Args = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var left1 = rect1Args[0];
            var top1 = rect1Args[1];
            var width1 = rect1Args[2];
            var height1 = rect1Args[3];

            var right1 = left1 + width1;
            var bottom1 = top1 + height1;

            var left2 = rect2Args[0];
            var top2 = rect2Args[1];
            var width2 = rect2Args[2];
            var height2 = rect2Args[3];

            var right2 = left2 + width2;
            var bottom2 = top2 + height2;

            var firstRectangle = new Rectangle()
            {
                Left = left1,
                Top = top1,
                Right = right1,
                Bottom = bottom1
            };

            var secondRectangle = new Rectangle()
            {
                Left = left2,
                Top = top2,
                Right = right2,
                Bottom = bottom2
            };

            if (IsInside(firstRectangle, secondRectangle))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        public static bool IsInside(Rectangle rect1, Rectangle rect2)
        {
            if (rect1.Left >= rect2.Left && rect1.Right <= rect2.Right
                && rect1.Top <= rect2.Top && rect1.Bottom <= rect2.Bottom)
            {
                return true;
            }

            return false;
        }
    }

    public class Rectangle
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Right { get; set; }
        public int Bottom { get; set; }
    }
}
