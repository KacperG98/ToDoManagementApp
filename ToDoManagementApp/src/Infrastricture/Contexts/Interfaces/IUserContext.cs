using Domain.Models;
using MongoDB.Driver;

namespace Infrastricture.Contexts.Interfaces
{
    interface IUserContext
    {
        IMongoCollection<AppUser> Users { get; }
    }
}
