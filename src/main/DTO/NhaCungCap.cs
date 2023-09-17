using System;
using System.Diagnostics;

public class NhaCungCapDTO
{
    private string MaNhaCungCap;
    private string TenNhaCungCap;
    private string SDT;
    private string DiaChi;
    private bool TonTai;

    public NhaCungCapDTO()
    {

    }

    public NhaCungCapDTO(string maNhaCungCap, string tenNhaCungCap, string sDT, string diaChi, bool tonTai)
    {
        MaNhaCungCap1 = maNhaCungCap;
        TenNhaCungCap1 = tenNhaCungCap;
        SDT1 = sDT;
        DiaChi1 = diaChi;
        TonTai1 = tonTai;
    }

    public string MaNhaCungCap1 { get => MaNhaCungCap; set => MaNhaCungCap = value; }
    public string TenNhaCungCap1 { get => TenNhaCungCap; set => TenNhaCungCap = value; }
    public string SDT1 { get => SDT; set => SDT = value; }
    public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
    public bool TonTai1 { get => TonTai; set => TonTai = value; }
    public void Display() {
        Console.WriteLine($"Ma nha cung cap :{MaNhaCungCap}");
        Console.WriteLine($"Ten nha cung cap :{TenNhaCungCap}");
        Console.WriteLine($"So dien thoai :{SDT}");
        Console.WriteLine($"Dia chi :{DiaChi}");
    }
}
public class Test
{
    public static void Main(string[] args)
    {
        NhaCungCapDTO ncc = new NhaCungCapDTO("31221", "nam", "4545", "ha noi", true);


    }
}