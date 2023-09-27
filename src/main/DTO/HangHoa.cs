using System;
public class HangHoaDTO
{
    private string MaSanPham;
    private string TenSanPham;
    private string MaAnh;
    private string MaNhaCungCap;
    private string DonVi;
    private int GiaNhap;
    private int GiaBan;
    private int SoLuong;
    private string XuatXu;
    private bool TonTai;






    public HangHoaDTO()
    {

    }

    public HangHoaDTO(string maSanPham, string tenSanPham, string maAnh, string maNhaCungCap, string donVi, int giaNhap, int giaBan, int soLuong, string xuatXu, bool tonTai)
    {
        MaSanPham1 = maSanPham;
        TenSanPham1 = tenSanPham;
        MaAnh1 = maAnh;
        MaNhaCungCap1 = maNhaCungCap;
        DonVi1 = donVi;
        GiaNhap1 = giaNhap;
        GiaBan1 = giaBan;
        SoLuong1 = soLuong;
        XuatXu1 = xuatXu;
        TonTai1 = tonTai;
    }

    public string MaSanPham1 { get => MaSanPham; set => MaSanPham = value; }
    public string TenSanPham1 { get => TenSanPham; set => TenSanPham = value; }
    public string MaAnh1 { get => MaAnh; set => MaAnh = value; }
    public string MaNhaCungCap1 { get => MaNhaCungCap; set => MaNhaCungCap = value; }
    public string DonVi1 { get => DonVi; set => DonVi = value; }
    public int GiaNhap1 { get => GiaNhap; set => GiaNhap = value; }
    public int GiaBan1 { get => GiaBan; set => GiaBan = value; }
    public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
    public string XuatXu1 { get => XuatXu; set => XuatXu = value; }
    public bool TonTai1 { get => TonTai; set => TonTai = value; }

    public void Display()
    {
        Console.WriteLine($"Ma san pham :{MaSanPham1}");
        Console.WriteLine($"Ten san pham :{TenSanPham1}");
        Console.WriteLine($"Ma anh :{MaAnh1}");
        Console.WriteLine($"Ma Nha cung cap:{MaNhaCungCap1}");
        Console.WriteLine($"Don vi :{DonVi1}");
        Console.WriteLine($"Gia nhap :{GiaNhap1}");
        Console.WriteLine($"Gia ban :{GiaBan1}");
        Console.WriteLine($"So luong :{SoLuong1}");
        Console.WriteLine($"Xuat xu :{XuatXu1}");
    }
}