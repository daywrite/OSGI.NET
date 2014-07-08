using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.DemoOne
{
    public class Calculator : ICalculate
    {
        public string Calculate(string expression)
        {
            try
            {
                return (new DataTable()).Compute(expression, null).ToString();
            }
            catch
            {
                return string.Format("Expression {0} cannot be calculated as expected.", expression);
            }
        }
    }
}
