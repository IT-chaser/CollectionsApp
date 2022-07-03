using System.ComponentModel.DataAnnotations;

namespace CollectionsApp.Models;

public class Item {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Tags { get; set; }
    
}