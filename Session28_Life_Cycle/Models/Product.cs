using System.Text.Json;
using System.Text.Json.Serialization;

namespace Session28_Life_Cycle.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Alias { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Description { get; set; } = string.Empty;
    public string ShortDescription { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public bool Deleted { get; set; }
    public bool Feature { get; set; }
    public string Image { get; set; } = string.Empty;
    public string ImgLink { get; set; } = string.Empty;
    public List<int> Sizes { get; set; } = [];
    [JsonIgnore]
    public List<Category> Categories { get; set; } = [];
    [JsonPropertyName("categories")]
    public string CategoriesJson {
        set {
            Categories = JsonSerializer.Deserialize<List<Category>>(value);
        }
    }
    [JsonIgnore]
    public List<int> RelatedProducts { get; set; } = [];
    [JsonPropertyName("relatedProducts")]
    public string RelatedProductsJson{
        set {
            RelatedProducts = JsonSerializer.Deserialize<List<int>>(value);
        }
    }
}
