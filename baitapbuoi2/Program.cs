#region Tính số ngày trong tuần và số ngày lẻ

Console.Write("Xin vui lòng nhập số ngày: ");
int soNgay = Convert.ToInt32(Console.ReadLine());

int soTuan = soNgay / 7;
int soNgayLe = soNgay % 7;

Console.WriteLine($"{soTuan} tuần và {soNgayLe} ngày");

#endregion

#region Tính tổng giá trị đơn hàng sau khi áp dụng giảm giá

Console.Write("Vui lòng nhập vào giá trị đơn hàng: ");
decimal price = Convert.ToDecimal(Console.ReadLine());

Console.Write("Vui lòng nhập vào phần trăm giảm giá: ");
decimal discount = Convert.ToDecimal(Console.ReadLine());

decimal discountAmount = price * discount / 100;
decimal total = price - discountAmount;

Console.WriteLine($"Số tiền giảm giá: {discountAmount}");
Console.WriteLine($"Tổng số tiền phải thanh toán: {total}");

#endregion

#region Chuyển đổi từ phút sang giờ và phút

Console.Write("Vui lòng nhập số phút: ");
int totalMinutes = Convert.ToInt32(Console.ReadLine());

int hours = totalMinutes / 60;
int minutes = totalMinutes % 60;

Console.WriteLine($"{totalMinutes} phút = {hours} giờ và {minutes} phút");

#endregion

#region Tính tổng số tiền sau khi đã cộng thuế VAT

Console.Write("Vui lòng nhập số tiền gốc: ");
decimal originalPrice = Convert.ToDecimal(Console.ReadLine());

Console.Write("Vui lòng nhập tỷ lệ thuế VAT (%): ");
decimal vatRate = Convert.ToDecimal(Console.ReadLine());

decimal vatAmount = originalPrice * vatRate / 100;
decimal totalPrice = originalPrice + vatAmount;

Console.WriteLine($"Số tiền thuế VAT: {vatAmount}");
Console.WriteLine($"Tổng số tiền sau khi cộng thuế: {totalPrice}");

#endregion

#region Chuyển đổi đơn vị tiền tệ
Console.Write("Vui lòng nhập số tiền (USD): ");
decimal usdAmount = Convert.ToDecimal(Console.ReadLine());

Console.Write("Vui lòng nhập tỷ giá chuyển đổi từ USD sang VND: ");
decimal exchangeRate = Convert.ToDecimal(Console.ReadLine());

decimal vndAmount = usdAmount * exchangeRate;

Console.WriteLine($"Số tiền tương ứng bằng VND: {vndAmount}");

#endregion