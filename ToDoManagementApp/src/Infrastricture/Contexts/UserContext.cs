using Domain.Models;
using Infrastricture.Config.Interfaces;
using Infrastricture.Contexts.Interfaces;
using MongoDB.Driver;

namespace Infrastricture.Contexts
{
    class UserContext : IUserContext
    {
        public IMongoCollection<AppUser> Users { get; init; }
        public UserContext(IUserDatabaseConfig configuration)
        {
            var mongoClient = new MongoClient(configuration.ConnectionString);
            var db = mongoClient.GetDatabase(configuration.DatabaseName);

            Users = db.GetCollection<AppUser>(configuration.DatabaseName);
        }
    }
}
