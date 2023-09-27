using System;
public class PhieuChiDTO {
    private string MaPhieuChi;
    private int SoTien;
    private string MaNhanVien;
    private DateTime ThoiGianChi;
    
    private string LyDo;
    private string GhiChu;
    private bool TonTai;
    public PhieuChiDTO() {
        
    }

    public PhieuChiDTO(string maPhieuChi, int soTien, string maNhanVien, DateTime thoiGianChi, string lyDo, string ghiChu, bool tonTai)
    {
        MaPhieuChi1 = maPhieuChi;
        SoTien1 = soTien;
        MaNhanVien1 = maNhanVien;
        ThoiGianChi1 = thoiGianChi;
        LyDo1 = lyDo;
        GhiChu1 = ghiChu;
        TonTai1 = tonTai;
    }

    public string MaPhieuChi1 { get => MaPhieuChi; set => MaPhieuChi = value; }
    public int SoTien1 { get => SoTien; set => SoTien = value; }
    public string MaNhanVien1 { get => MaNhanVien; set => MaNhanVien = value; }
    public DateTime ThoiGianChi1 { get => ThoiGianChi; set => ThoiGianChi = value; }
    public string LyDo1 { get => LyDo; set => LyDo = value; }
    public string GhiChu1 { get => GhiChu; set => GhiChu = value; }
    public bool TonTai1 { get => TonTai; set => TonTai = value; }

    public void Display() {
        Console.WriteLine($"Ma phieu chi :{MaPhieuChi1}");
        Console.WriteLine($"Ma nhan vien :{MaNhanVien1}");
        Console.WriteLine($"Thoi gian chi :{ThoiGianChi1}");
        Console.WriteLine($"So tien chi :{SoTien1}");
        Console.WriteLine($"Ly do chi :{LyDo1}");
        Console.WriteLine($"Ghi chu :{GhiChu1}");
    }
}