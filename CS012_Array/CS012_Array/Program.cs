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
        // Double[,] numbers = new double[2,3] {{2,3,4.5}, {1,9,8}};
        // Console.WriteLine(numbers[0,2]);
        // int hang = 2;
        // int cot = 3;
        // for (int i = 0; i < hang; i++)
        // {
        //     for (int j = 0; j < cot; j++)
        //     {
        //         Console.Write( numbers[i, j]);
        //         Console.Write(" ");
        //     }
        //     Console.WriteLine();
        // }
        // Console.WriteLine($"Chieu : {numbers.Rank}");

        static void testForEach()
        // duyet qua cac phan tu mang kieu int, va in ra noi dung phan tu
        {
            int[] numbers = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Array.ForEach<int>(numbers, (int n) => { Console.WriteLine(n); });
            
        }
        testForEach();

        static void testFindAll()
        //TIm cac so chan (chia het cho 2) trong mang so nguyen 
        //Roi in ra ket qua
        {
            int[] numbers = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            //Dinh nghia Predicate la mot delegate tham so kieu int
            // tra ve true neu so chia het cho 2
            Predicate<int> predicate = (int number) =>
            {
                return number % 2 == 0;
            };
            
            //Tim cac so chan
            int[] cacsochan = Array.FindAll(numbers, predicate);
            
            //In ra ket qua
            Action<int> printNumber = (int number) => Console.WriteLine(number);
            Array.ForEach(cacsochan,printNumber);
        }
        Console.WriteLine();
        testFindAll();
        
        //Duyet qua cac phan tu mang

        int[] myArray = { 1, 3, 5, 19, 10, 20, 40, 40 };
        int maxIndex = myArray.Length - 1;
        for (int i = 0; i <= maxIndex; i++)
        {
            Console.WriteLine(myArray[i]);
        }
        
         int[] myArray1 = { 1, 3, 5, 19, 10, 20, 40, 40 };
        int sum = 0;
        foreach (var e in myArray1)
        {
            sum += e;
        }
        Console.WriteLine(sum);
        
        //Mang nhieu chieu
        
        //Khai bao mang so nguyen hai chieu 3x4 (3 hang 4 cot)
        int[,] myvar = new int [3, 4];
        
        //Truy cap vao phan tu cu the cua mang
        myvar[0, 0] = 1; // Hang 1, cot 1, gia tri = 1
        myvar[2, 3] = 4; // Hang 3, cot 4, gia tri = 4
        
        Console.WriteLine(myvar);

        int[,] myvar1 = new int [3, 4] { {1,2,3,4 }, {0,3,2,6 }, {8,6,1,0 } };
        for (int i = 0; i<= 2; i++)
        {
            for (int j = 0; j<=3; j++)
            {
                Console.Write(myvar1[i,j] + " ");
            }
            Console.WriteLine();
        }

        int[][] myArray3 = new int[][]
        {
            new int[] { 1, 2 },
            new int[] { 2, 5, 6 },
            new int[] { 2, 3 },
            new int[] { 2, 3, 4, 5, 5 }
        };

        foreach (var arr in myArray3)
        {
            foreach (var e in arr)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine();
        }
    }
}