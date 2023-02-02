using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskHotels
{
    public class Task1
    {
        private string[] cities;
        public Task1(string[] cities)
        {
            this.cities = cities;
        }
        public string GetFormattedString()
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < cities.Length - 1; i++)
            {
                sb.Append(cities[i]);
                sb.Append(", ");
            }
            sb.Append(cities[cities.Length-1]);
            sb.Append(".");
            return sb.ToString();
        }
    }
}
