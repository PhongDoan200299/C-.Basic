namespace CS012_Array;
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // String sinhVien1 = "Nguyen van A";
        // String sinhVien2 = "Nguyen van B";
        // String sinhVien3 = "Nguyen van C";
        //
        // Console.WriteLine(sinhVien1);
        // Console.WriteLine(sinhVien2);
        // Console.WriteLine(sinhVien3);

        // String[] ds;
        // ds = new String [3];
        // ds[0] = "Nguyen van A";
        // ds[1] = "Nguyen van B";
        // ds[2] = "Nguyen van C";
        
        // Console.WriteLine(ds[0]);
        // Console.WriteLine(ds[1]);
        // Console.WriteLine(ds[2]);

        // int[] mangSoNguyen;
        // String[] mang1 = new String [2]{"DienThoai", "MayTinh"};
        // Double[] mang2 = {0.1,0.5,0.7,50};
        //
        // mangSoNguyen = new int[3] {1,2,0};
        // mangSoNguyen[0] = 1;
        // mangSoNguyen[1] = 2;
        // mangSoNguyen[2] = 3;

        // int[] numbers = { 1, 4, 6, 9, 12, 56, 34, 7 };
        // int soPhanTu = numbers.Length;
        // for (int i = soPhanTu -1 ; i >= 0; i--)
        // {
        //     Console.WriteLine(numbers[i]);
        // }
        // foreach (var abc in numbers)
        // {
        //     Console.WriteLine(abc);
        // }
        // Console.WriteLine($"So phan tu: {numbers.Length}");
        // Console.WriteLine($"Chieu : {numbers.Rank}");
        //
        // Console.WriteLine($"Min: {numbers.Min()}");
        // Console.WriteLine($"Max : {numbers.Max()}");
        // Console.WriteLine($"Sum : {numbers.Sum()}");
        //
        // Array.Sort(numbers);
        //
        // foreach (var item in numbers)
        // {
        //     Console.WriteLine(item);
        // }
        /*
         *      0   1   2
         * 
         * 0    2   3   4.5
         * 1    1   9   8
         *
         * [0,1]
         * [1,2]
         */
 //       Double[,] numbers = new double[2,3];
        // 2 hang 3 cot
        Double[,] numbers = new double[2,3] {{2,3,4.5}, {1,9,8}};
        // Console.WriteLine(numbers[0,2]);
        int hang = 2;
        int cot = 3;
        for (int i = 0; i < hang; i++)
        {
            for (int j = 0; j < cot; j++)
            {
                Console.Write( numbers[i, j]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"Chieu : {numbers.Rank}");
    }
}