using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BookClubClassLibrary
{
    [BsonIgnoreExtraElements]
    public class User
    {
        public string Name { get; set; }

        [BsonId]
        public ObjectId Id { get; set; }


    }
}