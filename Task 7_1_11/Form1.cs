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

/*11. Дано вещественное число R и массив размера N.Найти два элемента массива,
                              сумма которых наименее близка к данному числу.
                              */
namespace Task_7_1_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FindNumbers_Click(object sender, EventArgs e)
        {
            var str = new StringUtility2(InputStr1.Text,InputStr2.Text);
            result.Text = str.NearestSumOfTwoNumbers();
        }
        private void InputStr2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
