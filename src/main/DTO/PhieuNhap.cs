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

    public PhieuNhapDTO(string MaPhieuNhap, string MaNhanVien, string MaHangNhap, string TenHangNhap, string MaNhaCungCap, DateTime ThoiGianNhap, int SoLuong, int VAT, int TongTien, bool TonTai)
    {
        this.MaPhieuNhap = MaPhieuNhap;
        this.MaNhanVien = MaNhanVien;
        this.MaNhaCungCap = MaNhaCungCap;
        this.ThoiGianLap = ThoiGianLap;
        this.VAT=VAT;
        this.SoMatHang=SoMatHang;
        this.TongTien= TongTien;
        this.TonTai = TonTai;
    }

    public string MaPhieuNhap {get; set;}
    public string MaNhanVien{get; set;}
    public string MaNhaCungCap {get; set;}
    public DateTime ThoiGianLap {get; set;}
    public double VAT {get; set;}
    public int SoMatHang {get; set;}


    
    public void Display() {
        Console.WriteLine($"Ma phieu nhap :{MaPhieuNhap}");
        Console.WriteLine($"Ma nhan vien :{MaNhanVien}");
        Console.WriteLine($"Ma hang nhap :{MaHangNhap}");
        Console.WriteLine($"Ten hang nhap :{TenHangNhap}");
        Console.WriteLine($"Ma nha cung cap :{MaNhaCungCap}");
        Console.WriteLine($"Thoi gian nhap :{ThoiGianNhap}");
        Console.WriteLine($"So luong :{SoLuong}");
        Console.WriteLine($"VAT :{VAT}");
        Console.WriteLine($"Tong tien :{TongTien}");    
    }
}