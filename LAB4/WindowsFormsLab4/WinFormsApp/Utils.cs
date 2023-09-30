namespace WinFormsApp
{
    /// <summary>
    /// Класс проверок вводимого числа.
    /// </summary>
    internal class Utils
    {
        /// <summary>
        /// Метод позволяющий вводить только
        /// числа, запятые и точки.
        /// Использование BackSpace.
        /// </summary>
        /// <param name="e">События.</param>
        public static void CheckInput(KeyPressEventArgs e)
        {
            const int backSpace = 8;

            char number = e.KeyChar;
            if ((e.KeyChar < '0' || e.KeyChar > '9')
                && number != backSpace
                && number != ','
                && number != '.')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Преобразование числа в double.
        /// </summary>
        /// <param name="number">Строка.</param>
        /// <returns>Проверенное значение.</returns>
        public static double CheckNumber(string number)
        {
            if (number.Contains('.'))
            {
                number = number.Replace('.', ',');
            }

            return double.Parse(number);
        }

        /// <summary>
        /// Преобразование числа в int.
        /// </summary>
        /// <param name="number">Строка.</param>
        /// <returns>Проверенное значение.</returns>
        public static int CheckWholeNumber(string number)
        {
            return int.Parse(number);
        }

        /// <summary>
        /// Проверка типа плавания.
        /// </summary>
        /// <param name="text">Строка.</param>
        /// <returns>Проверенное значение.</returns>
        public static string CheckTypeOfSwimming(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException("Не выбран тип плавнаия");
            }

            return text;
        }
    }
}
