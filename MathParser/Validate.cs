using System.Linq;

namespace ScienceLibrary.MathParser
{
    /// <summary>
    /// Класс, содержащий в себе методы валидации для входной строки
    /// </summary>
    public static class Validate
    {
        /// <summary>
        /// Валидация полученной строки - проверка вложенности выражения
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static bool IsExpressionInBrackets(string expression)
        {
            if (string.IsNullOrEmpty(expression))
            {
                return false;
            }

            if (expression.First() != '(' || expression.Last() != ')')
                return false;

            int balance = -1;
            for (int i = 1; i < expression.Length; i++)
            {
                if (expression[i] == ')')
                    balance++;
                else if (expression[i] == '(')
                    balance--;

                if (balance == 0 && (i + 1) != expression.Length)
                    return false;
            }

            return balance == 0;
        }
        /// <summary>
        /// Валидация полученной строки - проверка балансировки скобок
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static bool IsBracketsAreBalanced(string expression)
        {
            int balance = 0;
            foreach (var c in expression)
            {
                if (c == '(')
                    balance--;
                else if (c == ')')
                    balance++;
            }
            return balance == 0;
        }
    }
}
