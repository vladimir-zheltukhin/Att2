using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BL;

namespace Task_9_1_11__Console_
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

                    if (arr.IsMatrixRectangular(a))
                    {
                        string[,] Matrix = new string[a.Length, a[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length];
                        for (int i = 0; i < a.Length; i++)
                        {
                            var numbers = a[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            for (int k = 0; k < numbers.Length; k++)
                            {
                                Matrix[i, k] = numbers[k];
                            }
                        }
                        List<List<string>> result = new List<List<string>>();
                        arr.ArrayStr = Matrix;
                        result = arr.DeleteAllSameLines();
                        Console.WriteLine("Измененная матрица:");
                        for (int i = 0; i < result.Count; i++)     //вывод результата
                        {
                            for (int k = 0; k < result[0].Count; k++)
                            {
                                Console.Write(result[i][k] + " ");
                            }
                            Console.WriteLine();
                        }
                        Save(a);
                    }
                    else
                    {
                        Console.WriteLine("Матрица не прямоугольная");
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка");
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