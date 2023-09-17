using System;
public class PhanCaDTO {
    private string MaCa;
    private string MaNhanVien;
    private int SoGio;
    private DateOnly NgayLam;
    private bool TonTai;
    public PhanCaDTO() {
        
    }

    public PhanCaDTO(string maCa, string maNhanVien, int soGio, DateOnly ngayLam, bool tonTai)
    {
        MaCa1 = maCa;
        MaNhanVien1 = maNhanVien;
        SoGio1 = soGio;
        NgayLam1 = ngayLam;
        TonTai1 = tonTai;
    }

    public string MaCa1 { get => MaCa; set => MaCa = value; }
    public string MaNhanVien1 { get => MaNhanVien; set => MaNhanVien = value; }
    public int SoGio1 { get => SoGio; set => SoGio = value; }
    public DateOnly NgayLam1 { get => NgayLam; set => NgayLam = value; }
    public bool TonTai1 { get => TonTai; set => TonTai = value; }
    public void Display() {
        Console.WriteLine($"Ma ca lam viec :{MaCa}");
        Console.WriteLine($"Ma nhan vien:{MaNhanVien}");
        Console.WriteLine($"So gio lam :{SoGio}");
        Console.WriteLine($"Ngay lam :{NgayLam}");
        
    }
}