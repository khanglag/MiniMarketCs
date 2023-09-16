using System;
public class PhieuNhapDTO
{
    private string MaPhieuNhap;
    private string MaNhanVien;
    private string MaHangNhap;
    private string TenHangNhap;
    private string MaNhaCungCap;
    private DateTime ThoiGianNhap;
    private int SoLuong;
    private int VAT;
    private int TongTien;
    private bool TonTai;
    public PhieuNhapDTO()
    {

    }

    public PhieuNhapDTO(string maPhieuNhap, string maNhanVien, string maHangNhap, string tenHangNhap, string maNhaCungCap, DateTime thoiGianNhap, int soLuong, int vAT, int tongTien, bool tonTai)
    {
        MaPhieuNhap1 = maPhieuNhap;
        MaNhanVien1 = maNhanVien;
        MaHangNhap1 = maHangNhap;
        TenHangNhap1 = tenHangNhap;
        MaNhaCungCap1 = maNhaCungCap;
        ThoiGianNhap1 = thoiGianNhap;
        SoLuong1 = soLuong;
        VAT1 = vAT;
        TongTien1 = tongTien;
        TonTai1 = tonTai;
    }

    public string MaPhieuNhap1 { get => MaPhieuNhap; set => MaPhieuNhap = value; }
    public string MaNhanVien1 { get => MaNhanVien; set => MaNhanVien = value; }
    public string MaHangNhap1 { get => MaHangNhap; set => MaHangNhap = value; }
    public string TenHangNhap1 { get => TenHangNhap; set => TenHangNhap = value; }
    public string MaNhaCungCap1 { get => MaNhaCungCap; set => MaNhaCungCap = value; }
    public DateTime ThoiGianNhap1 { get => ThoiGianNhap; set => ThoiGianNhap = value; }
    public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
    public int VAT1 { get => VAT; set => VAT = value; }
    public int TongTien1 { get => TongTien; set => TongTien = value; }
    public bool TonTai1 { get => TonTai; set => TonTai = value; }
}