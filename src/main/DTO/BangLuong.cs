public class BangLuongDTO
{
    private string MaNhanVien;
    private int TongCong;
    private DateTime NgayBatDau;
    private DateTime NgayKetThuc;
    private int PhuCap;
    private int TienThuong;
    private int TienPhat;
    private int UngLuong;
    private int ThucLanh;
    private bool TonTai;

    public BangLuongDTO()
    {

    }

    public BangLuongDTO(string maNhanVien, int tongCong, DateTime ngayBatDau, DateTime ngayKetThuc, int phuCap, int tienThuong, int tienPhat, int ungLuong, int thucLanh, bool tonTai)
    {
        MaNhanVien1 = maNhanVien;
        TongCong1 = tongCong;
        NgayBatDau1 = ngayBatDau;
        NgayKetThuc1 = ngayKetThuc;
        PhuCap1 = phuCap;
        TienThuong1 = tienThuong;
        TienPhat1 = tienPhat;
        UngLuong1 = ungLuong;
        ThucLanh1 = thucLanh;
        TonTai1 = tonTai;
    }

    public string MaNhanVien1 { get => MaNhanVien; set => MaNhanVien = value; }
    public int TongCong1 { get => TongCong; set => TongCong = value; }
    public DateTime NgayBatDau1 { get => NgayBatDau; set => NgayBatDau = value; }
    public DateTime NgayKetThuc1 { get => NgayKetThuc; set => NgayKetThuc = value; }
    public int PhuCap1 { get => PhuCap; set => PhuCap = value; }
    public int TienThuong1 { get => TienThuong; set => TienThuong = value; }
    public int TienPhat1 { get => TienPhat; set => TienPhat = value; }
    public int UngLuong1 { get => UngLuong; set => UngLuong = value; }
    public int ThucLanh1 { get => ThucLanh; set => ThucLanh = value; }
    public bool TonTai1 { get => TonTai; set => TonTai = value; }
    public void Display() {
        Console.WriteLine($"Ma nhan vien:{MaNhanVien}");
        Console.WriteLine($"Tong cong :{TongCong}");
        Console.WriteLine($"Ngay bat dau tinh luong:{NgayBatDau}");
        Console.WriteLine($"Ngay ket thuc tinh luong:{NgayKetThuc}");
        Console.WriteLine($"Phu cap :{PhuCap}");
        Console.WriteLine($"Tien thuong :{TienThuong}");
        Console.WriteLine($"Tien phat :{TienPhat}");
        Console.WriteLine($"Ung luong :{UngLuong}");
        Console.WriteLine($"Thuc lanh :{ThucLanh}");
    }
}