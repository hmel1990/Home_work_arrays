using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_arrays
{
    internal class RomanianArray
    {
        private string[] romanNumbers = new string[4000];
        private string[] thousands = { "", "M", "MM", "MMM" };
        private string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        private string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        private string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        
        string ToRoman(int number)
        {
            if (number < 1 || number > 3999) throw new ArgumentException("Value must be in the range 1-3999", "number");
            return thousands[number / 1000] + hundreds[(number % 1000) / 100] + tens[(number % 100) / 10] + ones[number % 10];
        }
        public RomanianArray ()
        {
            for (int i = 1; i <= 3999; i++)
            {
                romanNumbers[i - 1] = ToRoman(i);
            }
        }

        public void Print ()
        {
            foreach (string roman in romanNumbers)
            {
                Console.Write(roman + "\t");
            }
        }
    }


}
