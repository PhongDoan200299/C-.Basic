using System;

namespace CS001_HelloWorld
{
    class Program
    {
        static void MainXXX(string[] args)
        {
            Console.WriteLine("Xin chao c#!");
        }
    }

    class Abc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Xin chao c#! ABC");

            Tong(3,2);

        }

        /// <summary>
        /// Phuong thuc tra ve tong 2 so nguyen
        /// </summary>
        /// <param name="a">So nguyen 1</param>
        /// <param name="b">So nguyen 2</param>
        /// <returns>Tong a + b</returns>
        static int Tong(int a,int b)
        {
            return(a+b);
        }
    }
}