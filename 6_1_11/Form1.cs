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

/*
 * 11. Дана строка, содержащая полное имя файла, то есть имя диска, список каталогов (путь),
 *  собственно имя и расширение. Выделить из этой строки имя1|расширение2 файла.
 */
namespace _6_1_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetFileName_Click(object sender, EventArgs e)
        {
            var str = new StringUtility1(inputStr.Text);
            result.Text = str.NameOfFile();
        }

        private void GetFileExtension_Click(object sender, EventArgs e)
        {
            var str = new StringUtility1(inputStr.Text);
            result.Text = str.FileExtension();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
