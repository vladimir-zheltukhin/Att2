using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CountMath
    {
        public double e { get; set; }
        public double x { get; set; }
        private double Member(int N) // N-ый член последовательности
        {
            double member = Math.Pow((-1) * x, N - 1);
            return member;
        }
        public int QuanitityOfMembersMoreThanE() // количество элементов больше E
        {
            int Quan = 0;
            int i = 1;
            while (Math.Abs(Member(i)) > e)
            {
                Quan++;
                i++;
            }
            return Quan;
        }
        public int QuanitityOfMembersMoreThanEDivide10() // количество элементов больше E
        {
            int Quan = 0;
            int i = 1;
            while (Math.Abs(Member(i)) > e / 10 )
            {
                Quan++;
                i++;
            }
            return Quan;
        }
        public double SumOfMembersMoreThanE() // Сумма элементов больше E
        {
            double Sum = 0;
            int i = 1;
            while (Math.Abs(Member(i)) > e)
            {
                Sum += Member(i);
                i++;
            }
            return Sum;
        }
        public double SumOfMembersMoreThanEDivide10() // количество элементов больше E/10
        {
            {
                double Sum = 0;
                int i = 1;
                while (Math.Abs(Member(i)) > e / 10)
                {
                    Sum += Member(i);
                    i++;
                }
                return Sum;
            }
        }
        public double ValueLeftSide() // значение функции слева
        {
            return (1 / (1 + x) / (1 + x) );
        } 
    }
}
