using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMSLesson3Library
{
    public class InputValidator
    {
        static public float FloatValidator(string a)
        {
            float output;
            
            if(float.TryParse(a.Trim().Replace(',','.'), out output))
            {
                return output;
            }

            throw new Exception("это не число"); 
        }
        static public string ActionValidator(string a)
        {
            string output = a.Trim().ToLower();
            List<string> validActions = new List<string>()
            {
                "+",
                "-",
                "/",
                "*",
                "%",
                "sqrt"
            };

            if (validActions.Contains(output))
            {
                return output;
            }

            throw new Exception("Действие введено неверно!");
        }

        // Блок валидации выражения, 2 перегрузки - для унарных и бинарных операций
        static public void ExpressionValidator(float a, float b, string action)
        {
            switch (action)
            {
                case "%":
                    if (a < 0 || b < 0) throw new Exception("Отрицательные числа!");
                    if (b == 0) throw new Exception("Второе число = 0! Деление на ноль!");
                    break;
                case "/":
                    if(b == 0) throw new Exception("Деление на ноль!");
                    break;
            }
        }

        static public void ExpressionValidator(float a, string action)
        {
            switch (action)
            {
                case "sqrt":
                    if (a < 0) throw new Exception("Отрицательное число под корнем, зачем вам комплексное число? ;)");
                    break;
           }
        }

        static public bool IsNeedRestart()
        {
            string str = string.Empty;
            ConsoleKey consoleKey;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Начать заново? y - начать заново, n - выйти из программы");
            Console.ForegroundColor = ConsoleColor.White;
            while (true)
            {
                consoleKey = Console.ReadKey().Key;
                if (consoleKey == ConsoleKey.Y) return true;
                if (consoleKey == ConsoleKey.N) return false;
            }
            return false;
        }
    }
}
