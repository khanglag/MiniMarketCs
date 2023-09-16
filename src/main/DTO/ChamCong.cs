using System;
public class ChamCongDTO
{
    private string MaNhanVien;
    private DateTime ThoiGianCheckin;
    private DateTime ThoiGianCheckout;
    private int TongGioCong;

    public ChamCongDTO()
    {

    }

    public ChamCongDTO(string maNhanVien, DateTime thoiGianCheckin, DateTime thoiGianCheckout, int tongGioCong)
    {
        MaNhanVien1 = maNhanVien;
        ThoiGianCheckin1 = thoiGianCheckin;
        ThoiGianCheckout1 = thoiGianCheckout;
        TongGioCong1 = tongGioCong;
    }

    public string MaNhanVien1 { get => MaNhanVien; set => MaNhanVien = value; }
    public DateTime ThoiGianCheckin1 { get => ThoiGianCheckin; set => ThoiGianCheckin = value; }
    public DateTime ThoiGianCheckout1 { get => ThoiGianCheckout; set => ThoiGianCheckout = value; }
    public int TongGioCong1 { get => TongGioCong; set => TongGioCong = value; }
}