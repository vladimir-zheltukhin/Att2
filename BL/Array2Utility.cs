using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Array2Utility
    {
        public string[,] ArrayStr { get; set; }

        public double[,] ArrayDouble { get; set; }
        
        public List<List<string>> DeleteAllSameLines()
        {
            List < List < string >> result = new List<List<string>>();

            List<int> deletedColumns = new List<int>();

            List<int> deletedRows = new List<int>();

            deletedColumns = IndecesOfSameColumns();
            deletedRows = IndecesOfSameRows();

            for (int i = 0; i < ArrayStr.GetLength(0);i++)
            {
                List<string> str = new List<string>();
                for ( int k = 0; k < ArrayStr.GetLength(1); k++)
                {
                    str.Add(ArrayStr[i, k]);
                }
                result.Add(str);
            }
            for ( int n = deletedRows.Count - 1; n > -1; n --) //удаление строк
            {
                result.RemoveAt(deletedRows[n]);
            }
            for (int j = 0; j < result.Count; j++)
            {
                for (int z = deletedColumns.Count - 1; z > -1; z--)
                {
                    result[j].RemoveAt(deletedColumns[z]);
                }
            }
            return result;
        }
        private List<int> IndecesOfSameColumns()
        {
            List<int> indecexColumn = new List<int>();
            for( int i = 0; i < ArrayStr.GetLength(1); i++)
            {
                if (IsColumnSame(i))
                {
                    indecexColumn.Add(i);
                }
            }
            return indecexColumn;
        }
        private List<int> IndecesOfSameRows()
        {
            List<int> indecexRows = new List<int>();
            for (int k = 0; k < ArrayStr.GetLength(0); k++)
            {
                if (IsRowSame(k))
                {
                    indecexRows.Add(k);
                }
            }
            return indecexRows;
        }
        private bool IsRowSame(int n)
        {
            for (int i = 0; i < ArrayStr.GetLength(1); i++)
            {
                if (!ArrayStr[n , 0].Equals(ArrayStr[n , i]))
                {
                    return false;
                }
            }
            return true;
        }
        private bool IsColumnSame(int n)
        {
            for (int k = 0; k < ArrayStr.GetLength(0); k++)
            {
                if (!ArrayStr[0 , n].Equals(ArrayStr[k , n]))
                {
                    return false;
                }
            }
            return true;
        }

        public double FindMaxUpperDiagonal()
        {
            int length = ArrayDouble.GetLength(0);
            double max = ArrayDouble[0, 1];
            for ( int i = 0; i < length - 1; i ++)
            {
                for (int k = i + 1; k < length; k++)
                {
                    if (ArrayDouble[i, k] > max)
                        max = ArrayDouble[i, k];
                }
            }
            return max;
        }

        public double FindMinUnderDiagonal()
        {
            int length = ArrayDouble.GetLength(0);
            double min = ArrayDouble[1, 0];
            for (int i = 0; i < length - 1; i++)
            {
                for (int k = i + 1; k < length; k++)
                {
                    if (ArrayDouble[k, i] < min)
                        min = ArrayDouble[k, i];
                }
            }
            return min;
        }

        public bool IsMatrixRectangular(string[] matrixStr)
        {
            for (int i = 0; i < matrixStr.Length; i++)
                if (matrixStr[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length != matrixStr[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length)
                    return false;
            return true;
        }
        public bool IsMatrixSquare(string[] matrixStr)
        {
            int i;
            for (i = 0; i < matrixStr.Length; i++)
                if (matrixStr[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length != matrixStr[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length)
                    return false;
            if (matrixStr.Length != i)
                return false;
            return true;
        }
    }
}
