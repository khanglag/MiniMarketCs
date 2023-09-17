using System;
public class NhanVienDTO
{
    private string MaNhanVien;
    private string TenNhanVien;
    private DateOnly NgaySinh;
    private string GioiTinh;
    private string CCCD;
    private string SDT;
    private string Email;
    private string DiaChi;
    private string MaQuyen;
    private DateOnly NgayBatDau;
    private DateOnly NgayNghiViec;
    private int HeSoLuong;
    private bool TonTai;

    public NhanVienDTO()
    {

    }

    public NhanVienDTO(string maNhanVien, string tenNhanVien, DateOnly ngaySinh, string gioiTinh, string cCCD, string sDT, string email, string diaChi, string maQuyen, DateOnly ngayBatDau, DateOnly ngayNghiViec, int heSoLuong, bool tonTai)
    {
        MaNhanVien1 = maNhanVien;
        TenNhanVien1 = tenNhanVien;
        NgaySinh1 = ngaySinh;
        GioiTinh1 = gioiTinh;
        CCCD1 = cCCD;
        SDT1 = sDT;
        Email1 = email;
        DiaChi1 = diaChi;
        MaQuyen1 = maQuyen;
        NgayBatDau1 = ngayBatDau;
        NgayNghiViec1 = ngayNghiViec;
        HeSoLuong1 = heSoLuong;
        TonTai1 = tonTai;
    }

    public string MaNhanVien1 { get => MaNhanVien; set => MaNhanVien = value; }
    public string TenNhanVien1 { get => TenNhanVien; set => TenNhanVien = value; }
    public DateOnly NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
    public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
    public string CCCD1 { get => CCCD; set => CCCD = value; }
    public string SDT1 { get => SDT; set => SDT = value; }
    public string Email1 { get => Email; set => Email = value; }
    public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
    public string MaQuyen1 { get => MaQuyen; set => MaQuyen = value; }
    public DateOnly NgayBatDau1 { get => NgayBatDau; set => NgayBatDau = value; }
    public DateOnly NgayNghiViec1 { get => NgayNghiViec; set => NgayNghiViec = value; }
    public int HeSoLuong1 { get => HeSoLuong; set => HeSoLuong = value; }
    public bool TonTai1 { get => TonTai; set => TonTai = value; }
    public void Display() {
        Console.WriteLine($"Ma nhan vien :{MaNhanVien}");
        Console.WriteLine($"Ten nhan nhan vien :{TenNhanVien}");
        Console.WriteLine($"Ngay sinh :{NgaySinh}");
        Console.WriteLine($"Gioi tinh :{GioiTinh}");
        Console.WriteLine($"So can cuoc cong dan :{CCCD}");
        Console.WriteLine($"So dien thoai :{SDT}");
        Console.WriteLine($"Email :{Email}");
        Console.WriteLine($"Dia chi :{DiaChi}");
        Console.WriteLine($"Ma quyen :{MaQuyen}");
        Console.WriteLine($"Ngay bat dau lam viec :{NgayBatDau}");
        Console.WriteLine($"Ngay nghi viec :{NgayNghiViec}");
        Console.WriteLine($"He so luong :{HeSoLuong}");
    }
}