using System;
namespace Ex_09_03
{
    public class Program
    {
        // You can leave Main empty, or add some lines
        static void Main(string[] args) { }
        public static double Divide(int x, int y)
        {
            if (y == 0) throw new DivideByZeroException();
            return 1.0 * x / y;
        }
        public static bool Compare(int x, int y) => x == y;
    }
}
