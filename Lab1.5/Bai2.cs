using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Hinh
{
    public abstract double TinhChuVi();
    public abstract double TinhDienTich();
}

class HinhTron : Hinh
{
    public double BanKinh { get; set; }

    public HinhTron(double banKinh)
    {
        BanKinh = banKinh;
    }

    public override double TinhChuVi() => 2 * Math.PI * BanKinh;
    public override double TinhDienTich() => Math.PI * BanKinh * BanKinh;
}

class HinhVuong : Hinh
{
    public double Canh { get; set; }

    public HinhVuong(double canh)
    {
        Canh = canh;
    }

    public override double TinhChuVi() => 4 * Canh;
    public override double TinhDienTich() => Canh * Canh;
}

class HinhTamGiac : Hinh
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public HinhTamGiac(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public override double TinhChuVi() => A + B + C;
    public override double TinhDienTich()
    {
        double p = TinhChuVi() / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
}

class HinhChuNhat : Hinh
{
    public double Dai { get; set; }
    public double Rong { get; set; }

    public HinhChuNhat(double dai, double rong)
    {
        Dai = dai;
        Rong = rong;
    }

    public override double TinhChuVi() => 2 * (Dai + Rong);
    public override double TinhDienTich() => Dai * Rong;
}

class Program
{
    static void Main()
    {
        List<Hinh> danhSachHinh = new List<Hinh>
        {
            new HinhTron(5),
            new HinhVuong(4),
            new HinhTamGiac(3, 4, 5),
            new HinhChuNhat(6, 7)
        };

        double tongChuVi = 0;
        double tongDienTich = 0;

        foreach (var hinh in danhSachHinh)
        {
            tongChuVi += hinh.TinhChuVi();
            tongDienTich += hinh.TinhDienTich();
        }

        Console.WriteLine($"Tổng chu vi: {tongChuVi}");
        Console.WriteLine($"Tổng diện tích: {tongDienTich}");
    }
}
