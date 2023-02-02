using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskHotels
{
    public class Task2
    {
        private double number;
        public Task2(double number)
        {
            this.number = number;
        }

        public int GetRoundedNumber()
        {
            int min = (int)number / 5 * 5;
            int max = (int)number / 5 * 5 + 5;
            return Math.Abs(number - max) > Math.Abs(number - min) ? min : max;
        }
    }
}
