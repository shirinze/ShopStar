﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShopStar.Catalog.Entities
{
    public class ProductImage
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ImageID { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public string ProductID { get; set; }
        [BsonIgnore]
        public Product Product { get; set; }
    }
}
