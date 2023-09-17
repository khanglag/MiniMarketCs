using System;
using System.Diagnostics;

public class BanGiaoDTO
{
    private string MaCa1;
    private string MaCa2;
    private int TienBanGiao;
    private int TienHeThong;
    private string MaNhanVien1;
    private string MaNhanVien2;
    private DateTime ThoiGianBanGiao;

    private bool TonTai;

    public BanGiaoDTO()
    {

    }
    public BanGiaoDTO(string maCa1, string maCa2, int tienBanGiao, int tienHeThong, string maNhanVien1, string maNhanVien2, DateTime thoiGianBanGiao, bool tonTai)
    {
        MaCa11 = maCa1;
        MaCa21 = maCa2;
        TienBanGiao1 = tienBanGiao;
        TienHeThong1 = tienHeThong;
        MaNhanVien11 = maNhanVien1;
        MaNhanVien21 = maNhanVien2;
        ThoiGianBanGiao1 = thoiGianBanGiao;
        TonTai1 = tonTai;
    }

    public string MaCa11 { get => MaCa1; set => MaCa1 = value; }
    public string MaCa21 { get => MaCa2; set => MaCa2 = value; }
    public int TienBanGiao1 { get => TienBanGiao; set => TienBanGiao = value; }
    public int TienHeThong1 { get => TienHeThong; set => TienHeThong = value; }
    public string MaNhanVien11 { get => MaNhanVien1; set => MaNhanVien1 = value; }
    public string MaNhanVien21 { get => MaNhanVien2; set => MaNhanVien2 = value; }
    public DateTime ThoiGianBanGiao1 { get => ThoiGianBanGiao; set => ThoiGianBanGiao = value; }
    public bool TonTai1 { get => TonTai; set => TonTai = value; }
    public void Display() {
        Console.WriteLine($"Ma ca 1:{MaCa1}");
        Console.WriteLine($"Ma ca 2:{MaCa2}");
        Console.WriteLine($"So tien duoc ban giao:{TienBanGiao}");
        Console.WriteLine($"So tien tren he thong:{TienHeThong}");
        Console.WriteLine($"Ma nhan vien ca 1 :{MaNhanVien1}");
        Console.WriteLine($"Ma nhan vien ca 2 :{MaNhanVien2}");
        Console.WriteLine($"Thoi gian ban giao ca :{ThoiGianBanGiao}");
    }
    // public static void Main(string[] args)
    // {
    //     BanGiaoDTO bg = new BanGiaoDTO("123","124",50,45,"1","2",DateTime.Now,true);
    //     bg.Display();
    // }
    
}