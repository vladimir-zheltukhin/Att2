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

namespace Task_8_1_11
{
    /* 11. (*) Перевернуть числа в списке между первым максимальным элементом списка и последним минимальным,
     *  слева направо, например:

{ 2, 11, 8, 11, 2, 3, 2, 2, 6, 7, 2, 3, 5, 10 } → { 2, 11, 7, 6, 2, 2, 3, 2, 11, 8, 2, 3, 5, 10 }

Реализовать в виде функции:

public void Process(IList<int> list)

Дополнительный список или массив не заводить. Для удобства реализовать дополнительные функции:

public int FindMax(IList<int> list) 
public int FindMin(IList<int> list) 
public int FirstIndexOf(IList<int> list, int value) 
public int LastIndexOf(IList<int> list, int value) ,

которые использовать в реализации функции Process.
*/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startReverse_Click(object sender, EventArgs e)
        {
            try
            {
                ListUtility list = new ListUtility(ListUtility.StrToList<int>(inputList.Text));
                list.Process();
                resultList.Text = null;
                for (int i = 0; i < list.List.Count; i++)
                {
                    resultList.Text += list.List[i].ToString() + " ";
                }
            }
            catch
            {
                resultList.Text = "Ошибка";
            }
        }
    }
}
