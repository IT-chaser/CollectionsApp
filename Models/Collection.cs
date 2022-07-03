using System.ComponentModel.DataAnnotations;

namespace CollectionsApp.Models;

public class Collection {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Topic { get; set; }
    public List<Item> Items { get; set; }
}