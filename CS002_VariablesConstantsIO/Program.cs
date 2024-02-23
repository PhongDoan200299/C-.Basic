using System;

namespace CS002_VariablesConstantsIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Kieu_du_lieu Ten_bien;
            Ten_bien: 
                - a..z A..Z
                - 0 .. 9
                - _
                - Không bắt đấu bằng kí tự số         
            */
            //Kiểu khai báo biếng tường minh
            // String studentName = "PhongDoan";
            // int studentAge = 20;

            // float c ;
            // //c = 12.12f;
            // c = (float)12.12;

            // object d;
            // d = studentName;

            double so_pi;
            so_pi = 3.14;
            double hai_pi;
            hai_pi = 2*so_pi;

            // const được khai báo trc biến, quy định hằng số
            const double PI = 3.14;
            const String WED = "THU TU";

            
            Console.Clear();
            //Xóa sạch thanh terminal
            Console.WriteLine(PI);
            Console.WriteLine(WED);

            
            Console.Title = "Vi du su dung Console";
            // Đặt tên cho title 
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            //Đặt màu chữ 
            Console.BackgroundColor = ConsoleColor.Gray;
            //Đặt màu background

            Console.WriteLine();
            Console.WriteLine();
            // Xuống dòng

            Console.WriteLine("xin chao, chuong trinh nhap xuat du lieu Console");

            Console.ResetColor();
            //Đặt lại mặc định màu chữ

            String hoVaTen;
            Console.Write("Ho va ten cua ban:");
            hoVaTen = Console.ReadLine();

            Console.WriteLine("xin chao {0}", hoVaTen);

            Console.WriteLine("gia tri so pi:");
            Console.ReadKey();
            //Nhấn 1 nút bất kì rồi mới thực hiện tác vụ

            float a, b;
            String sInput;

            Console.WriteLine("Hay nhap vao so a:");
            sInput = Console.ReadLine();
            a = float.Parse(sInput);

            Console.WriteLine("Hay nhap vao so b");
            sInput = Console.ReadLine();
            b = Convert.ToSingle(sInput);

            Console.WriteLine("So a = {0}, b = {1}",a,b);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(so_pi);
            Console.WriteLine(hai_pi);
            
            // Kiểu khai báo biến ngầm định
            var a = "Hello";
            // biến a đã được ngầm định là chuỗi, khi gắn biến a bằng
            // 123 thì sẽ xảy ra lỗi
           // a = 123;
           var b = 5;
           b = 456;
           // Biến b ở đây được ngầm định là số, khi gắn biến b bằng 
           //456 thì ko bình thường
        }
    }
}