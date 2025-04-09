/*using System;

namespace BaiTap1
{
    class Program
    {
        public static void NhapPhanSo(PhanSo phanSo1, PhanSo phanSo2)
        {
            Console.WriteLine("Phan so 1: ");
            phanSo1.Nhap();
            Console.WriteLine("Phan so 2: ");
            phanSo2.Nhap();
        }
        static void Main(string[] args)
        {
            PhanSo ps1 = new PhanSo();
            PhanSo ps2 = new PhanSo();
            PhanSo ps3 = new PhanSo();
            int x;
            Console.WriteLine("Cac phep toan cua phan so:");
            Console.WriteLine("\t1. Nhap 1 neu muon cong");
            Console.WriteLine("\t2. Nhap 2 neu muon tru");
            Console.WriteLine("\t3. Nhap 3 neu muon nhan");
            Console.WriteLine("\t4. Nhap 4 neu muon chia");
            Console.WriteLine("\t5. Nhap 5 neu toi gian");
            Console.Write("- Moi ban nhap lua chon: ");
            x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    {
                        NhapPhanSo(ps1, ps2);
                        ps3 = ps1 + ps2;
                        Console.WriteLine($"Ket qua: {ps1.TuSo}/{ps1.MauSo} + {ps2.TuSo}/{ps2.MauSo} = {ps3.TuSo}/{ps3.MauSo}");
                    }
                    break;
                case 2:
                    {
                        NhapPhanSo(ps1, ps2);
                        ps3 = ps1 - ps2;
                        Console.WriteLine($"Ket qua: {ps1.TuSo}/{ps1.MauSo} - {ps2.TuSo}/{ps2.MauSo} = {ps3.TuSo}/{ps3.MauSo}");
                    }
                    break;
                case 3:
                    {
                        NhapPhanSo(ps1, ps2);
                        ps3 = ps1 * ps2;
                        Console.WriteLine($"Ket qua: {ps1.TuSo}/{ps1.MauSo} *{ps2.TuSo}/{ps2.MauSo} = {ps3.TuSo}/{ps3.MauSo}");
                    }
                    break;
                case 4:
                    {
                        NhapPhanSo(ps1, ps2);
                        ps3 = ps1 / ps2;
                        Console.WriteLine($"Ket qua: {ps1.TuSo}/{ps1.MauSo} /{ps2.TuSo}/{ps2.MauSo} = {ps3.TuSo}/{ps3.MauSo}");
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("Nhap phan so muon toi gian: ");
                        ps1.Nhap();
                        ps1.KiemTra();
                        if (ps1.KiemTra())
                            Console.WriteLine("Phan so da toi gian.");
                        else
                        {
                            ps1.ToiGian();
                            Console.WriteLine("Sau khi toi gian: " + ps1.TuSo + "/" +
                            ps1.MauSo);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Nhap sai !!!");
                    break;
            }
        }
    }
}
*/
//bai 1:
/*
using System;
using System.Collections.Generic;

namespace BaiTap1
{
    // Lớp cơ sở: CanBo
    internal class CanBo
    {
        public string HoTen { get; set; } = string.Empty;
        public int NamSinh { get; set; }
        public string GioiTinh { get; set; } = string.Empty;
        public string DiaChi { get; set; } = string.Empty;

        public virtual void NhapThongTin()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine() ?? string.Empty;
            Console.Write("Nhap nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhap gioi tinh: ");
            GioiTinh = Console.ReadLine() ?? string.Empty;
            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine() ?? string.Empty;
        }

        public virtual void HienThiThongTin()
        {
            Console.WriteLine($"Ho ten: {HoTen}, Nam sinh: {NamSinh}, Gioi tinh: {GioiTinh}, Dia chi: {DiaChi}");
        }
    }

    // Lớp NhanVien: kế thừa từ CanBo, thêm thuộc tính công việc
    internal class NhanVien : CanBo
    {
        public string CongViec { get; set; } = string.Empty;

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhap cong viec: ");
            CongViec = Console.ReadLine() ?? string.Empty;
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Cong viec: {CongViec}");
        }
    }

    // Lớp KySu: kế thừa từ CanBo, thêm thuộc tính ngành đào tạo
    internal class KySu : CanBo
    {
        public string Nganh { get; set; } = string.Empty;

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhap nganh dao tao: ");
            Nganh = Console.ReadLine() ?? string.Empty;
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Nganh dao tao: {Nganh}");
        }
    }

    // Lớp CongNhan: kế thừa từ CanBo, thêm thuộc tính bậc chu công nhân
    internal class CongNhan : CanBo
    {
        public string Bac { get; set; } = string.Empty;

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhap bac (Vi du: 3/7): ");
            Bac = Console.ReadLine() ?? string.Empty;
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Bac: {Bac}");
        }
    }

    // Lớp QLCB: Quản lý các cán bộ
    internal class QLCB
    {
        private List<CanBo> danhSachCanBo = new List<CanBo>();

        public void NhapThongTinMoi()
        {
            Console.WriteLine("Nhap loai can bo (1: Nhan Vien, 2: Ky Su, 3: Cong Nhan): ");
            if (!int.TryParse(Console.ReadLine(), out int loaiCanBo))
            {
                Console.WriteLine("Loai can bo khong hop le.");
                return;
            }

            CanBo canBo = loaiCanBo switch
            {
                1 => new NhanVien(),
                2 => new KySu(),
                3 => new CongNhan(),
                _ => throw new ArgumentException("Loai can bo khong hop le")
            };

            canBo.NhapThongTin();
            danhSachCanBo.Add(canBo);
        }

        public void TimKiemTheoHoTen(string hoTen)
        {
            var ketQua = danhSachCanBo.FindAll(cb =>
                cb.HoTen.IndexOf(hoTen, StringComparison.OrdinalIgnoreCase) >= 0);

            if (ketQua.Count == 0)
            {
                Console.WriteLine("Khong tim thay can bo co ho ten: " + hoTen);
                return;
            }

            foreach (var canBo in ketQua)
            {
                canBo.HienThiThongTin();
            }
        }

        public void HienThiDanhSach()
        {
            if (danhSachCanBo.Count == 0)
            {
                Console.WriteLine("Danh sach trong!");
                return;
            }

            foreach (var canBo in danhSachCanBo)
            {
                canBo.HienThiThongTin();
            }
        }

        public void Menu()
        {
            int luaChon = -1;
            do
            {
                Console.WriteLine("\nCHUONG TRINH QUAN LY CAN BO");
                Console.WriteLine("1. Nhap thong tin moi");
                Console.WriteLine("2. Tim kiem theo ho ten");
                Console.WriteLine("3. Hien thi danh sach");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon chuc nang: ");
                int.TryParse(Console.ReadLine(), out luaChon);
                switch (luaChon)
                {
                    case 1:
                        NhapThongTinMoi();
                        break;
                    case 2:
                        Console.Write("Nhap ho ten can tim: ");
                        string name = Console.ReadLine() ?? string.Empty;
                        TimKiemTheoHoTen(name);
                        break;
                    case 3:
                        HienThiDanhSach();
                        break;
                    case 4:
                        Console.WriteLine("Thoat chuong trinh Bai 1.");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le.");
                        break;
                }
                if (luaChon != 4)
                {
                    Console.WriteLine("Nhan phim bat ky de tiep tuc...");
                    Console.ReadKey();
                }
            } while (luaChon != 4);
        }
    }

    // Lớp tĩnh Bai1 chứa hàm xử lý giao diện riêng, được gọi từ file Program.cs
    internal static class Bai1
    {
        public static void B1()
        {
            Console.Clear();
            Console.WriteLine("------ Bai 1: Quan ly can bo ------");
            QLCB ql = new QLCB();
            ql.Menu();
        }
    }
}
*/
//bai 2 
/*using System;
using System.Collections.Generic;

namespace BaiTap1
{
    // Lớp TaiLieu có các thuộc tính chung
    internal class TaiLieu
    {
        public string MaTaiLieu { get; set; } = string.Empty;
        public string TenNhaXuatBan { get; set; } = string.Empty;
        public int SoBanPhatHanh { get; set; }

        public virtual void Nhap()
        {
            Console.Write("Nhap ma tai lieu: ");
            MaTaiLieu = Console.ReadLine() ?? string.Empty;
            Console.Write("Nhap ten nha xuat ban: ");
            TenNhaXuatBan = Console.ReadLine() ?? string.Empty;
            Console.Write("Nhap so ban phat hanh: ");
            SoBanPhatHanh = int.Parse(Console.ReadLine() ?? "0");
        }

        public virtual void HienThi()
        {
            Console.WriteLine("Ma tai lieu: " + MaTaiLieu);
            Console.WriteLine("Ten nha xuat ban: " + TenNhaXuatBan);
            Console.WriteLine("So ban phat hanh: " + SoBanPhatHanh);
        }

        public virtual string GetLoai() => "";
    }

    // Lớp Sach: thêm thuộc tính TenTacGia, SoTrang
    internal class Sach : TaiLieu
    {
        public string TenTacGia { get; set; } = string.Empty;
        public int SoTrang { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap ten tac gia: ");
            TenTacGia = Console.ReadLine() ?? string.Empty;
            Console.Write("Nhap so trang: ");
            SoTrang = int.Parse(Console.ReadLine() ?? "0");
        }

        public override void HienThi()
        {
            Console.WriteLine("Loai: Sach");
            base.HienThi();
            Console.WriteLine("Ten tac gia: " + TenTacGia);
            Console.WriteLine("So trang: " + SoTrang);
        }

        public override string GetLoai() => "Sach";
    }

    // Lớp TapChi: thêm thuộc tính SoPhatHanh, ThangPhatHanh
    internal class TapChi : TaiLieu
    {
        public int SoPhatHanh { get; set; }
        public string ThangPhatHanh { get; set; } = string.Empty;

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so phat hanh: ");
            SoPhatHanh = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhap thang phat hanh: ");
            ThangPhatHanh = Console.ReadLine() ?? string.Empty;
        }

        public override void HienThi()
        {
            Console.WriteLine("Loai: Tap Chi");
            base.HienThi();
            Console.WriteLine("So phat hanh: " + SoPhatHanh);
            Console.WriteLine("Thang phat hanh: " + ThangPhatHanh);
        }

        public override string GetLoai() => "TapChi";
    }

    // Lớp Bao: thêm thuộc tính NgayPhatHanh
    internal class Bao : TaiLieu
    {
        public string NgayPhatHanh { get; set; } = string.Empty;

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap ngay phat hanh: ");
            NgayPhatHanh = Console.ReadLine() ?? string.Empty;
        }

        public override void HienThi()
        {
            Console.WriteLine("Loai: Bao");
            base.HienThi();
            Console.WriteLine("Ngay phat hanh: " + NgayPhatHanh);
        }

        public override string GetLoai() => "Bao";
    }

    // Lớp QuanLyTaiLieu: quản lý danh sách và các chức năng của tài liệu
    internal class QuanLyTaiLieu
    {
        private List<TaiLieu> dsTaiLieu = new List<TaiLieu>();

        public void NhapTaiLieu()
        {
            Console.WriteLine("Chon loai tai lieu can nhap:");
            Console.WriteLine("1. Sach");
            Console.WriteLine("2. Tap Chi");
            Console.WriteLine("3. Bao");
            Console.Write("Nhap lua chon: ");
            int luaChon = int.Parse(Console.ReadLine() ?? "0");
            TaiLieu tl = luaChon switch
            {
                1 => new Sach(),
                2 => new TapChi(),
                3 => new Bao(),
                _ => null
            };

            if (tl == null)
            {
                Console.WriteLine("Lua chon khong hop le.");
                return;
            }

            tl.Nhap();
            dsTaiLieu.Add(tl);
        }

        public void HienThiTaiLieu()
        {
            if (dsTaiLieu.Count == 0)
            {
                Console.WriteLine("Danh sach trong!");
                return;
            }

            foreach (var tl in dsTaiLieu)
            {
                tl.HienThi();
                Console.WriteLine("-----");
            }
        }

        public void TimKiemTheoLoai()
        {
            Console.Write("Nhap loai tai lieu can tim (Sach, TapChi, Bao): ");
            string loai = Console.ReadLine() ?? string.Empty;

            bool found = false;
            foreach (var tl in dsTaiLieu)
            {
                if (tl.GetLoai().Equals(loai, StringComparison.OrdinalIgnoreCase))
                {
                    tl.HienThi();
                    Console.WriteLine("-----");
                    found = true;
                }
            }
            if (!found)
                Console.WriteLine("Khong tim thay tai lieu loai: " + loai);
        }

        public void Menu()
        {
            int luaChon = -1;
            do
            {
                Console.WriteLine("\nCHUONG TRINH QUAN LY TAI LIEU");
                Console.WriteLine("1. Nhap thong tin tai lieu");
                Console.WriteLine("2. Hien thi danh sach tai lieu");
                Console.WriteLine("3. Tim kiem theo loai tai lieu");
                Console.WriteLine("4. Thoat chuong trinh");
                Console.Write("Chon chuc nang: ");
                luaChon = int.Parse(Console.ReadLine() ?? "0");
                switch (luaChon)
                {
                    case 1:
                        NhapTaiLieu();
                        break;
                    case 2:
                        HienThiTaiLieu();
                        break;
                    case 3:
                        TimKiemTheoLoai();
                        break;
                    case 4:
                        Console.WriteLine("Thoat chuong trinh Bai 2.");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le.");
                        break;
                }
                if (luaChon != 4)
                {
                    Console.WriteLine("Nhan phim bat ky de tiep tuc...");
                    Console.ReadKey();
                }
            } while (luaChon != 4);
        }
    }

    // Lớp tĩnh Bai2 chứa hàm giao diện của bài 2, sẽ được gọi từ file main
    internal static class Bai2
    {
        public static void B2()
        {
            Console.Clear();
            Console.WriteLine("------ Bai 2: Quan ly tai lieu ------");
            QuanLyTaiLieu ql = new QuanLyTaiLieu();
            ql.Menu();
        }
    }
}
*/
//bai 3 
/*
using System;
using System.Collections.Generic;

namespace BaiTap1
{
    // Lớp cơ sở ThiSinh
    internal class ThiSinh
    {
        public string SoBaoDanh { get; set; } = string.Empty;
        public string HoTen { get; set; } = string.Empty;
        public string DiaChi { get; set; } = string.Empty;
        public string UuTien { get; set; } = string.Empty;

        public virtual void Nhap()
        {
            Console.Write("Nhap so bao danh: ");
            SoBaoDanh = Console.ReadLine() ?? string.Empty;
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine() ?? string.Empty;
            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine() ?? string.Empty;
            Console.Write("Nhap uu tien: ");
            UuTien = Console.ReadLine() ?? string.Empty;
        }

        public virtual void HienThi()
        {
            Console.WriteLine("So bao danh: " + SoBaoDanh);
            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine("Dia chi: " + DiaChi);
            Console.WriteLine("Uu tien: " + UuTien);
        }

        public virtual double TongDiem() => 0;
        public virtual string GetKhoi() => "";
    }

    // ThiSinh khoi A: Thi Toán, Lý, Hoá (điểm chuẩn 15)
    internal class ThiSinhKhoiA : ThiSinh
    {
        public double Toan { get; set; }
        public double Ly { get; set; }
        public double Hoa { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap diem Toan: ");
            Toan = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhap diem Ly: ");
            Ly = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhap diem Hoa: ");
            Hoa = double.Parse(Console.ReadLine() ?? "0");
        }

        public override void HienThi()
        {
            Console.WriteLine("Khoi A");
            base.HienThi();
            Console.WriteLine("Diem Toan: " + Toan);
            Console.WriteLine("Diem Ly: " + Ly);
            Console.WriteLine("Diem Hoa: " + Hoa);
            Console.WriteLine("Tong diem: " + TongDiem());
        }

        public override double TongDiem() => Toan + Ly + Hoa;
        public override string GetKhoi() => "A";
    }

    // ThiSinh khoi B: Thi Toán, Hoá, Sinh (điểm chuẩn 16)
    internal class ThiSinhKhoiB : ThiSinh
    {
        public double Toan { get; set; }
        public double Hoa { get; set; }
        public double Sinh { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap diem Toan: ");
            Toan = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhap diem Hoa: ");
            Hoa = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhap diem Sinh: ");
            Sinh = double.Parse(Console.ReadLine() ?? "0");
        }

        public override void HienThi()
        {
            Console.WriteLine("Khoi B");
            base.HienThi();
            Console.WriteLine("Diem Toan: " + Toan);
            Console.WriteLine("Diem Hoa: " + Hoa);
            Console.WriteLine("Diem Sinh: " + Sinh);
            Console.WriteLine("Tong diem: " + TongDiem());
        }

        public override double TongDiem() => Toan + Hoa + Sinh;
        public override string GetKhoi() => "B";
    }

    // ThiSinh khoi C: Thi Văn, Sử, Địa (điểm chuẩn 13.5)
    internal class ThiSinhKhoiC : ThiSinh
    {
        public double Van { get; set; }
        public double Su { get; set; }
        public double Dia { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap diem Van: ");
            Van = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhap diem Su: ");
            Su = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhap diem Dia: ");
            Dia = double.Parse(Console.ReadLine() ?? "0");
        }

        public override void HienThi()
        {
            Console.WriteLine("Khoi C");
            base.HienThi();
            Console.WriteLine("Diem Van: " + Van);
            Console.WriteLine("Diem Su: " + Su);
            Console.WriteLine("Diem Dia: " + Dia);
            Console.WriteLine("Tong diem: " + TongDiem());
        }

        public override double TongDiem() => Van + Su + Dia;
        public override string GetKhoi() => "C";
    }

    // Lớp TuyenSinh: quản lý danh sách thí sinh và các chức năng nhập, tìm kiếm, hiển thị
    internal class TuyenSinh
    {
        private List<ThiSinh> dsThiSinh = new List<ThiSinh>();

        public void NhapThiSinh()
        {
            Console.WriteLine("Chon khoi thi:");
            Console.WriteLine("1. Khoi A");
            Console.WriteLine("2. Khoi B");
            Console.WriteLine("3. Khoi C");
            Console.Write("Nhap lua chon: ");
            int luaChon = int.Parse(Console.ReadLine() ?? "0");
            ThiSinh ts = luaChon switch
            {
                1 => new ThiSinhKhoiA(),
                2 => new ThiSinhKhoiB(),
                3 => new ThiSinhKhoiC(),
                _ => null
            };
            if (ts == null)
            {
                Console.WriteLine("Lua chon khong hop le.");
                return;
            }
            ts.Nhap();
            dsThiSinh.Add(ts);
        }

        public void HienThiTrungTuyen()
        {
            Console.WriteLine("Danh sach thi sinh trung tuyen:");
            foreach (var ts in dsThiSinh)
            {
                bool trungTuyen = false;
                if (ts is ThiSinhKhoiA && ts.TongDiem() >= 15)
                    trungTuyen = true;
                if (ts is ThiSinhKhoiB && ts.TongDiem() >= 16)
                    trungTuyen = true;
                if (ts is ThiSinhKhoiC && ts.TongDiem() >= 13.5)
                    trungTuyen = true;

                if (trungTuyen)
                {
                    ts.HienThi();
                    Console.WriteLine("-----");
                }
            }
        }

        public void TimKiemTheoSoBaoDanh()
        {
            Console.Write("Nhap so bao danh can tim: ");
            string soBD = Console.ReadLine() ?? string.Empty;
            bool found = false;
            foreach (var ts in dsThiSinh)
            {
                if (ts.SoBaoDanh.Equals(soBD, StringComparison.OrdinalIgnoreCase))
                {
                    ts.HienThi();
                    Console.WriteLine("-----");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Khong tim thay thi sinh voi so bao danh: " + soBD);
            }
        }

        public void Menu()
        {
            int luaChon = -1;
            do
            {
                Console.WriteLine("\nCHUONG TRINH TUYEN SINH");
                Console.WriteLine("1. Nhap thong tin thi sinh");
                Console.WriteLine("2. Hien thi thi sinh trung tuyen");
                Console.WriteLine("3. Tim kiem theo so bao danh");
                Console.WriteLine("4. Thoat chuong trinh");
                Console.Write("Chon chuc nang: ");
                luaChon = int.Parse(Console.ReadLine() ?? "0");
                switch (luaChon)
                {
                    case 1:
                        NhapThiSinh();
                        break;
                    case 2:
                        HienThiTrungTuyen();
                        break;
                    case 3:
                        TimKiemTheoSoBaoDanh();
                        break;
                    case 4:
                        Console.WriteLine("Thoat chuong trinh Bai 3.");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le.");
                        break;
                }
                if (luaChon != 4)
                {
                    Console.WriteLine("Nhan phim bat ky de tiep tuc...");
                    Console.ReadKey();
                }
            } while (luaChon != 4);
        }
    }

    // Lớp tĩnh Bai3 chứa hàm giao diện của bài 3
    internal static class Bai3
    {
        public static void B3()
        {
            Console.Clear();
            Console.WriteLine("------ Bai 3: Tuyen sinh ------");
            TuyenSinh ts = new TuyenSinh();
            ts.Menu();
        }
    }
}
*/
//bai 4 
/*
using System;
using System.Collections.Generic;

namespace BaiTap1
{
    // Đổi tên lớp Nguoi thành NguoiB4
    internal class NguoiB4
    {
        public string SoCMND { get; set; } = string.Empty;
        public string HoTen { get; set; } = string.Empty;
        public int Tuoi { get; set; }
        public int NamSinh { get; set; }
        public string NgheNghiep { get; set; } = string.Empty;

        public void Nhap()
        {
            Console.Write("Nhap so CMND: ");
            SoCMND = Console.ReadLine() ?? string.Empty;
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine() ?? string.Empty;
            Console.Write("Nhap tuoi: ");
            Tuoi = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhap nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhap nghe nghiep: ");
            NgheNghiep = Console.ReadLine() ?? string.Empty;
        }

        public void HienThi()
        {
            Console.WriteLine($"CMND: {SoCMND}, Ho ten: {HoTen}, Tuoi: {Tuoi}, Nam sinh: {NamSinh}, Nghe nghiep: {NgheNghiep}");
        }
    }

    // Lớp HoDan: quản lý thông tin 1 hộ dân gồm số nhà, số thành viên và danh sách NguoiB4
    internal class HoDan
    {
        public int SoThanhVien { get; set; }
        public string SoNha { get; set; } = string.Empty;
        public List<NguoiB4> DsNguoi { get; set; } = new List<NguoiB4>();

        public void Nhap()
        {
            Console.Write("Nhap so nha: ");
            SoNha = Console.ReadLine() ?? string.Empty;
            Console.Write("Nhap so thanh vien: ");
            SoThanhVien = int.Parse(Console.ReadLine() ?? "0");
            for (int i = 0; i < SoThanhVien; i++)
            {
                Console.WriteLine($"Nhap thong tin nguoi thu {i + 1}:");
                NguoiB4 n = new NguoiB4();
                n.Nhap();
                DsNguoi.Add(n);
            }
        }

        public void HienThi()
        {
            Console.WriteLine($"So nha: {SoNha}, So thanh vien: {SoThanhVien}");
            foreach (var n in DsNguoi)
            {
                n.HienThi();
                Console.WriteLine("-----");
            }
        }

        public bool TimKiemTheoHoTen(string ten)
        {
            foreach (var n in DsNguoi)
            {
                if (n.HoTen.IndexOf(ten, StringComparison.OrdinalIgnoreCase) >= 0)
                    return true;
            }
            return false;
        }
    }

    // Lớp KhuPho: quản lý danh sách các hộ dân
    internal class KhuPho
    {
        private List<HoDan> dsHoDan = new List<HoDan>();

        public void NhapHoDan()
        {
            Console.Write("Nhap so luong ho dan: ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap thong tin ho dan thu {i + 1}:");
                HoDan hd = new HoDan();
                hd.Nhap();
                dsHoDan.Add(hd);
            }
        }

        public void TimKiem()
        {
            Console.Write("Nhap ho ten hoac so nha can tim: ");
            string input = Console.ReadLine() ?? string.Empty;
            bool found = false;
            foreach (var hd in dsHoDan)
            {
                if (hd.SoNha.Equals(input, StringComparison.OrdinalIgnoreCase) || hd.TimKiemTheoHoTen(input))
                {
                    hd.HienThi();
                    Console.WriteLine("-----");
                    found = true;
                }
            }
            if (!found)
                Console.WriteLine("Khong tim thay ho dan voi key: " + input);
        }

        public void HienThiTatCa()
        {
            foreach (var hd in dsHoDan)
            {
                hd.HienThi();
                Console.WriteLine("-----");
            }
        }

        public void Menu()
        {
            int luaChon = -1;
            do
            {
                Console.WriteLine("\nCHUONG TRINH QUAN LY HOA DAN");
                Console.WriteLine("1. Nhap danh sach ho dan");
                Console.WriteLine("2. Tim kiem ho dan theo ho ten hoac so nha");
                Console.WriteLine("3. Hien thi tat ca ho dan");
                Console.WriteLine("4. Thoat chuong trinh");
                Console.Write("Chon chuc nang: ");
                luaChon = int.Parse(Console.ReadLine() ?? "0");
                switch (luaChon)
                {
                    case 1:
                        NhapHoDan();
                        break;
                    case 2:
                        TimKiem();
                        break;
                    case 3:
                        HienThiTatCa();
                        break;
                    case 4:
                        Console.WriteLine("Thoat chuong trinh Bai 4.");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le.");
                        break;
                }
                if (luaChon != 4)
                {
                    Console.WriteLine("Nhan phim bat ky de tiep tuc...");
                    Console.ReadKey();
                }
            } while (luaChon != 4);
        }
    }

    // Lớp tĩnh Bai4 chứa hàm giao diện của bài 4
    internal static class Bai4
    {
        public static void B4()
        {
            Console.Clear();
            Console.WriteLine("------ Bai 4: Quan ly ho dan ------");
            KhuPho kp = new KhuPho();
            kp.Menu();
        }
    }
}
*/
//bai 5 
/*
using System;
using System.Collections.Generic;

namespace BaiTap1
{
    // Lớp Nguoi: quản lý thông tin cá nhân của khách trọ
    internal class Nguoi
    {
        public string HoTen { get; set; } = string.Empty;
        public int NamSinh { get; set; }
        public string SoCMND { get; set; } = string.Empty;

        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine() ?? string.Empty;
            Console.Write("Nhap nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhap so CMND: ");
            SoCMND = Console.ReadLine() ?? string.Empty;
        }

        public void HienThi()
        {
            Console.WriteLine($"Ho ten: {HoTen}, Nam sinh: {NamSinh}, So CMND: {SoCMND}");
        }
    }

    // Lớp KhachTro: quản lý thông tin khách trọ (so ngay tro, loai phong, gia phong, và thông tin khach)
    internal class KhachTro
    {
        public int SoNgayTro { get; set; }
        public string LoaiPhong { get; set; } = string.Empty;
        public double GiaPhong { get; set; }
        public Nguoi Khach { get; set; } = new Nguoi();

        public void Nhap()
        {
            Console.WriteLine("Nhap thong tin khach tro:");
            Khach.Nhap();
            Console.Write("Nhap so ngay tro: ");
            SoNgayTro = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nhap loai phong: ");
            LoaiPhong = Console.ReadLine() ?? string.Empty;
            Console.Write("Nhap gia phong: ");
            GiaPhong = double.Parse(Console.ReadLine() ?? "0");
        }

        public double TinhTien() => SoNgayTro * GiaPhong;

        public void HienThi()
        {
            Console.WriteLine("Thong tin khach tro:");
            Khach.HienThi();
            Console.WriteLine($"So ngay tro: {SoNgayTro}, Loai phong: {LoaiPhong}, Gia phong: {GiaPhong}");
            Console.WriteLine("Tong tien phai thanh toan: " + TinhTien());
        }
    }

    // Lớp QuanLyKhachSan: quản lý danh sách khách trọ
    internal class QuanLyKhachSan
    {
        private List<KhachTro> dsKhachTro = new List<KhachTro>();

        public void NhapKhachTro()
        {
            Console.Write("Nhap so luong khach tro: ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap thong tin khach tro thu {i + 1}:");
                KhachTro kt = new KhachTro();
                kt.Nhap();
                dsKhachTro.Add(kt);
            }
        }

        public void HienThiKhachTro()
        {
            if (dsKhachTro.Count == 0)
            {
                Console.WriteLine("Danh sach khach tro trong!");
                return;
            }
            foreach (var kt in dsKhachTro)
            {
                kt.HienThi();
                Console.WriteLine("-----");
            }
        }

        public void TimKiemTheoHoTen()
        {
            Console.Write("Nhap ho ten can tim: ");
            string ten = Console.ReadLine() ?? string.Empty;
            bool found = false;
            foreach (var kt in dsKhachTro)
            {
                if (kt.Khach.HoTen.IndexOf(ten, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    kt.HienThi();
                    Console.WriteLine("-----");
                    found = true;
                }
            }
            if (!found)
                Console.WriteLine("Khong tim thay khach tro voi ho ten: " + ten);
        }

        public void TinhTienThanhToan()
        {
            Console.WriteLine("Tien thanh toan cho cac khach tro:");
            foreach (var kt in dsKhachTro)
            {
                Console.WriteLine($"Khach: {kt.Khach.HoTen} - Tien thanh toan: {kt.TinhTien()}");
            }
        }

        public void Menu()
        {
            int luaChon = -1;
            do
            {
                Console.WriteLine("\nCHUONG TRINH QUAN LY KHACH SAN");
                Console.WriteLine("1. Nhap thong tin khach tro");
                Console.WriteLine("2. Hien thi danh sach khach tro");
                Console.WriteLine("3. Tim kiem theo ho ten");
                Console.WriteLine("4. Tinh tien thanh toan khi tra phong");
                Console.WriteLine("5. Thoat");
                Console.Write("Chon chuc nang: ");
                luaChon = int.Parse(Console.ReadLine() ?? "0");
                switch (luaChon)
                {
                    case 1:
                        NhapKhachTro();
                        break;
                    case 2:
                        HienThiKhachTro();
                        break;
                    case 3:
                        TimKiemTheoHoTen();
                        break;
                    case 4:
                        TinhTienThanhToan();
                        break;
                    case 5:
                        Console.WriteLine("Thoat chuong trinh Bai 5.");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le.");
                        break;
                }
                if (luaChon != 5)
                {
                    Console.WriteLine("Nhan phim bat ky de tiep tuc...");
                    Console.ReadKey();
                }
            } while (luaChon != 5);
        }
    }

    // Lớp tĩnh Bai5 chứa hàm giao diện của bài 5
    internal static class Bai5
    {
        public static void B5()
        {
            Console.Clear();
            Console.WriteLine("------ Bai 5: Quan ly khach san ------");
            QuanLyKhachSan ql = new QuanLyKhachSan();
            ql.Menu();
        }
    }
}
/*