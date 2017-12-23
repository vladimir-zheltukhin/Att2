using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BL
{
    public class StringUtility1
    {
        public string Str { get; set; }
        public StringUtility1(string str)
        {
            Str = str;
        }
        public string ErrorMessage = "Введены неверные данные" ;
        public bool ConditionsOfError() // // для 6_1_11
        {
            return (Str.LastIndexOf("\\") < 0 || (Str.LastIndexOf(".") < 0) || (Str.LastIndexOf(" ") >= 0) ||
                (Str.LastIndexOf(":\\") < 0) || ((Str.LastIndexOf(".") - Str.LastIndexOf("\\") <= 1)) || (Str.LastIndexOf(":\\") != 1));
        }
        public string NameOfFile() // для 6_1_11
        {
            if (ConditionsOfError())
            {
                return ErrorMessage;
            }
            string NewStr = Str.Remove(0, Str.LastIndexOf("\\") + 1);
            NewStr = NewStr.Remove(NewStr.LastIndexOf("."), NewStr.Length - NewStr.LastIndexOf("."));
            return NewStr;
        }
        public string FileExtension() // для 6_1_11
        {
            if (ConditionsOfError())
            {
                return ErrorMessage;
            }
            string NewStr = Str.Remove(0, Str.LastIndexOf(".") + 1);
            return NewStr;
        }
        public string QuantityOfMembersMoreThanAverage()
        {
            double Summ = 0;
            int N = 0; // Количество членов больше среднего арифметического;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string ErrorMessage = "В строке содержатся недопустимые символы";
            var words = Str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double[] arr = new double[words.Length];
            for (int n = 0; n < words.Length; n++)
            {
                try
                {
                    arr[n] = Convert.ToDouble(words[n]);
                }
                catch
                {
                    return ErrorMessage;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Summ += arr[i];
            }
            double Sr = Summ / arr.Length; // Среднее арифметическое
            for (int k = 0; k < arr.Length; k++)
            {
                if (arr[k] > Sr)
                {
                    N = N + 1;
                }
            }
            return String.Format("Количество элементов больше среднего арифметического N = {0}", N);
        }
    }
}
