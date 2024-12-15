namespace baitapbuoi15
{
    public class GiaoDich
    {
        public string PhuongThuc { get; set; }
        public double SoTien { get; set; }
        public DateTime NgayGiaoDich { get; set; }

        public GiaoDich(string phuongThuc, double soTien)
        {
            PhuongThuc = phuongThuc;
            SoTien = soTien;
            NgayGiaoDich = DateTime.Now;
        }
    }
}