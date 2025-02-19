using System.Text.Json.Serialization;

namespace Session28_Life_Cycle.Models;

public class Category
{
    public string Id { get; set;} = string.Empty;
    public string CategoryName { get; set; } = string.Empty;
    [JsonPropertyName("category")]
    public string CategoryJson { set => CategoryName = value; }
}
