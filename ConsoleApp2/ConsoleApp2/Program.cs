using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static int Max(int[] values)
        {
            int max = 0;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > max)
                {
                    max = values[i];
                }
            }
            return max;
        }
        static string maximum(string[] companies,float[] earnings)
        {
            float max = earnings[0];
            int index = 0;
            for (int i = 0; i < earnings.Length; i++)
            {
                if(earnings[i]>max)
                {
                    max = earnings[i];
                    index = i;
                }
            }
            return companies[index];
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 10, 2, 4, 5, 19 }; 
            Console.WriteLine(Max(arr));
            string[] companies = new string[] { "MSFT", "INTC", "CSCO", "GOOG" };
            float[] earnings = new float[] { -0.72f, 1.05f, 0.76f, -1.49f };
            Console.WriteLine("the highly gaind company is : " + maximum(companies, earnings));
        }
    }
}