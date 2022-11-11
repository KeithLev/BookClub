using NUnit.Framework;
using BookClubMongoDB;
using BookClubClassLibrary;

namespace BookClubTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {


        }

        [Test]
        public void Test1()
        {
            User keith = new User()
            {
                Name = "Keith"
            };

            BookClubMongoDB.MongoDB.AddUser(keith);

            var user = BookClubMongoDB.MongoDB.FindUser("Keith");

            BookClubMongoDB.MongoDB.FindUser(user.Id);

            BookClubMongoDB.MongoDB.RemoveUser(user.Id);

        }
    }
}