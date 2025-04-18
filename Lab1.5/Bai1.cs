using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PhanSo
{
    public int TuSo { get; set; }
    public int MauSo { get; set; }

    public PhanSo(int tuSo, int mauSo)
    {
        TuSo = tuSo;
        MauSo = mauSo;
        RutGon();
    }

    public void NhapPhanSo()
    {
        Console.Write("Nhập tử số: ");
        TuSo = int.Parse(Console.ReadLine());
        Console.Write("Nhập mẫu số: ");
        MauSo = int.Parse(Console.ReadLine());
        RutGon();
    }

    public PhanSo CongHaiPhanSo(PhanSo other)
    {
        int newTu = TuSo * other.MauSo + other.TuSo * MauSo;
        int newMau = MauSo * other.MauSo;
        return new PhanSo(newTu, newMau);
    }

    private void RutGon()
    {
        int ucln = TimUCLN(TuSo, MauSo);
        TuSo /= ucln;
        MauSo /= ucln;
        if (MauSo < 0)
        {
            TuSo *= -1;
            MauSo *= -1;
        }
    }

    private int TimUCLN(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public override string ToString()
    {
        return $"{TuSo}/{MauSo}";
    }
}

class Bai1
{
    static void Main()
    {
        List<PhanSo> danhSachPhanSo = new List<PhanSo>();

        Console.WriteLine("Nhập số phân số: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            PhanSo ps = new PhanSo(0, 1);
            ps.NhapPhanSo();
            danhSachPhanSo.Add(ps);
        }

        PhanSo tong = new PhanSo(0, 1);
        foreach (var ps in danhSachPhanSo)
        {
            tong = tong.CongHaiPhanSo(ps);
        }

        Console.WriteLine($"Tổng các phân số: {tong}");
    }
}