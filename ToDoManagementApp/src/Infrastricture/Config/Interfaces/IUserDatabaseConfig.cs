using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastricture.Config.Interfaces
{
    interface IUserDatabaseConfig
    {
        string CollectionName { get; }
        string ConnectionString { get; }
        string DatabaseName { get; }
    }
}
