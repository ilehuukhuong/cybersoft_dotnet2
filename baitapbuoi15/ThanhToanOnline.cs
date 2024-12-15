namespace baitapbuoi15
{
    public class ThanhToanOnline : IThanhToan
    {
        private const string OTP = "1234"; // Mã OTP cố định

        public bool ThanhToan(double soTien)
        {
            Console.Write("Nhập mã OTP: ");
            string? inputOtp = Console.ReadLine();
            if (inputOtp == OTP)
            {
                Console.WriteLine($"Thanh toán {soTien} online thành công.");
                return true;
            }
            else
            {
                Console.WriteLine("Mã OTP không chính xác. Thanh toán thất bại.");
                return false;
            }
        }
    }
}