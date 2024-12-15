namespace baitapbuoi15;
internal class Program
{
    private static void Main(string[] args)
    {
        QuanLyGiaoDich quanLyGiaoDich = new QuanLyGiaoDich();

        while (true)
        {
            Console.WriteLine("\n=== MENU THANH TOÁN ===");
            Console.WriteLine("1. Thanh toán bằng tiền mặt");
            Console.WriteLine("2. Thanh toán bằng thẻ");
            Console.WriteLine("3. Thanh toán online");
            Console.WriteLine("4. Xem lịch sử giao dịch");
            Console.WriteLine("5. Thoát");
            Console.Write("Chọn chức năng (1-5): ");

            string? option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    ThanhToan(new ThanhToanTienMat(), "Tiền mặt", quanLyGiaoDich);
                    break;
                case "2":
                    ThanhToan(new ThanhToanBangThe(), "Thẻ", quanLyGiaoDich);
                    break;
                case "3":
                    ThanhToan(new ThanhToanOnline(), "Online", quanLyGiaoDich);
                    break;
                case "4":
                    quanLyGiaoDich.XemLichSu();
                    break;
                case "5":
                    Console.WriteLine("Thoát chương trình.");
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    break;
            }
        }
    }

    private static void ThanhToan(IThanhToan phuongThuc, string tenPhuongThuc, QuanLyGiaoDich quanLyGiaoDich)
    {
        Console.Write("Nhập số tiền cần thanh toán: ");
        if (double.TryParse(Console.ReadLine(), out double soTien))
        {
            if (phuongThuc.ThanhToan(soTien))
            {
                quanLyGiaoDich.ThemGiaoDich(new GiaoDich(tenPhuongThuc, soTien));
            }
        }
        else
        {
            Console.WriteLine("Số tiền không hợp lệ.");
        }
    }
}