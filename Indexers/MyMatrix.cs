using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class MyMatrix<T>
    {
        private T[,] _array;

        public MyMatrix (int rows, int cols)
        {
            this._array = new T[rows, cols];
        }

        public T this [int rowsIndex, int colsIndex]
        {
            get
            {
                return _array[rowsIndex, colsIndex];
            }
            set 
            {
                _array[rowsIndex, colsIndex] = value;
            }
        }

        public void AddRows(int qtyOfRowsToAdd)
        {
            T[,] tmpArray = new T[_array.GetLength(0) + qtyOfRowsToAdd, _array.GetLength(1)];

            for (int i = 0; i<_array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    tmpArray[i, j] = _array[i, j];
                }
            }

            this._array = tmpArray;
        }

        public void AddColumns(int qtyOfColumnsToAdd)
        {
            T[,] tmpArray = new T[_array.GetLength(0), _array.GetLength(1) + qtyOfColumnsToAdd];
            
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    tmpArray[i, j] = _array[i, j];
                }
            }

            this._array = tmpArray;

        }

        public void PrintMatrix()
        {
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    
                    if (j == _array.GetLength(1) - 1)
                    {
                        Console.WriteLine("{0} ",_array[i, j]);
                    }
                    else Console.Write("{0} ",_array[i, j]);
                }
            }
        }
    }
}
