using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskHotels
{
    public class Task4
    {
        private int num;
        public Task4(int num)
        {
            this.num = num;
        }
        public bool IsPrime()
        {
            num = Math.Abs(num);
            if (num>=0 && num <=3)
                return true;
            for(int i = 2; i < num; i++) //not optimized
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
