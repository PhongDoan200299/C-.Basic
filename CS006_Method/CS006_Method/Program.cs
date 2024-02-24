using System;

namespace CS006_Method
{
    class Count
    {
        public int c = 1;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double bp = BinhPhuong(5);//Goi ham
            Console.WriteLine("Binh Phuong cua 5 la: " + bp);
            xinChao("A", "Nguyen");

            tinhToan.xinChao1("Phong");

            int x = 234;
            int y = 456;
            var result = tinhToan.tong(x, y);
            Console.WriteLine(result);

            float a = 12.12f;
            float b = 10.0f;

            // Loi vi ham tong nhan int ko nhan float
            var result1 = tinhToan.tong(a, b);
            Console.WriteLine(result1);
            
            //int u truyền vào hàm binhPhuongTest(u) là đối so
            // Kieu truyen nay la truyen tham tri value type
            // doi so u được tạo ra bản sao gán vào a trong method 
            //binhPhuongTest
            // Nen u ko thay doi
            int u = 5;
            
            binhPhuongTest(u);
            binhPhuongTest(u);
            binhPhuongTest(u);
            Console.WriteLine(u);

            // Kieu truyen tham chieu reference type
            int u1 = 5;
            binhPhuongTest2(ref u);
            binhPhuongTest2(ref u);
            binhPhuongTest2(ref u);
            Console.WriteLine(u);

            int u2;
            binhPhuongTest3(4,out u2);
            binhPhuongTest3(4,out u2);
            Console.WriteLine(u2);

            Count count1 = new Count();
            Console.WriteLine(count1.c);
            
            dem(count1);
            Console.WriteLine(count1.c);
            
            Console.WriteLine(giaiThua(5));
        }
        
        //int x là tham số
        static void binhPhuongTest(int x)
        {
            x = x * x;
            Console.WriteLine(x);
        }
        
        static void binhPhuongTest2(ref int x)
        {
            x = x * x;
            Console.WriteLine(x);
        }
        
        static void binhPhuongTest3(int x, out int kq)
        {
            kq = x * x;
        }

        static void dem(Count count)
        {
            count.c++;
        }
        
        // <Access Modifiers> <return type> <name_method>(<parameters>)
        // {
        //     // Các câu lệnh trong phương thức
        // }
        //static ở trước Access Modifiers thì phương thức (hàm) đó gọi là
        //PHƯƠNG THỨC TĨNH (Truy cập được mà không cần tạo đối tượng lớp),
        //thường dùng kèm với Access Modify tên public để tạo các hàm chức năng,
        //tiện ích.
        
        //parameters là các tham số của hàm nếu có, các tham số khai báo theo
        //mẫu kiểu tên như int thamso1, nhiều tham số thì cách nhau bởi dấu
        //,.

        //Phuong thuc co kieu tra ve return type kieu: int, double,string,...
        //Phuong thuc ko co kieu tra ve: void
        static void xinChao(string ten,string ho)
        {
            string fullName;
            fullName = ho + " " + ten;
            Console.WriteLine($"Xin Chao C sharp {fullName}");
        }
        
        //Ví dụ 1) Khai báo hàm (phương thức) tĩnh có tên BinhPhuong trong
        //lớp Program, phương thức có một tham số kiểu double, trả về kiểu
        //double là bình phương của tham số. Sau đó gọi hàm tính bình phương
        //của 5.
        
        //Tinh binh phuong cua so thuc double
        static double BinhPhuong(double number)
        {
            double ketQua = number * number;
            return ketQua;
        }

        public static int giaiThua(int a)
        {
            if (a == 1)
            {
                return 1; //Ket thuc de quy
            }

            return
                a * giaiThua(a - 1);//De quy
        }


    }
}