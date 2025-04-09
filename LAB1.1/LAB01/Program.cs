/*using System;
using System.Text;
namespace LAB01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Config Console Output được Tiếng Việt
            Console.OutputEncoding = Encoding.UTF8;
            //1. Khai báo biến
            int x1, x2, y1, y2;
            //2. Nhập giá trị
            Console.WriteLine("Nhập điểm A(x1, y1):");
            Console.Write("- x1: ");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("- y1: ");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm B(x2, y2):");
            Console.Write("- x2: ");
            x2 = int.Parse(Console.ReadLine());
            Console.Write("- y2: ");
            y2 = int.Parse(Console.ReadLine());
            //3. Tính khoảng cách
            double khoangCach = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            //4. Hiển thị kết quả
            Console.WriteLine($"Khoảng cách giữa điểm A({x1}, {y1}) với điểm B({x2}, {y2}) ={ khoangCach}");
        }
    }
}*/
//bai 1 : Viết chương trình nhập vào tên và tuổi, sau đó in ra màn hình thông báo "Xin chào[tên], bạn[tuổi] tuổi!".
/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap ten cua ban: ");
        string ten = Console.ReadLine();

        Console.Write("Nhap tuoi cua ban: ");
        int tuoi = int.Parse(Console.ReadLine());

        Console.WriteLine($"Xin chao {ten}, ban {tuoi} tuoi!");
    }
}
*/
//bai 2 Viết chương trình tính diện tích của hình chữ nhật khi người dùng nhập chiều dài và chiều rộng.
/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap chieu dai: ");
        double dai = double.Parse(Console.ReadLine());

        Console.Write("Nhap chieu rong: ");
        double rong = double.Parse(Console.ReadLine());

        double dienTich = dai * rong;

        Console.WriteLine($"Dien tich hinh chu nhat la: {dienTich}");
    }
}
*/
//Bài 3: Viết chương trình chuyển đổi nhiệt độ từ độ C sang độ F
/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap nhiet do (do C): ");
        double doC = double.Parse(Console.ReadLine());

        double doF = (doC * 9 / 5) + 32;

        Console.WriteLine($"Nhiet do tuong ung theo do F la: {doF}");
    }
}
*/
//bai 4: Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số chẵn hay không.
/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap mot so nguyen: ");
        int so = int.Parse(Console.ReadLine());

        if (so % 2 == 0)
        {
            Console.WriteLine($"{so} la so chan.");
        }
        else
        {
            Console.WriteLine($"{so} la so le.");
        }
    }
}
*/
//bai 5  Viết chương trình tính tổng và tích của hai số nhập từ bàn phím
/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so thu nhat: ");
        double so1 = double.Parse(Console.ReadLine());

        Console.Write("Nhap so thu hai: ");
        double so2 = double.Parse(Console.ReadLine());

        double tong = so1 + so2;
        double tich = so1 * so2;

        Console.WriteLine($"Tong cua hai so la: {tong}");
        Console.WriteLine($"Tich cua hai so la: {tich}");
    }
}
*/
//bai 6 Viết chương trình kiểm tra xem một số nhập vào có phải là số dương, số âm hay số không.
/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap mot so: ");
        double so = double.Parse(Console.ReadLine());

        if (so > 0)
        {
            Console.WriteLine("Day la so duong.");
        }
        else if (so < 0)
        {
            Console.WriteLine("Day la so am.");
        }
        else
        {
            Console.WriteLine("Day la so khong.");
        }
    }
}
*/
//bai 7 Viết chương trình kiểm tra xem một năm nhập vào có phải là năm nhuận hay không. (Năm nhuận là năm chia hết cho 4,
//trừ các năm chia hết cho 100 nhưng không chia hết cho 400).
/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap mot nam: ");
        int nam = int.Parse(Console.ReadLine());

        if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
        {
            Console.WriteLine($"{nam} la nam nhuan.");
        }
        else
        {
            Console.WriteLine($"{nam} khong phai la nam nhuan.");
        }
    }
}
*/
//bai 8  Viết chương trình in ra bảng cửu chương từ 1 đến 10.
/*using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"--- Bang cuu chuong {i} ---");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
            Console.WriteLine(); // Xuong dong giua cac bang
        }
    }
}
*/
//bai 9 Viết chương trình tính giai thừa của một số nguyên dương n.
/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap mot so nguyen duong: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Vui long nhap so nguyen duong.");
        }
        else
        {
            long giaiThua = 1;
            for (int i = 1; i <= n; i++)
            {
                giaiThua *= i;
            }

            Console.WriteLine($"Giai thua cua {n} la: {giaiThua}");
        }
    }
}
*/
//bai 10 Viết chương trình kiểm tra xem một số có phải là số nguyên tố hay không.
/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap mot so nguyen: ");
        int so = int.Parse(Console.ReadLine());

        if (so <= 1)
        {
            Console.WriteLine($"{so} khong phai la so nguyen to.");
        }
        else
        {
            bool laSoNguyenTo = true;

            for (int i = 2; i <= Math.Sqrt(so); i++)
            {
                if (so % i == 0)
                {
                    laSoNguyenTo = false;
                    break;
                }
            }

            if (laSoNguyenTo)
            {
                Console.WriteLine($"{so} la so nguyen to.");
            }
            else
            {
                Console.WriteLine($"{so} khong phai la so nguyen to.");
            }
        }
    }
}
/*
