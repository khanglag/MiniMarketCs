using System;
public class PhieuXuatDTO{
    private string MaPhieuXuat;
    private string MaNhanVien;
    private string MaKhachHang;
    private string LyDo;
    private string GhiChu;
    private bool TonTai;
    public PhieuXuatDTO() {

    }

    public PhieuXuatDTO(string maPhieuXuat, string maNhanVien, string maKhachHang, string lyDo, string ghiChu, bool tonTai)
    {
        MaPhieuXuat1 = maPhieuXuat;
        MaNhanVien1 = maNhanVien;
        MaKhachHang1 = maKhachHang;
        LyDo1 = lyDo;
        GhiChu1 = ghiChu;
        TonTai1 = tonTai;
    }

    public string MaPhieuXuat1 { get => MaPhieuXuat; set => MaPhieuXuat = value; }
    public string MaNhanVien1 { get => MaNhanVien; set => MaNhanVien = value; }
    public string MaKhachHang1 { get => MaKhachHang; set => MaKhachHang = value; }
    public string LyDo1 { get => LyDo; set => LyDo = value; }
    public string GhiChu1 { get => GhiChu; set => GhiChu = value; }
    public bool TonTai1 { get => TonTai; set => TonTai = value; }

    public void Display() {
        Console.WriteLine($"Ma phieu xuat :{MaPhieuXuat1}");
        Console.WriteLine($"Ma nhan vien :{MaNhanVien1}");
        Console.WriteLine($"Ma khach hang :{MaKhachHang1}");
         Console.WriteLine($"Ly do :{LyDo1}");
        Console.WriteLine($"Ghi chu :{GhiChu1}");
      
    }
}