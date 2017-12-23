using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Utils;
using BL;
using System.Threading;
using System.Globalization;

/*
42. Составить программу поиска минимального элемента, расположенного под главной диагональю,
и максимального элемента, расположенного над главной диагональю заданной вещественной матрицы А(n*n)
*/

namespace Task_9_2_11
{
    public partial class Form1 : Form
    {
        Array2Utility matrix = new Array2Utility();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewUtils.InitGridForArr(inputMatrixDGV , 35, false, true, true, true, true);
        }

        private void FindMaxAndMinButton_Click(object sender, EventArgs e)
        {
            int rowCount = inputMatrixDGV.RowCount;
            int colCount = inputMatrixDGV.ColumnCount;
            if (rowCount != 1 && rowCount == colCount)
            {
                try
                {
                    Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
                    matrix.ArrayDouble = DataGridViewUtils.GridToArray2<double>(inputMatrixDGV);
                    double min = matrix.FindMinUnderDiagonal();
                    double max = matrix.FindMaxUpperDiagonal();

                    MaxAndMinResult.Text = string.Format("Максимальное значение над диагональю : {0} \n Минимальное значение под диагональю: {1} ", max , min);
                }
                catch
                {
                    MessageBox.Show("Таблица заполнена неверно.");
                }
            }
            else
            {
                MessageBox.Show("Ошибка. Матрица должна быть квадратная, и не состоять из одного элемента.");
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavingAndReadingUtils myOpen = new SavingAndReadingUtils();

            OpenFileDialog openDialog = new OpenFileDialog();

            int maxLength = 0;
            if (openDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openDialog.FileName;
            string[] arr1 = new string[myOpen.ReadStrArrFromFile(filename).Length];
            arr1 = myOpen.ReadStrArrFromFile(filename);
            inputMatrixDGV.RowCount = 0;
            for (int n = 0; n < arr1.Length; n++)
            {
                try
                {
                    inputMatrixDGV.RowCount++;
                    var numbers = arr1[n].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (numbers.Length > maxLength)
                    {
                        maxLength = numbers.Length;
                    }
                    inputMatrixDGV.ColumnCount = maxLength;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        inputMatrixDGV.Rows[n].Cells[i].Value = numbers[i];
                    }
                }
                catch { }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SavingAndReadingUtils mySave = new SavingAndReadingUtils();

                SaveFileDialog saveDialog = new SaveFileDialog();

                if (saveDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                string filename = saveDialog.FileName;
                string[] arr = new string[inputMatrixDGV .RowCount];
                for (int i = 0; i < inputMatrixDGV.RowCount; i++)
                {
                    for (int k = 0; k < inputMatrixDGV.ColumnCount; k++)
                    {
                        arr[i] += inputMatrixDGV.Rows[i].Cells[k].Value.ToString() + " ";
                    }
                }
                mySave.WriteArrInFile(filename, arr);
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении матрицы");
            }
        }
    }
}