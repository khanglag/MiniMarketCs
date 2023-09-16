using System;
public class HangHoaDTO
{
    private string MaSanPham;
    private string TenSanPham;
    private string MaNhomSanPham;
    private DateOnly NgaySanXuat;
    private DateOnly HanSuDung;
    private string NhaCungCap;
    private string DonVi;
    private int GiaNhap;
    private int GiaBan;
    private int SoLuong;
    private string XuatXu;
    private bool TonTai;

    public HangHoaDTO()
    {

    }

    public HangHoaDTO(string maSanPham, string tenSanPham, string maNhomSanPham, DateOnly ngaySanXuat, DateOnly hanSuDung, string nhaCungCap, string donVi, int giaNhap, int giaBan, int soLuong, string xuatXu, bool tonTai)
    {
        MaSanPham1 = maSanPham;
        TenSanPham1 = tenSanPham;
        MaNhomSanPham1 = maNhomSanPham;
        NgaySanXuat1 = ngaySanXuat;
        HanSuDung1 = hanSuDung;
        NhaCungCap1 = nhaCungCap;
        DonVi1 = donVi;
        GiaNhap1 = giaNhap;
        GiaBan1 = giaBan;
        SoLuong1 = soLuong;
        XuatXu1 = xuatXu;
        TonTai1 = tonTai;
    }

    public string MaSanPham1 { get => MaSanPham; set => MaSanPham = value; }
    public string TenSanPham1 { get => TenSanPham; set => TenSanPham = value; }
    public string MaNhomSanPham1 { get => MaNhomSanPham; set => MaNhomSanPham = value; }
    public DateOnly NgaySanXuat1 { get => NgaySanXuat; set => NgaySanXuat = value; }
    public DateOnly HanSuDung1 { get => HanSuDung; set => HanSuDung = value; }
    public string NhaCungCap1 { get => NhaCungCap; set => NhaCungCap = value; }
    public string DonVi1 { get => DonVi; set => DonVi = value; }
    public int GiaNhap1 { get => GiaNhap; set => GiaNhap = value; }
    public int GiaBan1 { get => GiaBan; set => GiaBan = value; }
    public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
    public string XuatXu1 { get => XuatXu; set => XuatXu = value; }
    public bool TonTai1 { get => TonTai; set => TonTai = value; }
}