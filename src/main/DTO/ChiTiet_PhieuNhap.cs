using System;
public class ChiTiet_PhieuNhapDTO
{
    private string MaPhieuNhap;
    private string MaHangNhap;
    private string TenHangNhap;
    private double VAT;
    private int SoLuong;
    private string DonVi;
    private int GiaNhap;
    private int TongTienNhap;
    private bool TonTai;
    public ChiTiet_PhieuNhapDTO()
    {

    }

    public ChiTiet_PhieuNhapDTO(string maPhieuNhap, string maHangNhap, string tenHangNhap, double vAT, int soLuong, string donVi, int giaNhap, int tongTienNhap, bool tonTai)
    {
        MaPhieuNhap1 = maPhieuNhap;
        MaHangNhap1 = maHangNhap;
        TenHangNhap1 = tenHangNhap;
        VAT1 = vAT;
        SoLuong1 = soLuong;
        DonVi1 = donVi;
        GiaNhap1 = giaNhap;
        TongTienNhap1 = tongTienNhap;
        TonTai1 = tonTai;
    }

    public string MaPhieuNhap1 { get => MaPhieuNhap; set => MaPhieuNhap = value; }
    public string MaHangNhap1 { get => MaHangNhap; set => MaHangNhap = value; }
    public string TenHangNhap1 { get => TenHangNhap; set => TenHangNhap = value; }
    public double VAT1 { get => VAT; set => VAT = value; }
    public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
    public string DonVi1 { get => DonVi; set => DonVi = value; }
    public int GiaNhap1 { get => GiaNhap; set => GiaNhap = value; }
    public int TongTienNhap1 { get => TongTienNhap; set => TongTienNhap = value; }
    public bool TonTai1 { get => TonTai; set => TonTai = value; }

    public void Display()
    {
        Console.WriteLine($"Ma phieu nhap :{MaPhieuNhap1}");
        Console.WriteLine($"Ma hang nhap :{MaHangNhap1}");
        Console.WriteLine($"Ten hang nhap :{TenHangNhap1}");
        Console.WriteLine($"VAT :{VAT1}");
        Console.WriteLine($"So luong:{SoLuong1}");
        Console.WriteLine($"Don vi :{DonVi1}");
        Console.WriteLine($"Gia nhap :{GiaNhap1}");
        Console.WriteLine($"Tong tien nhap :{TongTienNhap1}");
    }

}