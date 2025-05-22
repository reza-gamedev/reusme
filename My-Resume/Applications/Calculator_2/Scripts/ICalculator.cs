using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface ICalculator
    {
        Double sum(Double number1, Double number2);
        Double minus(Double number1, Double number2);
        Double devide(Double number1, Double number2);
        Double multiple(Double number1, Double number2);
        Double remaining(Double number1, Double number2);
        int delete();


    }
}
