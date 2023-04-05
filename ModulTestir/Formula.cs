using System;
using System.Collections.Generic;
using System.Text;

namespace ModulTestir
{
    public class Formula
    {
       public double Condition(double x, double a, double c)
        {
            if (c < 0 && a != 0) // первый случай
            {
                return -a *( x * x);
            }
            else if (c > 0 && a == 0) // второй случай
            {
                return (a - x) / (c * x);
            }
            else // третий случай
            {
                return -x / (c - a * x);
            }
        }
    }
}
