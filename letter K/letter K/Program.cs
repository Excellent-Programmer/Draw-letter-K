using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letter_K
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, column, j = 5, i = 0;

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || ((row == column + 1) && column != 0))
                        Console.Write("*");

                    else if (row == i && column == j)
                    {
                        Console.Write("*");
                        i += 1;
                        j -= 1;
                    }
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Read();
        }
    }
}
