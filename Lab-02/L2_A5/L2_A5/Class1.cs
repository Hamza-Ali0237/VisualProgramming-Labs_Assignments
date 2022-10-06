using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_A5
{
    internal class MathClass
    {
        string op;
        int firstValue;
        int secondValue;

        public void setOperator(string op)
        {
            this.op = op;
        }

        public string getOperator()
        {
            return this.op;
        }

        public void setFirstValue(int firstValue)
        {
            this.firstValue = firstValue;
        }

        public int getFirstValue()
        {
            return this.firstValue;
        }

        public void setSecondValue(int secondValue)
        {
            this.secondValue = secondValue;
        }

        public int getSecondValue()
        {
            return this.secondValue;
        }
    }

    
}
