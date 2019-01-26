using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int min=0,max=99;
            Random random = new Random();
            int guess = random.Next(min,max);
            Console.WriteLine("Number is : "+guess);

            

        }
      
    }
}
