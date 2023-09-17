using System;
public class NhomHangDTO
{
    private string MaNhomHang;
    private string TenNhomHang;
    private bool TonTai;

    public NhomHangDTO()
    {

    }

    public NhomHangDTO(string maNhomHang, string tenNhomHang, bool tonTai)
    {
        MaNhomHang1 = maNhomHang;
        TenNhomHang1 = tenNhomHang;
        TonTai1 = tonTai;
    }

    public string MaNhomHang1 { get => MaNhomHang; set => MaNhomHang = value; }
    public string TenNhomHang1 { get => TenNhomHang; set => TenNhomHang = value; }
    public bool TonTai1 { get => TonTai; set => TonTai = value; }
    public void Display() {
        Console.WriteLine($"Ma nhom hang :{MaNhomHang}");
        Console.WriteLine($"Ten nhom hang :{TenNhomHang}");
    }
}