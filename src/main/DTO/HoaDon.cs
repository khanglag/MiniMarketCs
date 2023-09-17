using System;
public class HoaDonDTO
{
    private int SoHoaDon;
    private string MaNhanVien;
    private DateTime ThoiGianLap;
    private string MaKhachHang;
    private int TongHoaDon;
    private int ChietKhau;
    private int ThanhToan;
    private int TienKhachDua;
    private int TienTraKhach;
    private bool TonTai;
    public HoaDonDTO()
    {

    }

    public HoaDonDTO(int soHoaDon, string maNhanVien, DateTime thoiGianLap, string maKhachHang, int tongHoaDon, int chietKhau, int thanhToan, int tienKhachDua, int tienTraKhach, bool tonTai)
    {
        SoHoaDon1 = soHoaDon;
        MaNhanVien1 = maNhanVien;
        ThoiGianLap1 = thoiGianLap;
        MaKhachHang1 = maKhachHang;
        TongHoaDon1 = tongHoaDon;
        ChietKhau1 = chietKhau;
        ThanhToan1 = thanhToan;
        TienKhachDua1 = tienKhachDua;
        TienTraKhach1 = tienTraKhach;
        TonTai1 = tonTai;
    }

    public int SoHoaDon1 { get => SoHoaDon; set => SoHoaDon = value; }
    public string MaNhanVien1 { get => MaNhanVien; set => MaNhanVien = value; }
    public DateTime ThoiGianLap1 { get => ThoiGianLap; set => ThoiGianLap = value; }
    public string MaKhachHang1 { get => MaKhachHang; set => MaKhachHang = value; }
    public int TongHoaDon1 { get => TongHoaDon; set => TongHoaDon = value; }
    public int ChietKhau1 { get => ChietKhau; set => ChietKhau = value; }
    public int ThanhToan1 { get => ThanhToan; set => ThanhToan = value; }
    public int TienKhachDua1 { get => TienKhachDua; set => TienKhachDua = value; }
    public int TienTraKhach1 { get => TienTraKhach; set => TienTraKhach = value; }
    public bool TonTai1 { get => TonTai; set => TonTai = value; }
    public void Display() {
        Console.WriteLine($"So hoa don :{SoHoaDon}");
        Console.WriteLine($"Ma nhan vien :{MaNhanVien}");
        Console.WriteLine($"Thoi gian lap hoa don :{ThoiGianLap}");
        Console.WriteLine($"Ma khach hang :{MaKhachHang}");
        Console.WriteLine($"Tong hoa don:{TongHoaDon}");
        Console.WriteLine($"Chiet khau :{ChietKhau}");
        Console.WriteLine($"Thanh toan :{ThanhToan}");
        Console.WriteLine($"Tien khach dua :{TienKhachDua}");
        Console.WriteLine($"Tien tra khach :{TienTraKhach}");
    }
}