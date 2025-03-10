using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShopStar.Catalog.Entities
{
    public class FeatureDefault
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string FeatureDefaultId { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
    }
}
