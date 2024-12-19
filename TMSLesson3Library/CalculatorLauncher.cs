using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TMSLesson3Library
{
    public class CalculatorLauncher
    {
        private IMathOperator _mathOperator;
        private bool flag = true;
        
        public void SetOperator(IMathOperator mathOperator) => _mathOperator = mathOperator;
        public void Launch()
        {
            while (flag)
            {
                float a, b;

                try
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите число");
                    Console.ForegroundColor = ConsoleColor.White;
                    a = InputValidator.FloatValidator(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("+ - сложение");
                    Console.WriteLine("- - вычитание");
                    Console.WriteLine("/ - деление");
                    Console.WriteLine("* - умножение");
                    Console.WriteLine("% - процент от числа");
                    Console.WriteLine("sqrt - квадратный корень числа");
                    Console.WriteLine("Введите знак действия: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    string action = InputValidator.ActionValidator(Console.ReadLine());
                    
                    switch (action)
                    {
                        case "+":
                            SetOperator(new Sum(a));
                            break;
                        case "-":
                            SetOperator(new Subtraction(a));
                            break;
                        case "*":
                            SetOperator(new Multiplication(a));
                            break;
                        case "/":
                            SetOperator(new Division(a));
                            break;
                        case "%":
                            SetOperator(new Percentage(a));
                            break;
                        case "sqrt":
                            SetOperator(new Sqrt(a));
                            break;
                    }
                    _mathOperator.Solve();
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                flag = IsNeedRestart();
            }
        }
        public static bool IsNeedRestart()
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
