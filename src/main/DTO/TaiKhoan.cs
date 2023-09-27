using System;
public class TaiKhoanDTO {
    private string MaNhanVien;
    private string MatKhau;
    private string MaPhanQuyen;
    private bool TonTai;
    public TaiKhoanDTO() {
        
    }

    public TaiKhoanDTO(string maNhanVien, string matKhau, string maPhanQuyen, bool tonTai)
    {
        MaNhanVien1 = maNhanVien;
        MatKhau1 = matKhau;
        MaPhanQuyen1 = maPhanQuyen;
        TonTai1 = tonTai;
    }

    public string MaNhanVien1 { get => MaNhanVien; set => MaNhanVien = value; }
    public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
    public string MaPhanQuyen1 { get => MaPhanQuyen; set => MaPhanQuyen = value; }
    public bool TonTai1 { get => TonTai; set => TonTai = value; }
    public void Display(){
        Console.WriteLine($"Ma nhan vien :{MaNhanVien1}");
        Console.WriteLine($"Mat khau :{MatKhau1}");
        Console.WriteLine($"Ma phan quyen :{MaPhanQuyen1}");
    }
}