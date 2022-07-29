using System;

namespace LineComparision
{
    class Program
    {
        public static void  Main(string[] args)
        {
            Console.WriteLine(" **:::::::Welcome To Line Comparision Computation Program:::::::::::::*** ");

            Console.WriteLine("**Output For Length Of Line**");
            Length.CheckLengthOfLine();
            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("**Output For Two Lines Are Equal Based On The End Points");
            EqualityOfLines.CheckEqualityOfTwoLines();
            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("**Output For One Lines Is Equal ,Greater Or Less Than Equal To Other Line**");
            CompareTheLine.CheckComparisionOfLines();


        }
    }
}
