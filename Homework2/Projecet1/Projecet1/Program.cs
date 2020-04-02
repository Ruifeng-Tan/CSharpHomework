using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Projecet1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string str = " ";
                Console.WriteLine("请开始输入数字，以空格回车结束输入");
                str = Console.ReadLine();
                int num = Int32.Parse(str);

                if (num <= 1)
                {
                    throw new Exception(message: "输入的数字必须大于1");
                }
                else
                {
                    for(int i = 2; i <= num;)
                    {
                         if (num % i == 0)
                        {
                            Console.Write(i + " ");
                            num /= i;
                        }
                        else
                        {
                            i++;
                        }

                    }

                    Console.ReadLine();
                }
            }
            catch(Exception x)
            {
                Console.WriteLine("错误"+x.Message);
            }

        }
    }
}
