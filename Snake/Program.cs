﻿using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(2, 3, '#');
            p1.draw();

            Point p2 = new Point(4, 6, '*');
            p2.draw();

            Console.ReadLine();
        }
    }
}
