using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ListUtility
    {
        public List<int> List;
        public ListUtility(List<int> list)
        {
            List = list;
        }
        public static T StrToValue<T>(string str)
        {
            return (T)Convert.ChangeType(str, typeof(T));
        }
        public static List<T> StrToList<T>(string str)
        {
            try
            {
                return Array.ConvertAll(str.Split(
                     new char[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries),
                     (z) => StrToValue<T>(z)).ToList();
            }
            catch
            {
                return null;
            }
        }
        public void Process()
        {
            int IndMax = FirstIndexOf(List, FindMax(List));
            int IndMin = LastIndexOf(List, FindMin(List));
            if (IndMax > IndMin + 2)
            {
                SwapInList(List, IndMax - 1, IndMin + 1);
            }
            else if (IndMin > IndMax + 2)
            {
                SwapInList(List, IndMin - 1, IndMax + 1);
            }
        }
        public void SwapInList(List<int> list, int Ind1, int Ind2)
        {
            int n;
            while (Ind1 > Ind2)
            {
                n = list[Ind2]; 
                list[Ind2] = list[Ind1];
                list[Ind1] = n;
                Ind1--;
                Ind2++;
            }
        }
        public int FindMax(List<int> list)
        {
            int max = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
            }
            return max;
        }
        public int FindMin(List<int> list)
        {
            int min = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < min)
                {
                    min = list[i];
                }
            }
            return min;
        }
        public int FirstIndexOf(List<int> list, int value)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
        public int LastIndexOf(List<int> list, int value)
        {
            for (int k = list.Count - 1; k >= 0; k--)
            {
                if (list[k] == value)
                {
                    return k;
                }
            }
            return -1;
        }
    }

}
