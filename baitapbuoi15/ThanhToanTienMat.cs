namespace baitapbuoi15
{
    public class ThanhToanTienMat : IThanhToan
    {
        public bool ThanhToan(double soTien)
        {
            Console.WriteLine($"Thanh toán {soTien} bằng tiền mặt thành công.");
            return true;
        }
    }
}