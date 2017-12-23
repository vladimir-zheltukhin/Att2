using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_7_2_11
{ 
    /*
    42. Вводится массив целых чисел.Посчитать количество элементов массива,
    больших или равных среднему арифметическому элементов массива,
    отличных от минимального (если все элементы массива одинаковые, то ответ – 0). */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetQuantity_Click(object sender, EventArgs e)
        {
            var str = new StringUtility1(inputArr.Text);
            result.Text = str.QuantityOfMembersMoreThanAverage();
        }
    }
}
