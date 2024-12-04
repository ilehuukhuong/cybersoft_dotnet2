namespace baitapbuoi13
{
    public class Product
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        public double TotalValue => Price * StockQuantity;

        public Product(string code, string name, double price, int stock)
        {
            ProductCode = code;
            ProductName = name;
            Price = price;
            StockQuantity = stock;
        }

        public override string ToString()
        {
            return $"Mã: {ProductCode}, Tên: {ProductName}, Giá: {Price}, Tồn kho: {StockQuantity}, Tổng giá trị: {TotalValue:F2}";
        }
    }

}