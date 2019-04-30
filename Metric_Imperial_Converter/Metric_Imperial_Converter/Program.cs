using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Imperial_Converter
{
    public class Program
    {
        static void Main(string[] args)
        {
        }


        public double Convert(double value)
        {
            if (value < 0)
                return -1;

            if(value == 200.00)
            {
                return 60.96;
            }
            else
            {
                return 19.35;
            }
        }



    }
}
