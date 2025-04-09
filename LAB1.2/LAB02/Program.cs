/* using System;
namespace LAB2
{
    class Program
    {
        public static void NhapMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        public static int TinhTong(int[] a, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += a[i];
            }
            return tong;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Khai báo biến n
            int n;
            //Nhập giá trị cho biến n
            Console.Write("Nhập n: ");
            n = int.Parse(Console.ReadLine());
            //Khai báo và khởi tạo mảng số nguyên có n phần tử
            int[] a = new int[n];
            //Gọi hàm nhập mảng
            NhapMang(a, n);
            //Gọi hàm Tính Tổng các phần tử trong mảng và hiển thị kết quả ra màn hình
            Console.WriteLine($"Tổng = {TinhTong(a, n)}");
        }
    }
}*/
//bai 1 Viết một hàm để tính tổng của tất cả các số chẵn trong một mảng.
/* using System;

class Program
{
    static int TinhTongSoChan(int[] mang)
    {
        int tong = 0;
        foreach (int so in mang)
        {
            if (so % 2 == 0)
            {
                tong += so;
            }
        }
        return tong;
    }

    static void Main()
    {
        int[] mang = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int tongSoChan = TinhTongSoChan(mang);

        Console.WriteLine($"Tong cua cac so chan trong mang la: {tongSoChan}");
    }
}
*/
//bai 2  Viết chương trình nhập vào mảng gồm n phần tử nhập từ bàn phím. Viết hàm để kiểm
//tra xem một số có phải là số nguyên tố hay không, hiển thị chỉ số và giá trị của những phần tử
//là số nguyên tố trong mảng
/*using System;

class Program
{
    // Hàm kiểm tra số nguyên tố
    static bool KiemTraSoNguyenTo(int so)
    {
        if (so <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(so); i++)
        {
            if (so % i == 0)
                return false;
        }
        return true;
    }

    static void Main()
    {
        Console.Write("Nhap so phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());

        int[] mang = new int[n];

        // Nhập các phần tử vào mảng
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu mang[{i}]: ");
            mang[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Cac phan tu la so nguyen to trong mang:");

        // Kiểm tra và in ra chỉ số và giá trị của các phần tử là số nguyên tố
        for (int i = 0; i < n; i++)
        {
            if (KiemTraSoNguyenTo(mang[i]))
            {
                Console.WriteLine($"Phan tu mang[{i}] = {mang[i]} la so nguyen to.");
            }
        }
    }
}
*/
//bai 3 Viết một hàm để đếm số lượng số âm và số dương trong một mảng gồm n phần tử nhập từ bàn phím.
/*using System;

class Program
{
    // Hàm đếm số lượng số âm và số dương
    static void DemSoAmVaSoDuong(int[] mang, out int soAm, out int soDuong)
    {
        soAm = 0;
        soDuong = 0;

        foreach (int so in mang)
        {
            if (so < 0)
                soAm++;
            else if (so > 0)
                soDuong++;
        }
    }

    static void Main()
    {
        Console.Write("Nhap so phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());

        int[] mang = new int[n];

        // Nhập các phần tử vào mảng
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu mang[{i}]: ");
            mang[i] = int.Parse(Console.ReadLine());
        }

        int soAm, soDuong;
        DemSoAmVaSoDuong(mang, out soAm, out soDuong);

        Console.WriteLine($"So luong so am trong mang: {soAm}");
        Console.WriteLine($"So luong so duong trong mang: {soDuong}");
    }
}
*/
//bai 4  Viết hàm để tìm số lớn thứ hai trong một mảng các số nguyên.
/*using System;

class Program
{
    // Ham tim so lon thu hai trong mang
    static int TimSoLonThuHai(int[] mang)
    {
        if (mang.Length < 2)
        {
            Console.WriteLine("Mang phai co it nhat 2 phan tu.");
            return int.MinValue;  // Tra ve gia tri cuc nho de bao loi
        }

        int max1 = int.MinValue;  // So lon nhat
        int max2 = int.MinValue;  // So lon thu hai

        foreach (int so in mang)
        {
            if (so > max1)
            {
                max2 = max1;  // Cap nhat so lon thu hai
                max1 = so;    // Cap nhat so lon nhat
            }
            else if (so > max2 && so != max1)
            {
                max2 = so;    // Cap nhat so lon thu hai neu dieu kien thoa man
            }
        }

        return max2;
    }

    static void Main()
    {
        Console.Write("Nhap so phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());

        int[] mang = new int[n];

        // Nhap cac phan tu vao mang
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu mang[{i}]: ");
            mang[i] = int.Parse(Console.ReadLine());
        }

        int soLonThuHai = TimSoLonThuHai(mang);

        if (soLonThuHai != int.MinValue)
        {
            Console.WriteLine($"So lon thu hai trong mang la: {soLonThuHai}");
        }
        else
        {
            Console.WriteLine("Khong the tim so lon thu hai trong mang.");
        }
    }
}
*/
//bai 5 Viết hàm hoán vị 2 số nguyên a và b nhập từ bàn phím.
/*using System;

class Program
{
    // Ham hoan vi 2 so nguyen a va b
    static void HoanVi(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        Console.Write("Nhap so a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhap so b: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Truoc khi hoan vi: a = {a}, b = {b}");

        // Goi ham hoan vi
        HoanVi(ref a, ref b);

        Console.WriteLine($"Sau khi hoan vi: a = {a}, b = {b}");
    }
}
*/
//bai 6 Viết hàm sắp xếp mảng số thực n phần tử nhập từ bàn phím theo chiều tăng dần
/*using System;

class Program
{
    // Ham sap xep mang so thuc theo chieu tang dan
    static void SapXepTangDan(ref double[] mang)
    {
        for (int i = 0; i < mang.Length - 1; i++)
        {
            for (int j = i + 1; j < mang.Length; j++)
            {
                if (mang[i] > mang[j])
                {
                    // Hoan vi 2 phan tu
                    double temp = mang[i];
                    mang[i] = mang[j];
                    mang[j] = temp;
                }
            }
        }
    }

    static void Main()
    {
        Console.Write("Nhap so phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());

        double[] mang = new double[n];

        // Nhap cac phan tu vao mang
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu mang[{i}]: ");
            mang[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Mang truoc khi sap xep:");
        foreach (var so in mang)
        {
            Console.Write(so + " ");
        }

        // Goi ham sap xep
        SapXepTangDan(ref mang);

        Console.WriteLine("\nMang sau khi sap xep theo chieu tang dan:");
        foreach (var so in mang)
        {
            Console.Write(so + " ");
        }
    }
}
*/