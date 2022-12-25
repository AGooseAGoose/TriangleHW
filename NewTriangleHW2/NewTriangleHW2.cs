using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTriangleHW2
{
    //改良版 但改良後不會寫金字塔
    public delegate string Triangle_LW(int Length, int Width);
    public class NewTriangleHW2
    {
        public static string Triangle_Left(int Length, int Width)
            => new string('*', Width);
        public static string Triangle_Right(int Length, int Width)
            => new string('*', Width).PadLeft(Length);


        public static string Triangle(int Length, Triangle_LW result1)
        {
            string result = string.Empty;
            for (int Width = 1; Width <= Length; Width++)
            {
                result += result1(Length, Width) + "\n";
            }
            return result;
        }
    }
}
