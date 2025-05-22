using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Mycalculator : ICalculator
    {
        public int delete()
        {
            return 0;
        }

        public Double devide(Double number1, Double number2)
        {
            return number1 / number2;
        }

        public Double minus(Double number1, Double number2)
        {
            return number1 - number2;
        }

        public Double multiple(Double number1, Double number2)
        {
            return number1 * number2;
        }

        public Double remaining(Double number1, Double number2)
        {
            return number1 % number2;
        }

        public Double sum(Double number1, Double number2)
        {
            return number1 + number2;
        }
    }
}
