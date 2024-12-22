using System;
using System.Linq;

namespace StringHelperLibrary
{
    /// <summary>
    /// Предоставляет методы для работы со строками.
    /// </summary>
    public static class StringHelper
    {
        /// <summary>
        /// Возвращает перевернутую строку.
        /// </summary>
        /// <param name="str">Входная строка.</param>
        /// <returns>Перевернутая строка.</returns>
        /// <exception cref="ArgumentNullException">Выбрасывается, если str равно null.</exception>
        public static string ReverseString(string str)
        {
            if (str == null)
                throw new ArgumentNullException(nameof(str));
            return new string(str.Reverse().ToArray());
        }

        /// <summary>
        /// Возвращает количество слов в строке.
        /// </summary>
        /// <param name="str">Входная строка.</param>
        /// <returns>Количество слов в строке.</returns>
        /// <exception cref="ArgumentNullException">Выбрасывается, если str равно null.</exception>
        public static int CountWords(string str)
        {
            if (str == null)
                throw new ArgumentNullException(nameof(str));
            return str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        /// <summary>
        /// Проверяет, является ли строка палиндромом.
        /// </summary>
        /// <param name="str">Входная строка.</param>
        /// <returns>True, если строка является палиндромом; иначе false.</returns>
        /// <exception cref="ArgumentNullException">Выбрасывается, если str равно null.</exception>
        public static bool IsPalindrome(string str)
        {
            if (str == null)
                throw new ArgumentNullException(nameof(str));
            string processed = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
            return processed.SequenceEqual(processed.Reverse());
        }

        /// <summary>
        /// Возвращает строку с заглавной первой буквой.
        /// </summary>
        /// <param name="str">Входная строка.</param>
        /// <returns>Строка с заглавной первой буквой.</returns>
        /// <exception cref="ArgumentNullException">Выбрасывается, если str равно null.</exception>
        public static string CapitalizeFirstLetter(string str)
        {
            if (str == null)
                throw new ArgumentNullException(nameof(str));
            if (str.Length == 0)
                return string.Empty;
            return char.ToUpper(str[0]) + str.Substring(1);
        }
    }
}
