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

    public NhaCungCapDTO(string MaNhaCungCap, string TenNhaCungCap,string SDT, string DiaChi, bool TonTai)
    {
       this.MaNhaCungCap = MaNhaCungCap;
       this.TenNhaCungCap = TenNhaCungCap;
       this.SDT = SDT;
       this.DiaChi = DiaChi;
       this.TonTai = TonTai;
    }

    public string MaNhaCungCap {get; set;}
    public string TenNhaCungCap {get; set;}
    public string SDT {get; set;}
    public string DiaChi {get;set;}
    public bool TonTai {get; set;}
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