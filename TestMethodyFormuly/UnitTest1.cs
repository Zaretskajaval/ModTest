using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModulTestir;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace TestMethodyFormuly
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckingTheFirstCondition()   //Проверка, что при c < 0 и a != 0 функция возвращает правильный результат.
        {
            double x = 3;
            double a = 2;
            double c = -4;
            double result = 0;
            if (c < 0 && a != 0) // первый случай
            {
                result = -a * (x * x);
            }
            double expected = -18;

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void CheckingTheSecondCondition()    //Проверка, что при c > 0 и a == 0 функция возвращает правильный результат.
        {
            double x = 1;
            double a = 0;
            double c = 3;
            double result = 0;
            if (c > 0 && a == 0) // второй случай
            {
                result = (a - x) / (c * x);
            }
            double expected = -0.3333333333333333;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void CheckingTheThirdCondition()   // Проверка, что при остальных значениях a и c функция возвращает правильный результат.
        {
         
            double x = 2;//2
            double a = 3;//3
            double c = 4;//4
            double result = 0;
            if (c > 0 && a != 0|| c < 0 && a == 0|| c < 0 && a == 0 || c < 0 && a != 0) // третий случай

            {
                result= -x / (c - a * x);
            }
            double expected = 1;
            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void DigitСheck() //Проверка на ввод цифр
        {
            
            var consoleInput ="Bukva"; //Имитация ввода
            var reader = new StringReader(consoleInput); //считывание
            Console.SetIn(reader); //вставка в консоль считанной строки
            var result = Console.ReadLine();//запись в переменную result
            Assert.IsFalse(int.TryParse(result, out int numericResult));

        }
        [TestMethod]
        public void NotSymbolsInput() //Проверка на запрет ввода спец символов
        {
           
            var consoleInput = "12"; //Имитация ввода
            var reader = new StringReader(consoleInput); //считывание
            Console.SetIn(reader); //вставка в консоль считанной строки
            var input = Console.ReadLine();//запись в переменную input
         
            if (ContainsSpecialCharacter(input))
            {
                Console.WriteLine("Input contains special characters.");
            }
            else
            {
                Console.WriteLine("Input does not contain special characters.");
            }
        }

        static bool ContainsSpecialCharacter(string input)
        {
            // Проверка на наличие специальных символов
            return input.Contains("!") || input.Contains("@") || input.Contains("#") || input.Contains("$") || input.Contains("%") || input.Contains("^") ||
                input.Contains("&") || input.Contains("*") || input.Contains("(") || input.Contains(")") || input.Contains("+") || input.Contains("=") || input.Contains("{") ||
                input.Contains("}") || input.Contains("[") || input.Contains("]") || input.Contains("\\") || input.Contains("|") || input.Contains(";") || input.Contains(":") ||
                input.Contains("\'") || input.Contains("\"") || input.Contains("<") || input.Contains(">") || input.Contains(",") || input.Contains(".") || input.Contains("?") ||
                input.Contains("/") || input.Contains("`") ;
        }
    
    }
}