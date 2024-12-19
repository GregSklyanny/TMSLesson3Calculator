namespace TMSLesson3Library
{
    public class Calculator : ICalculator
    {


        public float Division(float a, float b) => a / b;

        public float Multiplication(float a, float b) => a * b;
        
        public float Percentage(float a, float b) => (a / b) * 100;
        
        public float Sqrt(float a) => (float) Math.Sqrt(a);
        
        public float Subtraction(float a, float b) => a - b;

        public float Sum(float a, float b) => a + b;
        
    }
}
