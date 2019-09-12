using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regression
{
    public class Fibonnacci : AbstractRegression
    {
        public Fibonnacci(int first, int second, int quantity) 
            : base(first, second, quantity)
        { }

        public override void Init()
        {            
            for (int index = 2; index < Quantity; index++)
            {
                Result
                    .Add(Result[Result.Count - 1] + Result[Result.Count - 2]);
            }
        }
    }
}
