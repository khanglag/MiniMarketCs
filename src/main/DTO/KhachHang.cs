using System;
public class KhachHangDTO
{
    private string MaKhachHang;
    private string TenKhachHang;
    private DateOnly NgaySinh;
    private string GioiTinh;
    private string SDT;
    private string DiaChi;
    private bool TonTai;
    public KhachHangDTO()
    {

    }

    public KhachHangDTO(string maKhachHang, string tenKhachHang, DateOnly ngaySinh, string gioiTinh, string sDT, string diaChi, bool tonTai)
    {
        MaKhachHang1 = maKhachHang;
        TenKhachHang1 = tenKhachHang;
        NgaySinh1 = ngaySinh;
        GioiTinh1 = gioiTinh;
        SDT1 = sDT;
        DiaChi1 = diaChi;
        TonTai1 = tonTai;
    }

    public string MaKhachHang1 { get => MaKhachHang; set => MaKhachHang = value; }
    public string TenKhachHang1 { get => TenKhachHang; set => TenKhachHang = value; }
    public DateOnly NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
    public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
    public string SDT1 { get => SDT; set => SDT = value; }
    public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
    public bool TonTai1 { get => TonTai; set => TonTai = value; }
}