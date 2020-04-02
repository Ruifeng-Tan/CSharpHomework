using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Program
    {
        static void select(int []a)
        {
            for(int i = 2;i<=9;i++)
            {
                int max = 100 / i;
                for(int j = 2;j<=max;j++)
                {
                    a[i * j-2] = 0;
                }
            }
        }
        static void Main(string[] args)
        {
            /*通过埃氏筛法筛素数*/
            int[] nums = new int[200];
            for(int i =2;i<=100;i++)
            {
                nums[i-2] = i;
            }//将98个数存进数组
            select(nums);
            Console.WriteLine("2~100的素数为：");
            for(int i = 0; i < 98; i++)
            {
                if (nums[i] != 0)
                {
                    Console.WriteLine(nums[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
