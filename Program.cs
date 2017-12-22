using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());

        double d;
        double e;
       

        d = N / 2;
        e = (double)N / 2;
        
        if (d - e == 0)
        {
            if (N >= 2 && N <= 5 || (N > 20))
            { 
                Console.WriteLine("Not Weird");
            }
            else
            {
                if (N >= 6 && N <= 20)
                {
                    Console.WriteLine("Weird");
                }    
            }
          
        }
        else
        {
            Console.WriteLine("Weird");
        }

        Console.ReadKey();
    }
}