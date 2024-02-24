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
            if(a % 2 == 0){
                Console.WriteLine("Ket qua:");
                Console.WriteLine($"So {a} la so chan");
            }
            else {
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

            if(0 < dtb && dtb > 10){
                Console.WriteLine("Vui long nhap lai!");
            } else if(dtb < 5.0){
                Console.WriteLine("Hoc Luc yeu");
            } else if(dtb >= 5.0 && dtb <6.5){
                Console.WriteLine("Hoc luc trung binh");
            } else if(dtb >= 6.5 && dtb <8){
                Console.WriteLine("Hoc luc kha");
            } else {
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
            max = (a > b) ? a : b;
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

            max1 = (ab > ac) ? (ab > ad) ? ab: ad : (ac > ad) ? ac : ad;

            Console.WriteLine(max1);
        }
    }
}