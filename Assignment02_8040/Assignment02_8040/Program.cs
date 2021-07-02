using System;

namespace Assignment02_8040
{
    class Program
    {
        static void Main(string[] args)
        {

            int A, B, C;
            TriangleSolve T = new TriangleSolve();
            int Select = 0;

            Console.Write("Check whether a triangle is Equilateral, Isosceles or Scalene:\n");
            Console.Write("----------------------------------------------------------------");
            Console.Write("\n\n");

            while (Select != 2)
            {
                Select = Menuselection();
                switch (Select)
                {
                    case 1:
                        Console.Write("Input side 1 of triangle: ");
                        A = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Input side 2 of triangle: ");
                        B = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Input side 3 of triangle: ");
                        C = Convert.ToInt32(Console.ReadLine());
                        T.Analyze(A, B, C);
                        break;
                    case 2:
                        break;
                    default:
                        break;
                }
            }
        }



        public static int Menuselection()
        {
            int selection;
            Console.WriteLine();
            Console.WriteLine("1 = Enter triangle dimensions");
            Console.WriteLine("2 = Exit");

            Console.WriteLine();
            Console.WriteLine("Please select the number to perform Operation : ");
            selection = Convert.ToInt32(Console.ReadLine());

            if (selection > 2 || selection < 0)
            {
                Console.WriteLine();
                Console.WriteLine("Please select valid number from the list to perform operation : ");
                Console.WriteLine();
            }

            Console.WriteLine();
            return selection;
        }

    }
}

