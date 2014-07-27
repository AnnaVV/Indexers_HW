using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {

            MyMatrix<char> twoDimensionalMatrix= new MyMatrix<char>(2,3);

            twoDimensionalMatrix[0, 0] = 't';
            twoDimensionalMatrix[0, 1] = 'g';
            twoDimensionalMatrix[0, 2] = 'F';
            twoDimensionalMatrix[1, 0] = 'b';
            twoDimensionalMatrix[1, 1] = 'r';
            twoDimensionalMatrix[1, 2] = 'u';

            twoDimensionalMatrix.PrintMatrix();

            twoDimensionalMatrix.AddColumns(1);
            twoDimensionalMatrix[1, 3] = 'w';
            Console.WriteLine(("").PadRight(15, '-'));
            twoDimensionalMatrix.PrintMatrix();

            Console.ReadLine();

        }
    }
}
