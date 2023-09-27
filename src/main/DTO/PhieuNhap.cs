using System;
public class PhieuNhapDTO
{
    private string MaPhieuNhap;
    private string MaNhanVien;
    private string MaNhaCungCap;
    private DateTime ThoiGianLap;
    private double VAT;
    private int SoMatHang;
    private int TongTien;
    private bool TonTai;
    public PhieuNhapDTO()
    {

    }

    public PhieuNhapDTO(string maPhieuNhap, string maNhanVien, string maNhaCungCap, DateTime thoiGianLap, double vAT, int soMatHang, int tongTien, bool tonTai)
    {
        MaPhieuNhap1 = maPhieuNhap;
        MaNhanVien1 = maNhanVien;
        MaNhaCungCap1 = maNhaCungCap;
        ThoiGianLap1 = thoiGianLap;
        VAT1 = vAT;
        SoMatHang1 = soMatHang;
        TongTien1 = tongTien;
        TonTai1 = tonTai;
    }

    public string MaPhieuNhap1 { get => MaPhieuNhap; set => MaPhieuNhap = value; }
    public string MaNhanVien1 { get => MaNhanVien; set => MaNhanVien = value; }
    public string MaNhaCungCap1 { get => MaNhaCungCap; set => MaNhaCungCap = value; }
    public DateTime ThoiGianLap1 { get => ThoiGianLap; set => ThoiGianLap = value; }
    public double VAT1 { get => VAT; set => VAT = value; }
    public int SoMatHang1 { get => SoMatHang; set => SoMatHang = value; }
    public int TongTien1 { get => TongTien; set => TongTien = value; }
    public bool TonTai1 { get => TonTai; set => TonTai = value; }

    public void Display() {
        Console.WriteLine($"Ma phieu nhap :{MaPhieuNhap1}");
        Console.WriteLine($"Ma nhan vien :{MaNhanVien1}");
        Console.WriteLine($"Ma nha cung cap :{MaNhaCungCap1}");
        Console.WriteLine($"Thoi gian nhap :{ThoiGianLap1}");
        Console.WriteLine($"VAT :{VAT1}");
        Console.WriteLine($"So mat hang :{SoMatHang1}");
        Console.WriteLine($"Tong tien :{TongTien1}");    
    }
}