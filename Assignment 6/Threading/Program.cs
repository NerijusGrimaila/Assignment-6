using System;
using System.Threading;

namespace Threading
{
    class Program
    {
        //private static object _locker = new object();
        static void Main(string[] args)
        {

            Console.WriteLine("!!!!MULTIPLE THREADS!!!!");
            new Thread(() =>
            {
                PrintNumbers();

            }).Start();

            new Thread(() =>
            {
                PrintNumbers();

            }).Start();

            new Thread(() =>
            {
                PrintNumbers();

            }).Start();

        }
        public static void PrintNumbers()
        {
            int num0 = 0;
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;

            //Console.WriteLine("{0},{1},{2},{3},{4},", num0, num1, num2, num3, num4);
            Console.Write(num0);
          









        }
    }
}
