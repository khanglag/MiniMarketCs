using System;
public class KhachHangDTO
{
    private string MaKhachHang;
    private string TenKhachHang;
    private DateOnly NgaySinh;
    private string SDT;
    private string CCCD;
    private string DiaChi;
    private bool TonTai;
    public KhachHangDTO()
    {

    }

    public KhachHangDTO(string maKhachHang, string tenKhachHang, DateOnly ngaySinh, string sDT, string cCCD, string diaChi, bool tonTai)
    {
        MaKhachHang1 = maKhachHang;
        TenKhachHang1 = tenKhachHang;
        NgaySinh1 = ngaySinh;
        SDT1 = sDT;
        CCCD1 = cCCD;
        DiaChi1 = diaChi;
        TonTai1 = tonTai;
    }

    public string MaKhachHang1 { get => MaKhachHang; set => MaKhachHang = value; }
    public string TenKhachHang1 { get => TenKhachHang; set => TenKhachHang = value; }
    public DateOnly NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
    public string SDT1 { get => SDT; set => SDT = value; }
    public string CCCD1 { get => CCCD; set => CCCD = value; }
    public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
    public bool TonTai1 { get => TonTai; set => TonTai = value; }

    public void Display() {
        Console.WriteLine($"Ma khach hang :{MaKhachHang1}");
        Console.WriteLine($"Ten khach hang :{TenKhachHang1}");
        Console.WriteLine($"Ngay sinh :{NgaySinh1}");
        Console.WriteLine($"So dien thoai :{SDT1}");
        Console.WriteLine($"Can cuoc cong dan :{CCCD1}");
        Console.WriteLine($"Dia chi :{DiaChi1}");
    }
}