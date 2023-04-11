using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_PolessUP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 3, 5, 6 };
            int target = 5; 
            int i = 0;
            while (nums[i] < target)
            {
                i++;
            }
            Console.WriteLine(i);
        }
    }
}
