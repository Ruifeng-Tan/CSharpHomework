using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            double result = 0;//intialize
            double num1 = 0, num2 = 0;
            Console.WriteLine("输入一个数字后回车一次");
            try
            {
                num1 = Convert.ToDouble(Console.ReadLine());
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception nullorwhitespace)//处理用户输入数字为空的异常
            {
                Console.WriteLine("输入的数字不能为空");
                Console.WriteLine("请重新输入数字");
                num1 = Convert.ToDouble(Console.ReadLine());
                num2 = Convert.ToDouble(Console.ReadLine());
            }

            string str;
            Console.WriteLine("输入一个运算符后回车: ");
            str = Console.ReadLine(); // get a char

            switch (str)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "/":
                    if (num2 == 0) Console.WriteLine("除法的除数不能为0");//除法的除数不能为0
                    else result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("输入的运算符非法");
                    Console.ReadLine();
                    break;
            }

            Console.WriteLine("你的计算结果是" + result);
            Console.ReadLine();//使得输出结果可以维持显示
        }
    }

}
