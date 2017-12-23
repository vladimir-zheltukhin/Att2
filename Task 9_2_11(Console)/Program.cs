using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BL;
using System.Threading;
using System.Globalization;

namespace Task_9_2_11_Console_
{
    class Program
    {
        static void Main(string[] args)
        {
            Array2Utility arr = new Array2Utility();

            while (true)
            {
                try
                {
                    string[] a = InputMatrix();

                    Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
                    if (arr.IsMatrixSquare(a))
                    {
                        double[,] Matrix = new double[a.Length, a.Length];
                        for (int i = 0; i < a.Length; i++)
                        {
                            var numbers = a[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            for (int k = 0; k < numbers.Length; k++)
                            {
                                Matrix[i, k] = Convert.ToDouble(numbers[k]);
                            }
                        }

                        arr.ArrayDouble = Matrix;
                        Console.WriteLine("Наибольшее число над диагональю = " + arr.FindMaxUpperDiagonal());
                        Console.WriteLine("Наименьшее число под диагональю = " + arr.FindMinUnderDiagonal());

                        Save(a);
                    }
                    else
                    {
                        Console.WriteLine("Матрица не квадратная");
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка, неправильное заполнение матрицы");
                }
                Console.WriteLine("Нажмите любую клавишу для продолжения");
                Console.ReadKey();
            }
        }
        public static string[] InputMatrix()
        {
            SavingAndReadingUtils myOpen = new SavingAndReadingUtils();

            Console.WriteLine("Считать матрицу из файла? y/n");
            while (true)
            {
                ConsoleKeyInfo result = Console.ReadKey();
                Console.WriteLine();
                if ((result.KeyChar == 'y') || (result.KeyChar == 'Y'))
                {
                    Console.Write("Введите имя файла:");
                    try
                    {
                        return myOpen.ReadStrArrFromFile(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка при чтении файла, хотите попробовать считать матрицу из файла снова?");
                    }
                }

                if ((result.KeyChar == 'n') || (result.KeyChar == 'N'))
                {
                    while (true)
                    {
                        Console.Write("Введите длину массива: ");
                        while (true)
                        {
                            try
                            {
                                int k = Convert.ToInt32(Console.ReadLine());
                                string[] inputStrMatrix = new string[k];
                                if (k > 0)
                                {
                                    Console.WriteLine("Введите массив через пробел");
                                    for (int i = 0; i < k; i++)
                                    {
                                        inputStrMatrix[i] = Console.ReadLine();
                                    }
                                    return inputStrMatrix;
                                }
                                else
                                {
                                    Console.WriteLine("Некорректная длина массива.");
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Ошибка, попробуйте ещё раз");
                            }
                        }
                    }
                }
            }
        }
        public static void Save(string[] matrix)
        {
            SavingAndReadingUtils mySave = new SavingAndReadingUtils();
            while (true)
            {
                Console.WriteLine("Сохранить матрицу в файл? y/n");
                ConsoleKeyInfo result = Console.ReadKey();
                Console.WriteLine();
                if ((result.KeyChar == 'y') || (result.KeyChar == 'Y'))
                {
                    Console.Write("Введите полное имя файла:");
                    try
                    {
                        mySave.WriteArrInFile(Console.ReadLine(), matrix);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка при сохранении файла");
                        break;
                    }
                }
                if ((result.KeyChar == 'n') || (result.KeyChar == 'N')) { break; }
            }
        }
        
    }
}
