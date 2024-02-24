using System;

namespace CS004_Logical_if_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOnline;
            isOnline = true;
            Console.WriteLine(isOnline);

            // == > < >= <= !=
            int a = 5;
            int b = 6;

            bool kq;
            kq = a == b;

            Console.WriteLine("a == b ==> {0}", kq);
            Console.WriteLine($"a != b ==> {a != b}");
            Console.WriteLine($"a > b ==> {a > b}");
            Console.WriteLine($"a < b ==> {a < b}");
            Console.WriteLine($"a >= b ==> {a >= b}");
            Console.WriteLine($"a <= b ==> {a <= b}");
            Console.WriteLine();
            bool k1;
            // && || !

            bool c = true;
            bool d = false;

            k1 = !(c && d);
            Console.WriteLine(k1);


            /*
            if(dieu_kien_logic)
                dong_lenh
            if(dieu_kien_logic)
            {
                ...
            }
            */

            int e;
            Console.WriteLine("Nhap so nguyen e:");
            e = int.Parse(Console.ReadLine());

            // a % 2 == 0
            if (a % 2 == 0)
            {
                Console.WriteLine("Ket qua:");
                Console.WriteLine($"So {a} la so chan");
            }
            else
            {
                Console.WriteLine("Ket qua:");
                Console.WriteLine($"So {a} la so le");
            }

            Console.WriteLine("The end");

            /**
            [8 - 10] : gioi
            [6.5 - 8] : kha
            [5.0 - 6.5] : trung binh
            [0 - 5.0] : Yeu
            **/
            float dtb;
            Console.WriteLine("Hay nhap diem trung binh");
            dtb = float.Parse(Console.ReadLine());

            if (0 < dtb && dtb > 10)
            {
                Console.WriteLine("Vui long nhap lai!");
            }
            else if (dtb < 5.0)
            {
                Console.WriteLine("Hoc Luc yeu");
            }
            else if (dtb >= 5.0 && dtb < 6.5)
            {
                Console.WriteLine("Hoc luc trung binh");
            }
            else if (dtb >= 6.5 && dtb < 8)
            {
                Console.WriteLine("Hoc luc kha");
            }
            else
            {
                Console.WriteLine("Hoc luc Gioi");
            }

            float t, h;
            Console.WriteLine("So t: ");
            t = float.Parse(Console.ReadLine());

            Console.WriteLine("So h: ");
            h = float.Parse(Console.ReadLine());

            float max;
            // if (a > b)
            //     max = t;
            // else   
            //     max = b;
            max = (t > h) ? t : h;
            Console.WriteLine("So lon nhat la: {0}", max);

            float ab = 2, ac = 3.5f, ad = 1;
            float max1;

            // if(ab > ac){
            //     // So lon a
            //     if(ab > ad){
            //         max = ab;
            //     }else {
            //         max = ad;
            //     }
            // }else {
            //     // So lon b
            //     if(ac > ad)
            //         max = ac;
            //     else
            //         max = ad;
            // }

            max1 = (ab > ac) ? (ab > ad) ? ab : ad : (ac > ad) ? ac : ad;

            Console.WriteLine(max1);

            int a1 = 3;
            int a2 = 4;
            // if (a1 == 1)
            // {
            //     Console.WriteLine("Gia tri a bang mot");
            // }
            // else if (a1 == 2)
            // {
            //     Console.WriteLine("Gia tri a bang hai");
            // }
            // else if (a1 == 3)
            // {
            //     Console.WriteLine("Gia tri a bang ba");
            // } 
            // else if (a1 == 4)
            // {
            //     Console.WriteLine("Gia tri a bang bon");
            // }
            // else
            // {
            //     Console.WriteLine("Hay kiem tra so khac");
            // }

            switch (a1)
            {
                case 1 :
                    Console.WriteLine("Gia tri a bang mot");
                    break;
                case 2 :
                    Console.WriteLine("Gia tri a bang hai");
                    break;
                case 3 :
                    Console.WriteLine("Gia tri a bang ba");
                    break;
                case 4:
                    Console.WriteLine("Gia tri a bang bon");
                    break;
                default:
                    Console.WriteLine("Hay kiem tra so khac");
                    break;
            }

            switch (a2)
            {
                case 1:
                case 3 :
                    Console.WriteLine("a la so le");
                    break;
                case 2:
                case 4 :
                    Console.WriteLine("a la so chan");
                    break;
                default:
                    Console.WriteLine("Hay kiem tra so khac");
                    break;
            }

            int a3, b3;
            Console.WriteLine("Nhap so a: ");
            a = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Nhap so b: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Hay chon lenh");
            Console.WriteLine("1) Tinh tong");
            Console.WriteLine("2) Tinh hieu");
            Console.WriteLine("3) Tinh tich");
            Console.WriteLine("4) Tinh thuong");

            char c3;
            L1: c3 = Console.ReadKey().KeyChar;

            switch (c3)
            {
                case '1':
                    Console.WriteLine($"Tong la: {a + b}");
                    break;
                case '2':
                    Console.WriteLine($"Hieu la: {a - b}");
                    break;
                case '3':
                    Console.WriteLine($"Tich la: {a * b}");
                    break;
                case '4':
                    Console.WriteLine($"Thuong la: {a / b}");
                    break;
                default:
                    Console.WriteLine("Vui long nhap lai");
                    goto L1;//Đến vị trí chỉ định
                    break;
            }
        }
    }
}