using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMSLesson3Library
{
    public class CalculatorLauncher
    {
        private ICalculator _calculator;
        private bool flag = true;
        public CalculatorLauncher(ICalculator calculator)
        {
            _calculator = calculator;
        }
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
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (action)
                    {
                        case "+":
                            Console.WriteLine("Введите второе число");
                            Console.ForegroundColor = ConsoleColor.White;
                            b = InputValidator.FloatValidator(Console.ReadLine());
                            InputValidator.ExpressionValidator(a, b, action);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"{a} + {b} = {_calculator.Sum(a, b)}");
                            break;
                        case "-":
                            Console.WriteLine("Введите второе число");
                            Console.ForegroundColor = ConsoleColor.White;
                            b = InputValidator.FloatValidator(Console.ReadLine());
                            InputValidator.ExpressionValidator(a, b, action);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"{a} - {b} = {_calculator.Subtraction(a, b)}");
                            break;
                        case "*":
                            Console.WriteLine("На какое число вы хотите умножить?");
                            Console.ForegroundColor = ConsoleColor.White;
                            b = InputValidator.FloatValidator(Console.ReadLine());
                            InputValidator.ExpressionValidator(a, b, action);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"{a} * {b} = {_calculator.Multiplication(a, b)}");
                            break;
                        case "/":
                            Console.WriteLine("На какое число вы хотите поделить?");
                            Console.ForegroundColor = ConsoleColor.White;
                            b = InputValidator.FloatValidator(Console.ReadLine());
                            InputValidator.ExpressionValidator(a, b, action);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"{a} / {b} = {_calculator.Division(a, b)}");
                            break;
                        case "%":
                            Console.WriteLine("Процент от какого числа вы хотите узнать?");
                            Console.ForegroundColor = ConsoleColor.White;
                            b = InputValidator.FloatValidator(Console.ReadLine());
                            InputValidator.ExpressionValidator(a, b, action);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"Число {a} составляет {_calculator.Percentage(a, b)}% от числа {b}");
                            break;
                        case "sqrt":
                            InputValidator.ExpressionValidator(a, action);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"Корень квадратный числа {a} = { _calculator.Sqrt(a)}");
                            break;


                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.ForegroundColor = ConsoleColor.White;
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
