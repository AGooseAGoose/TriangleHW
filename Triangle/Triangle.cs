using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Triangle
    {
        public static void TriangleHW()
        {
            for (int s = 1; s < 6; s++) //*
            {
                for (int m = 1; m < s + 1; m++)   //**
                {
                    Console.Write($"*");  //***
                }
                Console.WriteLine();
            }
            
            for(int k=1;k<6;k++)
            {
                for (int o =5; o >0; o--)//  *
                {
                    if (k>=o )            // **
                    {
                        Console.Write($"*");//***
                    }

                    else
                    {
                        Console.Write($" ");
                    }

                }
                        Console.WriteLine();
             }


            for (int k = 0; k < 4; k++)
            {
                for (int o = 4; o >=k; o--)
                {
                    Console.Write($" ");
                }
                for(int z=0;z<=2*k;z++)
                {
                        Console.Write($"*");
                }
                Console.WriteLine();
            }


        }
    }
}

