using CollectionsApp.Models;

namespace CollectionsApp.Models;
public class CollectionViewModel {
    public IEnumerable<CollectionsApp.Models.Collection>? Collections { get; set; }
    public IEnumerable<CollectionsApp.Models.Item>? Items { get; set; }
}