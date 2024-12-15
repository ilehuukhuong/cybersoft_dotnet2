namespace baitapbuoi15
{
    public class ThanhToanBangThe : IThanhToan
    {
        private const string PIN = "9999"; // Mã PIN cố định

        public bool ThanhToan(double soTien)
        {
            Console.Write("Nhập mã PIN: ");
            string? inputPin = Console.ReadLine();
            if (inputPin == PIN)
            {
                Console.WriteLine($"Thanh toán {soTien} bằng thẻ thành công.");
                return true;
            }
            else
            {
                Console.WriteLine("Mã PIN không chính xác. Thanh toán thất bại.");
                return false;
            }
        }
    }
}