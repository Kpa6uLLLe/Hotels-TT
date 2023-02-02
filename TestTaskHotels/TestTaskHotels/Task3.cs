using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskHotels
{
    public class Task3
    {
        private int amount;
        private string baseString = "компьютер";
        public Task3(int amount)
        {
            this.amount = amount;
        }

        public string GetFormattedString()
        {
            int ending = amount % 10;
            StringBuilder sb = new StringBuilder();
            sb.Append(amount).Append(" ");
            if(ending == 1)
            {
                return sb.Append(baseString).ToString();
            }
            else if(ending > 1 && ending < 5)
            {
                return sb.Append(baseString).Append("а").ToString();
            }
            else
            {
                return sb.Append(baseString).Append("ов").ToString();
            }
        }
    }
}
