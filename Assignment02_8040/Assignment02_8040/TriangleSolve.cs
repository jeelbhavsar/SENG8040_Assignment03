using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment02_8040
{
  public class TriangleSolve
    {
        public string Analyze(int A, int B, int C)
        {
            if (((A + B) < C) || ((B + C) < C) || ((C + A) < B))
            {
                Console.WriteLine("");
                Console.Write("The triangle can not be formed.\n");
                return "Can not form Triangle.";
            }

            else if (((A - B) > C) || ((B - C) > C) || ((C - A) > B))
            {
                Console.WriteLine("");
                Console.Write("The triangle can not be formed.\n");
                return "Can not form Triangle.";
            }

            else if ((A == B && B == C) && (A != 0 || B != 0 || C != 0))
            {
                Console.WriteLine("");
                Console.Write("This is an equilateral triangle.\n");
                return "This is an equilateral triangle.";
            }
            else if ((A == B || A == C || B == C) && (A != 0 || B != 0 || C != 0))
            {
                Console.WriteLine("");
                Console.Write("This is an isosceles triangle.\n");
                return "This is an isosceles triangle.";
            }

            else if (A == 0 | B == 0 || C == 0)
            {
                Console.WriteLine("");
                Console.Write("The triangle can not be formed.\n");
                return "Can not form Triangle.";
            }

            else
            {
                Console.WriteLine("");
                Console.Write("This is a scalene triangle.\n");
                return "This is a scalene triangle.";
            }
        }

    }
}
