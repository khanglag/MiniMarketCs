using System;
public class PhieuChiDTO {
    private string MaPhieuNhap;
    private string MaNhanVien;
    private DateTime NgayChi;
    private int SoTien;
    private string LyDo;
    private string GhiChu;
    private bool TonTai;
    public PhieuChiDTO() {
        
    }

    public PhieuChiDTO(string maPhieuNhap, string maNhanVien, DateTime ngayChi, int soTien, string lyDo, string ghiChu, bool tonTai)
    {
        MaPhieuNhap1 = maPhieuNhap;
        MaNhanVien1 = maNhanVien;
        NgayChi1 = ngayChi;
        SoTien1 = soTien;
        LyDo1 = lyDo;
        GhiChu1 = ghiChu;
        TonTai1 = tonTai;
    }

    public string MaPhieuNhap1 { get => MaPhieuNhap; set => MaPhieuNhap = value; }
    public string MaNhanVien1 { get => MaNhanVien; set => MaNhanVien = value; }
    public DateTime NgayChi1 { get => NgayChi; set => NgayChi = value; }
    public int SoTien1 { get => SoTien; set => SoTien = value; }
    public string LyDo1 { get => LyDo; set => LyDo = value; }
    public string GhiChu1 { get => GhiChu; set => GhiChu = value; }
    public bool TonTai1 { get => TonTai; set => TonTai = value; }
}