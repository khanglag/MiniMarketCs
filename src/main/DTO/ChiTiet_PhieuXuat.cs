using System;
public class ChiTiet_PhieuXuatDTO{
    private string MaPhieuXuat;
    private string MaHangXuat;
    private int SoLuongYeuCau;
    private int SoLuongThucXuat;
    private string DonVi;
    private int DonGia;
    private int ThanhTien;
    private bool TonTai;
    public ChiTiet_PhieuXuatDTO() {

    }

    public ChiTiet_PhieuXuatDTO(string maPhieuXuat, string maHangXuat, int soLuongYeuCau, int soLuongThucXuat, string donVi, int donGia, int thanhTien, bool tonTai)
    {
        MaPhieuXuat1 = maPhieuXuat;
        MaHangXuat1 = maHangXuat;
        SoLuongYeuCau1 = soLuongYeuCau;
        SoLuongThucXuat1 = soLuongThucXuat;
        DonVi1 = donVi;
        DonGia1 = donGia;
        ThanhTien1 = thanhTien;
        TonTai1 = tonTai;
    }

    public string MaPhieuXuat1 { get => MaPhieuXuat; set => MaPhieuXuat = value; }
    public string MaHangXuat1 { get => MaHangXuat; set => MaHangXuat = value; }
    public int SoLuongYeuCau1 { get => SoLuongYeuCau; set => SoLuongYeuCau = value; }
    public int SoLuongThucXuat1 { get => SoLuongThucXuat; set => SoLuongThucXuat = value; }
    public string DonVi1 { get => DonVi; set => DonVi = value; }
    public int DonGia1 { get => DonGia; set => DonGia = value; }
    public int ThanhTien1 { get => ThanhTien; set => ThanhTien = value; }
    public bool TonTai1 { get => TonTai; set => TonTai = value; }
    public void Display() {
        Console.WriteLine($"Ma phieu xuat :{MaPhieuXuat1}");
        Console.WriteLine($"Ma hang xuat:{MaHangXuat1}");
        Console.WriteLine($"So luong  yeu cau :{SoLuongYeuCau1}");
        Console.WriteLine($"So luong thuc xuat :{SoLuongThucXuat1}");
        Console.WriteLine($"Don vi :{DonVi1}");
        Console.WriteLine($"Don gia :{DonGia1}");
        Console.WriteLine($"Thanh tien :{ThanhTien1}");
    
    }
}