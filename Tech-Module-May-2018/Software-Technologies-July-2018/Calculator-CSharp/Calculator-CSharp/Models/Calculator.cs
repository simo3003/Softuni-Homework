using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator_CSharp.Models
{
    public class Calculator
    {
        public double LeftOperand { get; set; }
        public string Operator { get; set; }
        public double RightOperand { get; set; }
        public double Result { get; set; }

        public Calculator()
        {
            this.Result = 0;
        }

        public void CalculateResult()
        {
            switch (this.Operator)
            {
                case "+":
                    this.Result = this.LeftOperand + this.RightOperand;
                    break;
                case "-":
                    this.Result = this.LeftOperand - this.RightOperand;
                    break;
                case "*":
                    this.Result = this.LeftOperand * this.RightOperand;
                    break;
                case "/":
                    this.Result = this.LeftOperand / this.RightOperand;
                    break;
                case "^":
                    this.Result = Math.Pow(this.LeftOperand, this.RightOperand);
                    break;
                default:
                    this.Result = 0;
                    break;
            }
        }
    }
}
