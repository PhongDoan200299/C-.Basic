using System;

namespace CS005_for_while
{
    internal class Program
    {
        /**
         * for(Khởi_tao; điều_kiện; cap nhat)
         * {
         *      Các câu lệnh trong khoi
         * }
         *
         * 
         */
        static void Main(string[] args)
        {
            // for (int i=0; i < 9; i++)
            // {
            //     Console.WriteLine($"i = {i}");
            //     Console.WriteLine("Hello World!");
            // }

            // for (int i = 0; i < 9; i++)
            // {
            //     Console.WriteLine("Khoi tao");
            //     Console.WriteLine($"i = {i}");
            //     Console.WriteLine("Cap nhat i");
            // }
            // int i = 0;
            //
            // for ( ;i <= 10; ) 
            // {
            //     Console.WriteLine($"3 x {i} = {3 * i}");
            //     i++;
            // }
//            int i = 0;
            // while (i <= 10)
            // {
            //     Console.WriteLine($"3 x {i} = {3 * i}");
            //     i++;
            // }
//Diem khac nhau vong lap while va do while
//while kiem tra dieu kien trc khi thuc hien bieu thuc, neu bieu thuc sai
// vong lap while ko thuc hien
// vong lap do while thuc hien truoc roi moi kiem tra dieu kien, nen it
//nhat vong lop do while thuc hien 1 lan trc khi kiem tra dieu kien ko dung
// va ko cho vong lap chay 
            // do
            // {
            //     Console.WriteLine($"3 x {i} = {3 * i}");
            //     i++;
            // } while (i <= 10);
            // while (i < 1000)
            // {
            //     Console.WriteLine(i);
            //     i++;
            //     if(i == 111)
            //         break;
            // }
            for (int i = 10; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }

                Console.WriteLine($"So i = {i}");

            }
        }
    }
}