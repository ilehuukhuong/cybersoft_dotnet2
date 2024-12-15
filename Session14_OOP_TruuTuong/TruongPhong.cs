namespace Session14_OOP_TruuTuong;
class TruongPhong : NhanVien
{
    private double heSoLuong;
    public double HeSoLuong { get { return heSoLuong; } set { heSoLuong = value; } }
    public TruongPhong(string maNV, string hoTen, double luongCoBan, double heSoLuong) : base(maNV, hoTen, luongCoBan)
    {
        this.heSoLuong = heSoLuong;
    }
    public override double TinhLuong()
    {
        this.LuongCoBan = this.LuongCoBan * this.HeSoLuong;
        return this.LuongCoBan;
    }
}