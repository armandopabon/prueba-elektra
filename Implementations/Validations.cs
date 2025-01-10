using PruebaElektra.Interfaces;

namespace PruebaElektra.Implementations
{
    public class Validations : IValidations
    {
        public int CalculateMax(int[] param)
        {
            int max = param[0];
            if (param.Length > 0)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    if (param[i] > max) max = param[i];
                }
            }
            return max;
        }

        public int CalculateMin(int[] param)
        {
            int min = param[0];
            if (param.Length > 0)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    if (param[i] < min) min = param[i];
                }
            }
            return min;
        }

        public bool ValidatePalindrome(string input)
        {
            string reverse = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
                reverse += input[i];

            return input == reverse ? true : false;
        }
    }
}
