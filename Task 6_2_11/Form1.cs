using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

// 42.   1/(1+x) = 1 - x + x^2 - x^3 + x^4 - ...

namespace Task_6_2_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            try
            {
                CountMath sequence = new CountMath();
            sequence.e = Convert.ToDouble(inputE.Text);
            sequence.x = Convert.ToDouble(inputX.Text);
            result.Text = String.Format("Для данной функции при X = {0} и E = {1} :\n Количество элементов, больших чем Е = {2} \n Сумма элементов, больших чем E равна {3} \n Количество элементов, больших чем Е/10 = {4} \n Сумма элементов больших, чем Е/10 = {5} \n Значения функции слева = {6} .",
                    inputX.Text, inputE.Text, sequence.QuanitityOfMembersMoreThanE(), sequence.SumOfMembersMoreThanE(), sequence.QuanitityOfMembersMoreThanEDivide10(), sequence.SumOfMembersMoreThanEDivide10(), sequence.ValueLeftSide());
            }
            catch
            {
                result.Text = "Неверный формат данных";
            }
        }
    }
}
