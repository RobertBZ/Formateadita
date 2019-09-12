using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regression
{
    public abstract class AbstractRegression
    {
        protected int Quantity;
        protected List<int> Result;

        protected AbstractRegression(int first, int second, int quantity)
        {
            Result = new List<int>();
            Result.Add(first);
            Result.Add(second);
            Quantity = quantity;            
        }

        public abstract void Init();

        public override string ToString()
        {
            var str = "";
            foreach (var item in Result)
            {
                str += string.Format("{0}, ", item);
            }
            return str;
        }
    }
}
