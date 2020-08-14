using CQRS.Core.Models;
using CQRS.Data.MongoConfig;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Data.Databases.MongoDB
{
    public class MongoDBContext
    {
        private readonly IMongoDatabase _database = null;
        public MongoDBContext(IOptions<MongoSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.DatabaseName);
        }
        public IMongoCollection<StudentModel> Student
        {
            get
            {
                return _database.GetCollection<StudentModel>("Student");
            }
        }
    }
}
