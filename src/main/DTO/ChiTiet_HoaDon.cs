using System;
public class ChiTiet_HoaDonDTO {
    private int SoHoaDon;
    private string MaSanPham;
    private int SoLuong;
    private bool TonTai;
    public ChiTiet_HoaDonDTO(){

    }
    public ChiTiet_HoaDonDTO(int soHoaDon, string maSanPham,int soLuong, bool tonTai) {
        SoHoaDon1 = soHoaDon;
        MaSanPham1 = maSanPham;
        SoLuong1 = soLuong;
        TonTai1 = tonTai;
    }

    public int SoHoaDon1 { get => SoHoaDon; set => SoHoaDon = value; }
    public String MaSanPham1 { get => MaSanPham; set => MaSanPham = value; }
    public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
    public bool TonTai1 { get => TonTai; set => TonTai = value; }
    public void Display() {
        Console.WriteLine($"So hoa don :{SoHoaDon1}");
        Console.WriteLine($"Ma san pham :{MaSanPham1}");
        Console.WriteLine($"So luong :{SoLuong1}");
    }
}