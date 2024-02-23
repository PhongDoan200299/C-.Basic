using System;
using System.Security.Cryptography;

namespace CS003_ArithmeticAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // + - * / %
            // ()
            float a = 15;
            int b = 4;

            float kq = 6 / 2 + 3 * 2;

            Console.WriteLine("a + b = {0}", a+ b);
            Console.WriteLine("a - b = {0}", a- b);
            Console.WriteLine("a * b = {0}", a* b);
            Console.WriteLine("a / b = {0}", a/ b);
            Console.WriteLine("a % b = {0}", a% b);
            Console.WriteLine(kq);

            // Gan
            //  = += -= *= /= %=

            int x = 10;
            // x ++;
            // ++x;
            int z = 2 * x++;
            // 2 * x;
            // x = x + 1;

            Console.WriteLine(x);
            Console.WriteLine(z);

            int y = 10;
            int m = 2 * ++y;
            //y = y +1;
            //2 * y = 22
            Console.WriteLine(y);
            Console.WriteLine(m);
        }
    }
}