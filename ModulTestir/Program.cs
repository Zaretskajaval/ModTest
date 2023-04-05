using System;

namespace ModulTestir
{
    public class Program
    {
       public static void Main(string[] args)
        {
            try
            {
                Formula formula = new Formula();
            Console.WriteLine("x = ");
            double x = double.Parse(Console.ReadLine());// 2;
            Console.WriteLine("a = ");
            double a = double.Parse(Console.ReadLine());//1;
            Console.WriteLine("c = ");
            double c = double.Parse(Console.ReadLine());//-2;
            double result = formula.Condition(x, a, c);
            Console.WriteLine("Ответ: "+result); // выведет -4
            }
            catch (System.FormatException)
            {

                return;
            }
            
            Console.ReadKey();
        }
    }
}
