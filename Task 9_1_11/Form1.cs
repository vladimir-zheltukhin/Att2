using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BL;
using Utils;
/*
11. Создать новый двумерный массив, исключив из переданного двумерного массива строки и столбцы,
    состоящие из одинаковых элементов(т.е.строка, состоящая, предположим, из одних единиц,
        не должна попасть в новый двумерный массив).
*/

namespace Task_9_1_11
{
    public partial class Form1 : Form
    {
        Array2Utility arr = new Array2Utility();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewUtils.InitGridForArr(dataGridViewInput , 35, false, false, false, true, true);
            DataGridViewUtils.InitGridForArr(dataGridViewResult, 35, true, false, false, false, false);
        }
        private void deleteAllRepeatsInRowsAndColomn_Click(object sender, EventArgs e)
        { 
            try
            {
                arr.ArrayStr = DataGridViewUtils.GridToArray2<string>(dataGridViewInput);

                List<List<string>> output = new List<List<string>>();

                output = arr.DeleteAllSameLines();

                dataGridViewResult.ColumnCount = output[0].Count;
                dataGridViewResult.RowCount = output.Count;
                for (int i = 0; i < dataGridViewResult.RowCount; i++)
                {
                    for (int k = 0; k < dataGridViewResult.ColumnCount; k++)
                    {
                        dataGridViewResult.Rows[i].Cells[k].Value = output[i][k];
                    }
                }
            }
            catch
            {
                MessageBox.Show("Матрица пустая");
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
            dataGridViewInput.RowCount = 0;
            for (int n = 0; n < arr1.Length; n++)
            {
                try
                {
                    dataGridViewInput.RowCount++;
                    var numbers = arr1[n].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (numbers.Length > maxLength)
                    {
                        maxLength = numbers.Length;
                    }
                    dataGridViewInput.ColumnCount = maxLength;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        dataGridViewInput.Rows[n].Cells[i].Value = numbers[i];
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
                string[] arr = new string[dataGridViewInput.RowCount];
                for (int i = 0; i < dataGridViewInput.RowCount; i++)
                {
                    for (int k = 0; k < dataGridViewInput.ColumnCount; k++)
                    {
                        arr[i] += dataGridViewInput.Rows[i].Cells[k].Value.ToString() + " ";
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
