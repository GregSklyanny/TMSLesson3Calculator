using System;
using static System.Collections.Specialized.BitVector32;


namespace TMSLesson3Library
{
    public class Sum : IMathOperator
    {
        private float a, b;
        public Sum(float a)
        {
            this.a = a;
        }
        public void Solve()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите второе число");
            Console.ForegroundColor = ConsoleColor.White;
            b = InputValidator.FloatValidator(Console.ReadLine());
            InputValidator.ExpressionValidator(a, b, "+");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{a} + {b} = {a+b}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public class Subtraction : IMathOperator
    {
        private float a, b;
        public Subtraction(float a)
        {
            this.a = a;
        }
        public void Solve()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите второе число");
            Console.ForegroundColor = ConsoleColor.White;
            b = InputValidator.FloatValidator(Console.ReadLine());
            InputValidator.ExpressionValidator(a, b, "-");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public class Multiplication : IMathOperator
    {
        private float a, b;
        public Multiplication(float a)
        {
            this.a = a;
        }
        public void Solve()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("На какое число вы хотите умножить?");
            Console.ForegroundColor = ConsoleColor.White;
            b = InputValidator.FloatValidator(Console.ReadLine());
            InputValidator.ExpressionValidator(a, b, "*");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{a} * {b} = {a*b}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public class Division : IMathOperator
    {
        private float a, b;
        public Division(float a)
        {
            this.a = a;
        }
        public void Solve()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("На какое число вы хотите поделить?");
            Console.ForegroundColor = ConsoleColor.White;
            b = InputValidator.FloatValidator(Console.ReadLine());
            InputValidator.ExpressionValidator(a, b, "/");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public class Percentage : IMathOperator
    {
        private float a, b;
        public Percentage(float a)
        {
            this.a = a;
        }
        public void Solve()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Процент от какого числа вы хотите узнать?");
            Console.ForegroundColor = ConsoleColor.White;
            b = InputValidator.FloatValidator(Console.ReadLine());
            InputValidator.ExpressionValidator(a, b, "%");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Число {a} составляет {a*100/b}% от числа {b}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public class Sqrt : IMathOperator
    {
        private float a;
        public Sqrt(float a)
        {
            this.a = a;
        }

        public void Solve()
        {
            InputValidator.ExpressionValidator(a, "sqrt");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Корень квадратный числа {a} = {Math.Sqrt(a)}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

}
