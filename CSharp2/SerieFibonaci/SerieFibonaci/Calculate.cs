using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieFibonaci
{
    class Calculate
    {
        public int NumberCalculte { get; set; }
        public int AuxNumber { get; set; }
        public int Result { get; set; }
        public Calculate()
        {
            NumberCalculte=1;
            AuxNumber=0;
            Result=0;
        }
        public virtual void Calculator(int NumberCant)
        {
            for (int i = 0; i < NumberCant; i++)
            {
                AuxNumber = Result;
                Result = NumberCalculte;
                NumberCalculte = AuxNumber + Result;
                Console.Write(Result+ " ");
            }
        }
    }
}
