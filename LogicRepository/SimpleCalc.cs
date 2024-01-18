using System.Text.RegularExpressions;
using System;
using Microsoft.AspNetCore.Mvc;

namespace WebCalc.LogicRepository
{
    public static class SimpleCalc
    {
        
        public static CalcResult Division(double a, double b)
        {
            if (b == 0)
            {
                return new CalcResult(false, "на ноль делить нельзя");
            }
            return new CalcResult(true, (a/b).ToString()); ;
        }
        public static CalcResult Sum(double a, double b)
        {
            return new CalcResult(true, (a + b).ToString()); ;
        }
        public static CalcResult Subtraction(double a, double b)
        {
            return new CalcResult(true, (a + b).ToString()); 
        }
        public static CalcResult Multiplication(double a, double b)
        {
            return new CalcResult(true, (a * b).ToString()); 
        }
        public static CalcResult Pow(double a, double b)
        {
            var result = Math.Pow(a, b);
            if (double.IsNaN(result))
            {
                return new CalcResult(false, "Нарушение правил возведения в степень");
            }
            return new CalcResult(true, result.ToString());

        }
        public static CalcResult Root(double a, double b)
        {
            if (b == 0)
            {
                return new CalcResult(false, "b  не может быть равно нулю");
            }
            var result = Math.Pow(a, 1/b);
            if (double.IsNaN(result))
            {
                return new CalcResult(false, "Нарушение правил извлечение корня");
            }
            return new CalcResult(true, result.ToString());
        }


    }
}
