using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{

    public class Calc
    {
        public int? FirstNumber { get; set; }
        public int? SecondNumber { get; set; }
        private char? action;

        public char? Action
        {
            get { return action; }
            set
            {
                if (value == '-' || value == '+' || value == '/' || value == '*')
                    action = value;
                else
                    throw new Exception("Impossible Action");
            }
        }

        
        public double GetResult()
        {
            if (action.HasValue)
                throw new Exception("no action assigned");

            if (this.FirstNumber.HasValue == false || this.SecondNumber.HasValue == false)
                throw new Exception("not all fields are initialized");

            switch (this.Action)
            {
                case '+':
                    return this.FirstNumber.Value + this.SecondNumber.Value;
                case '-':
                    return this.FirstNumber.Value - this.SecondNumber.Value;
                case '*':
                    return this.FirstNumber.Value * this.SecondNumber.Value;
                case '/':
                    return this.FirstNumber.Value / this.SecondNumber.Value;
                default:
                    throw new Exception("no action assigned");
            }
        }
    }
}
        
    
