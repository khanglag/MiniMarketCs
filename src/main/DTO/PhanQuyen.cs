using System;
public class PhanQuyenDTO {
    private string MaQuyen;
    private string TenQuyen;
    private bool TonTai;
    public PhanQuyenDTO() {
        
    }

    public PhanQuyenDTO(string maQuyen, string tenQuyen, bool tonTai)
    {
        MaQuyen1 = maQuyen;
        TenQuyen1 = tenQuyen;
        TonTai1 = tonTai;
    }

    public string MaQuyen1 { get => MaQuyen; set => MaQuyen = value; }
    public string TenQuyen1 { get => TenQuyen; set => TenQuyen = value; }
    public bool TonTai1 { get => TonTai; set => TonTai = value; }
    public void Display() {
        Console.WriteLine($"Ma quyen :{MaQuyen}");
        Console.WriteLine($"Ten quyen:{TenQuyen}");
    }
}