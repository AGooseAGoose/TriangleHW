using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TriangleHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle.Triangle.TriangleHW();
            Console.WriteLine(NewTriangleHW2.NewTriangleHW2.Triangle(8,NewTriangleHW2.NewTriangleHW2.Triangle_Left));
            Console.WriteLine(NewTriangleHW2.NewTriangleHW2.Triangle(8, NewTriangleHW2.NewTriangleHW2.Triangle_Right));
        }
    }
}
