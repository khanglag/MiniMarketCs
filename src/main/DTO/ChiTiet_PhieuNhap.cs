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
    public ChiTiet_PhieuNhapDTO(string MaPhieuNhap, string MaHangNhap, string TenHangNhap, double VAT, int SoLuong, string DonVi, int GiaNhap, int TongTienNhap, bool TonTai)
    {
        this.MaPhieuNhap = MaPhieuNhap;
        this.MaHangNhap = MaHangNhap;
        this.TenHangNhap = TenHangNhap;
        this.VAT = VAT;
        this.SoLuong = SoLuong;
        this.DonVi = DonVi;
        this.GiaNhap = GiaNhap;
        this.TongTienNhap = TongTienNhap;
        this.TonTai = TonTai;
    }
    public string MaPhieuNhap { get; set; }
    public string MaHangNhap { get; set; }
    public string TenHangNhap { get; set; }
    public double VAT { get; set; }
    public int SoLuong { get; set; }
    public string Doni { get; set; }
    public int GiaNhap { get; set; }
    public int TongTienNhap { get; set; }
    public bool TonTai { get; set; }
    public void Display()
    {
        Console.WriteLine($"Ma phieu nhap :{MaPhieuNhap}");
        Console.WriteLine($"Ma hang nhap :{MaHangNhap}");
        Console.WriteLine($"Ten hang nhap :{TenHang Nhap}");
        Console.WriteLine($"VAT :{VAT}");
        Console.WriteLine($"So luong:{SoLuong}");
        Console.WriteLine($"Don vi :{DonVi}");
        Console.WriteLine($"Gia nhap :{GiaNhap}");
        Console.WriteLine($"Tong tien nhap :{TongTienNhap}");
    }

}