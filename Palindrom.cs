using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Home_work_arrays
{
    internal class Palindrome
    {
        private string originalText;
        private string processedText;
      
        
        // Метод для обработки строки (удаление пробелов, знаков препинания и приведение к нижнему регистру)
        private string ProcessText(string text)
        {
            text = text.Replace(" ", "");
            text = text.ToLower();
            foreach (char c in text)
            {
                if (char.IsPunctuation(c))
                {
                    text = text.Replace(c.ToString(), "");
                }
            }
            return text;
        }

        public Palindrome(string text)
        {
            originalText = text;
            processedText = ProcessText(text);
        }

        // Метод для проверки, является ли строка палиндромом
        public bool IsPalindrome()
        {
            int length = processedText.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (processedText[i] != processedText[length - 1 - i])
                {
                    Console.WriteLine("строка не палиндром");
                    return false;
                }
            }
            Console.WriteLine("строка палиндром");
            return true;
        }  
    }
}

    
   
