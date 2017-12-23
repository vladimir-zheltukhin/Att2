using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BL
{
    public class StringUtility2
    {
        public string Str1 { get; set; }
        public string Str2 { get; set; }
        public StringUtility2(string str1, string str2)
        {
            Str1 = str1;
            Str2 = str2;
        }
        public string NearestSumOfTwoNumbers()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            int I = 0;
            int K = 1;
            double Z;
            string ErrorMessage = "В строке содержатся недопустимые символы";
            try
            {
                Z = Convert.ToDouble(Str2);
            }
            catch
            {
                return ErrorMessage;
            }
            var words = Str1.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
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
            double Difference = Math.Abs(arr[0] + arr[1] - Z); // Первоначальная разница
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (Math.Abs(arr[i] + arr[k] - Z) < Difference)
                    {
                        Difference = Math.Abs(arr[i] + arr[k] - Z);
                        I = i;
                        K = k;
                    }
                }
            }
            string NewStr = string.Format("Элемент {0} со значением {1} и элемент {2} со значением {3} в сумме наиболее близки к числу {4}", I, arr[I], K, arr[K], Z);
            return NewStr;
        }
    }

}
