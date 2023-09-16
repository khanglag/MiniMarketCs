using System;
public class PhieuXuatDTO{
    private string MaPhieuXuat;
    private string MaNhanVien;
    private DateTime NgayTaoPhieu;
    private string MaHangXuat;
    private int SoLuong;
    private string LyDo;
    private bool TonTai;
    public PhieuXuatDTO() {

    }

    public PhieuXuatDTO(string maPhieuXuat, string maNhanVien, DateTime ngayTaoPhieu, string maHangXuat, int soLuong, string lyDo, bool tonTai)
    {
        MaPhieuXuat1 = maPhieuXuat;
        MaNhanVien1 = maNhanVien;
        NgayTaoPhieu1 = ngayTaoPhieu;
        MaHangXuat1 = maHangXuat;
        SoLuong1 = soLuong;
        LyDo1 = lyDo;
        TonTai1 = tonTai;
    }

    public string MaPhieuXuat1 { get => MaPhieuXuat; set => MaPhieuXuat = value; }
    public string MaNhanVien1 { get => MaNhanVien; set => MaNhanVien = value; }
    public DateTime NgayTaoPhieu1 { get => NgayTaoPhieu; set => NgayTaoPhieu = value; }
    public string MaHangXuat1 { get => MaHangXuat; set => MaHangXuat = value; }
    public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
    public string LyDo1 { get => LyDo; set => LyDo = value; }
    public bool TonTai1 { get => TonTai; set => TonTai = value; }
}