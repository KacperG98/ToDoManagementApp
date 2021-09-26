using Infrastricture.Config.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastricture.Config
{
    class UserDatabaseConfig : IUserDatabaseConfig
    {
        public string CollectionName { get; init; }
        public string ConnectionString { get; init; }
        public string DatabaseName { get; init; }
    }
}
