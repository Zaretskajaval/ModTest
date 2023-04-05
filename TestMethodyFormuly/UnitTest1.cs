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
        public void CheckingTheFirstCondition()   //��������, ��� ��� c < 0 � a != 0 ������� ���������� ���������� ���������.
        {
            double x = 3;
            double a = 2;
            double c = -4;
            double result = 0;
            if (c < 0 && a != 0) // ������ ������
            {
                result = -a * (x * x);
            }
            double expected = -18;

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void CheckingTheSecondCondition()    //��������, ��� ��� c > 0 � a == 0 ������� ���������� ���������� ���������.
        {
            double x = 1;
            double a = 0;
            double c = 3;
            double result = 0;
            if (c > 0 && a == 0) // ������ ������
            {
                result = (a - x) / (c * x);
            }
            double expected = -0.3333333333333333;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void CheckingTheThirdCondition()   // ��������, ��� ��� ��������� ��������� a � c ������� ���������� ���������� ���������.
        {
         
            double x = 2;//2
            double a = 3;//3
            double c = 4;//4
            double result = 0;
            if (c > 0 && a != 0|| c < 0 && a == 0|| c < 0 && a == 0 || c < 0 && a != 0) // ������ ������

            {
                result= -x / (c - a * x);
            }
            double expected = 1;
            
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Digit�heck() //�������� �� ���� ����
        {
            
            var consoleInput ="Bukva"; //�������� �����
            var reader = new StringReader(consoleInput); //����������
            Console.SetIn(reader); //������� � ������� ��������� ������
            var result = Console.ReadLine();//������ � ���������� result
            Assert.IsFalse(int.TryParse(result, out int numericResult));

        }
        [TestMethod]
        public void NotSymbolsInput() //�������� �� ������ ����� ���� ��������
        {
           
            var consoleInput = "12"; //�������� �����
            var reader = new StringReader(consoleInput); //����������
            Console.SetIn(reader); //������� � ������� ��������� ������
            var input = Console.ReadLine();//������ � ���������� input
         
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
            // �������� �� ������� ����������� ��������
            return input.Contains("!") || input.Contains("@") || input.Contains("#") || input.Contains("$") || input.Contains("%") || input.Contains("^") ||
                input.Contains("&") || input.Contains("*") || input.Contains("(") || input.Contains(")") || input.Contains("+") || input.Contains("=") || input.Contains("{") ||
                input.Contains("}") || input.Contains("[") || input.Contains("]") || input.Contains("\\") || input.Contains("|") || input.Contains(";") || input.Contains(":") ||
                input.Contains("\'") || input.Contains("\"") || input.Contains("<") || input.Contains(">") || input.Contains(",") || input.Contains(".") || input.Contains("?") ||
                input.Contains("/") || input.Contains("`") ;
        }
    
    }
}