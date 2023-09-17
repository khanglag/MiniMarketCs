using System;
public class TaiKhoanDTO {
    private string TenDangNhap;
    private string MatKhau;
    private string MaPhanQuyen;
    private bool TonTai;
    public TaiKhoanDTO() {
        
    }

    public TaiKhoanDTO(string tenDangNhap, string matKhau, string maPhanQuyen, bool tonTai)
    {
        TenDangNhap1 = tenDangNhap;
        MatKhau1 = matKhau;
        MaPhanQuyen1 = maPhanQuyen;
        TonTai1 = tonTai;
    }

    public string TenDangNhap1 { get => TenDangNhap; set => TenDangNhap = value; }
    public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
    public string MaPhanQuyen1 { get => MaPhanQuyen; set => MaPhanQuyen = value; }
    public bool TonTai1 { get => TonTai; set => TonTai = value; }
    public void Display() {
        Console.WriteLine($"Ten dang nhap :{TenDangNhap}");
        Console.WriteLine($"Mat Khau :{MatKhau}");
        Console.WriteLine($"Ma phan quyen :{MaPhanQuyen}");  
    }
}