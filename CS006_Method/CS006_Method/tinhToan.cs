using System;

namespace CS006_Method
{
    public class tinhToan
    {
        public static int tong(int a, int b)
        {
            return a + b;
        }
        public static float tong(float a, float b)
        {
            return a + b;
        }

        public static void xinChao1(String ten, String ho = "Nguyen")
        {
            string fullName1;
            fullName1 = ho + " " + ten;
            
            Console.WriteLine($"xin chao {fullName1}");
        }
    }
}

