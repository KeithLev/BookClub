using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClubClassLibrary
{
    [BsonIgnoreExtraElements]
    public class Book
    {
        public User ?RecomendedBy { get; set; }
        public string ?Name { get; set; }
        public List<Rating> ?Ratings { get; set; }

        [BsonId]
        public ObjectId Id { get; set; }
    }
}
