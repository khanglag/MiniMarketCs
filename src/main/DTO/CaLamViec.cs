using System;
public class CaLamViecDTO
{
    private string MaCa;
    private DateTime ThoiGianBatDau;
    private DateTime ThoiGianKetThuc;
    private bool TonTai;

    public CaLamViecDTO()
    {

    }
    public CaLamViecDTO(string maCa, DateTime thoiGianBatDau, DateTime thoiGianKetThuc, bool tonTai)
    {
        MaCa1 = maCa;
        ThoiGianBatDau1 = thoiGianBatDau;
        ThoiGianKetThuc1 = thoiGianKetThuc;
        TonTai1 = tonTai;
    }

    public string MaCa1 { get => MaCa; set => MaCa = value; }
    public DateTime ThoiGianBatDau1 { get => ThoiGianBatDau; set => ThoiGianBatDau = value; }
    public DateTime ThoiGianKetThuc1 { get => ThoiGianKetThuc; set => ThoiGianKetThuc = value; }
    public bool TonTai1 { get => TonTai; set => TonTai = value; }
    public void Display() {
        Console.WriteLine($"Ma ca :{MaCa}");
        Console.WriteLine($"Thoi gian bat dau :{ThoiGianBatDau}");
        Console.WriteLine($"Thoi gian ket thuc:{ThoiGianKetThuc}");
    }
}