using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskHotels
{
    public class Task6
    {
        private int limit;

        public Task6(int limit)
        {
            this.limit = limit;
        }


        public string GetMultiplicationSquare()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("  ");
            int spaces = GetExtraSpacesNeeded(1, limit);
            for(int i = 0; i < spaces; i++)
            {
                sb.Append(" ");
            }
            sb.Append(GetStringMultiplied(limit, 1));
            for (int i = 1; i <= limit; i++)
            {
                int extraSpaces = GetExtraSpacesNeeded(i, limit);
                for (int j = 0; j < extraSpaces; j++)
                {
                    sb.Append(" ");
                }
                sb.Append(i).Append(" ");
                sb.Append(GetStringMultiplied(limit, i));
            }
            return sb.ToString();
        }

        private string GetStringMultiplied(int limit, int ratio)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 1;i <= limit; i++)
            {
                int spaces = GetExtraSpacesNeeded(i * ratio, limit * i);
                for (int j = 0; j < spaces; j++)
                    sb.Append(" ");
                sb.Append(i*ratio).Append(" ");
                
            }
            sb.Append("\n");
            return sb.ToString();
        }
        private int GetExtraSpacesNeeded(int current, int max)
        {
            return GetDigitsInNumber(max) - GetDigitsInNumber(current);
        }

        private int GetDigitsInNumber(int number)
        {
            int digits = 1;
            for(int i = number; i > 0; i /= 10)
            {
                if(i /10 != 0)
                {
                    digits++;
                }
            }
            return digits;
        }
    }
}
