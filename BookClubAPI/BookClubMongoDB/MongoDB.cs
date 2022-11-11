using MongoDB.Driver;
using MongoDB.Bson;
using BookClubClassLibrary;

namespace BookClubMongoDB
{

    public static class MongoDB
    {
        private static IMongoDatabase ConnectToMongoDB()
        {
            var client = new MongoClient("mongodb+srv://BookClubAPI:vMBxhudyXFDzGF6P@bookclub.hslf3dj.mongodb.net/?retryWrites=true&w=majority");

            IMongoDatabase database = client.GetDatabase("BookClub");

            return database;
        }

        private static IMongoCollection<User> ConnectToUserConnection()
        {
            var db = ConnectToMongoDB();

            var collection = db.GetCollection<User>("Users");

            return collection;


        }

        public static void AddUser(User user)
        {
            var collection = ConnectToUserConnection();

            collection.InsertOne(user);

            return;


        }

        public static User FindUser(string name)
        {
            var collection = ConnectToUserConnection();

            var filter = Builders<User>.Filter.Eq(x => x.Name, name);

            var result =collection.Find(filter).FirstOrDefault();

            return result;

        }

        public static User FindUser(ObjectId id)
        {
            var collection = ConnectToUserConnection();

            var filter = Builders<User>.Filter.Eq("_id", id);

            var result = collection.Find(filter).FirstOrDefault();

            return result;

        }

        public static bool RemoveUser(ObjectId id)
        {
            var collection = ConnectToUserConnection();

            var filter = Builders<User>.Filter.Eq("_id", id);

            bool deleted = collection.DeleteOne(filter).IsAcknowledged;

            return deleted;

        }

    }


}