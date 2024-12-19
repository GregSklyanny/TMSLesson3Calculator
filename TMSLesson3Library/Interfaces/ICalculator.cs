using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMSLesson3Library
{
    public interface ICalculator
    {
        float Sum(float a, float b);
        float Subtraction(float a, float b);
        float Division(float a, float b);
        float Multiplication(float a, float b);
        float Sqrt(float a);
        float Percentage (float a, float b);
        
    }
}
