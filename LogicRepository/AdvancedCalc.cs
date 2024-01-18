using Microsoft.AspNetCore.Mvc;
using org.mariuszgromada.math.mxparser;

namespace WebCalc.LogicRepository
{
    public static class AdvancedCalc
    {
        public static CalcResult CalcExpression(string a)
        {
            var ex = new Expression(a);
            if (!ex.checkSyntax())
            {
                return new CalcResult(false, "Ошибка синтаксиса");
            }
            var result = ex.calculate();
            if (double.IsNaN(result))
            {
                return new CalcResult(false, "ошибка вычисления");
            }
            return new CalcResult(true, result.ToString());
        }
    }
}
