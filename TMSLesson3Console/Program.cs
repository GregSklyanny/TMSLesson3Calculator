using TMSLesson3Library;

namespace TMSLesson3Console
{
    internal class Program
    {

        static void Main(string[] args)
        {
            CalculatorLauncher calculatorLauncher = new CalculatorLauncher(new Calculator());
            calculatorLauncher.Launch();

            
        }
    }
}
