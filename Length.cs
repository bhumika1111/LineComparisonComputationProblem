using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparision
{
    /// <summary>
    /// Here We Check The Length Of Line Using Cartician System.
    /// </summary>
    public static class Length
    {
        /// <summary>
        /// Checks the length of line.
        /// </summary>
        public static void CheckLengthOfLine()
        {
            Console.WriteLine(":::::::::Enter The Coordinates Of x1 and y1 ::::::::::");
           double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x1:" + x1);

            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y1:" + y1);

            Console.WriteLine("::::::::::Enter The Coordinates Of x2 and y2 :::::::::::");
           double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x2:" + x2);

            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y2:" + y2);


            var LengthOfLine = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Console.WriteLine("Length Of Line:" + LengthOfLine);

        }
    }
}
