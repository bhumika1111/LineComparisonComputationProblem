using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparision
{
    /// <summary>
    /// Here We Check The Equality Of Two Lines Based On The End Points .
    /// </summary>
    public static class EqualityOfLines
    {
        /// <summary>
        /// Checks the equality of two lines.
        /// </summary>
        public static void CheckEqualityOfTwoLines()
        {
            Console.WriteLine(":::::Enter The x1 and y1 Coordinates:::::");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x1:" + x1);
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y1:" + y1);
        

            Console.WriteLine("::::::Enter The x2 and y2 Coordinates::::");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x2:" + x2);
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y2:" + y2);

            Console.WriteLine("::::::::Enter The x3 and y3 Coordinates::::::::");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x3:" + x3);
            double y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y3:" + y3);

            Console.WriteLine(":::::::::::Enter The x4 and y4 Coordinates:::::::::");
            double x4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x4:" +x4);
            double y4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y4:" +y4);

            var Length1 = Math.Sqrt((Math.Pow(x1 - y1, 2)) + Math.Pow(x2 - y2, 2));
            var Length2 = Math.Sqrt((Math.Pow(x3 - y3, 2)) + Math.Pow(x4 - y4, 2));

            if(Length1==Length2)

            {
                Console.WriteLine("Two Lines Are Equal");
            }
            else
            {
                Console.WriteLine("Two Lines Are Not Equal");
            }
        }
    }
}
