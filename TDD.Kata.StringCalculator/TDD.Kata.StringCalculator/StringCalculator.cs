using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Kata.StringCalculator
{
    public class StringCalculator
    {
        public int Add(string parameter)
        {
            var result = 0;

            if (string.IsNullOrEmpty(parameter))
                return result;

            var numbers = parameter.Split(',');

            if (numbers.Count() == 1)
                result = Convert.ToInt32(numbers[0]);
            else
                result = Convert.ToInt32(numbers[0]) + Convert.ToInt32(numbers[1]);


            return Convert.ToInt32(result);
        }
    }
}
