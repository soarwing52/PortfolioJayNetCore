using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioJay.Core
{
    public class BaseCalculation
    {

        public int ArrayPlus(int[] intArray)
        {
            int answer = 0;
            foreach (int item in intArray)
            {
                answer += item;
            }

            return answer;
        }

        public static string getTest()
        {
            return "test123";
        }
    }
}
