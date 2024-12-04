using Newtonsoft.Json;
namespace baitapbuoi13
{
    public class ProductManager
    {
        private List<Product> products = new List<Product>();
        private string filePath = "products.json";

        public ProductManager()
        {
            LoadData();
        }

        private void LoadData()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                products = JsonConvert.DeserializeObject<List<Product>>(json) ?? new List<Product>();
            }
        }

        private void SaveData()
        {
            string json = JsonConvert.SerializeObject(products, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public void AddProduct(Product product)
        {
            if (products.Any(p => p.ProductCode == product.ProductCode))
                throw new ArgumentException("Mã sản phẩm đã tồn tại.");
            products.Add(product);
            SaveData();
        }

        public void UpdateProduct(string code, double newPrice, int newStock)
        {
            var product = products.FirstOrDefault(p => p.ProductCode == code);
            if (product == null) throw new ArgumentException("Không tìm thấy sản phẩm.");
            product.Price = newPrice;
            product.StockQuantity = newStock;
            SaveData();
        }

        public void RemoveProduct(string code)
        {
            var product = products.FirstOrDefault(p => p.ProductCode == code);
            if (product == null) throw new ArgumentException("Không tìm thấy sản phẩm.");
            products.Remove(product);
            SaveData();
        }

        public List<Product> SearchByName(string name)
        {
            return products.Where(p => p.ProductName.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Product> GetProductsSortedByPrice(bool ascending = true)
        {
            return ascending ? products.OrderBy(p => p.Price).ToList() : products.OrderByDescending(p => p.Price).ToList();
        }

        public List<Product> GetProductsSortedByName()
        {
            return products.OrderBy(p => p.ProductName.Split(' ').Last()).ToList();
        }

        public double CalculateTotalValue()
        {
            return products.Sum(p => p.TotalValue);
        }

        public void DisplayAllProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}