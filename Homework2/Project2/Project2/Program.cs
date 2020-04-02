using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        static double[] GetNumbers(double []nums)
        {
            double[] needed_number = new double[4];
            //max,min,sum,average
            needed_number[0] = -1E9;
            needed_number[1] = 1E9;
            for (int i=0;i<nums.Length;i++)
            {
                if (needed_number[0] < nums[i]) needed_number[0] = nums[i];
                if (needed_number[1] > nums[i]) needed_number[1] = nums[i];
                needed_number[2] += nums[i];
                needed_number[3] = needed_number[2] / nums.Length;
            }
            return needed_number;
        }
        static void  ShowResults(double[] nums)
        {
            for(int i= 0;i<nums.Length;i++)
            {
                Console.WriteLine(nums[i] + " ");
            }
        }
        static void Main(string[] args)
        {

          string str;
          double[] nums;
          nums = new double[10];

        for(int i=0;i< nums.Length;i++)
         {
                int count = i + 1;
                Console.WriteLine("请输入第" +count + "个数字");
                str = Console.ReadLine();
                if( double.TryParse(str,out double n)&&n>=0)//确保输入的是数字且合法不越界
                {
                    nums[i] = n;
                 }

         }
            double[] results = new double[4];
            results = GetNumbers(nums);
            Console.WriteLine("所输入的10个数字的最大值，最小值，总和，平均数依次是：");
            ShowResults(results);
            Console.ReadLine();
            

           

        }
    }
}
