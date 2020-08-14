using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Data.MongoConfig
{
    public interface IMongoSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
