using System;
using static System.Collections.Specialized.BitVector32;


namespace TMSLesson3Library
{
    public class SumOperator : IMathOperator
    {
        private float a, b;
        public  SumOperator(float[] args)
        {
            if (args.Length < 2) throw new ArgumentException("Ошибка количества аргументов");
            this.a = args[0];
            this.b = args[1];
        }

        public string Solve() => $"{a} + {b} = {a + b}";
    }

    public class SubtractionOperator : IMathOperator
    {
        private float a, b;
        public SubtractionOperator(float[] args)
        {
            if (args.Length < 2) throw new ArgumentException("Ошибка количества аргументов");
            this.a = args[0];
            this.b = args[1];
        }
        public string Solve() => $"{a} - {b} = {a - b}";
    }

    public class MultiplicationOperator : IMathOperator
    {
        private float a, b;
        public MultiplicationOperator(float[] args)
        {
            if (args.Length < 2) throw new ArgumentException("Ошибка количества аргументов");
            this.a = args[0];
            this.b = args[1];
        }
        public string Solve() => $"{a} * {b} = {a * b}";
    }

    public class DivisionOperator : IMathOperator
    {
        private float a, b;
        public DivisionOperator(float[] args)
        {
            if (args.Length < 2) throw new ArgumentException("Ошибка количества аргументов");
            this.a = args[0];
            this.b = args[1];
        }
        public string Solve() => $"{a} / {b} = {a / b}";
    }

    public class PercentageOperator : IMathOperator
    {
        private float a, b;
        public PercentageOperator(float[] args)
        {
            if (args.Length < 2) throw new ArgumentException("Ошибка количества аргументов");
            this.a = args[0];
            this.b = args[1];
        }
        public string Solve() => $"Число {a} составляет {a * 100 / b}% от числа {b}";
    }

    public class SqrtOperator : IMathOperator
    {
        private float a;
        public SqrtOperator(float[] args)
        {
            if (args.Length < 1) throw new ArgumentException("Ошибка количества аргументов");
            this.a = args[0];
        }

        public string Solve() => $"Корень квадратный числа {a} = {Math.Sqrt(a)}";
        }

}
