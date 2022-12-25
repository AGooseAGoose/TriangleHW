namespace NewTriangle
{
     public  delegate string Triangle_LW(int Length, int Width);
    public class NewTriangleHW
    {
        public static string Triangle_Left(int Length, int Width)
            => new string('*', Width + 1);
        /* public static string Triangle_Right(int Length, int Width)
             => new string('*', Width + 1)+*/
        public static string Triangle(int Length,Triangle_LW result1)
        {
            string result=string.Empty;
            for (int i = 0; i < Length; i++)
            {
                result += result1(Length, i) + "\n";
            }
            return result;

        }
    }
    
}