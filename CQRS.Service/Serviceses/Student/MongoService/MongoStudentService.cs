using CQRS.Core.Models;
using CQRS.Data.Databases.MongoDB;
using CQRS.Data.MongoConfig;
using CQRS.Service.Serviceses.Student.MongoService;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Service.Services.Student.MongoService
{
    public class MongoStudentService : IMongoStudentService
    {
        private readonly MongoDBContext _context;

        public MongoStudentService(IOptions<MongoSettings> settings)
        {
            _context = new MongoDBContext(settings);
        }
        public async Task<List<StudentModel>> GetAllAsync()
        {
            return await _context.Student.Find(new BsonDocument()).ToListAsync();
        }
        public async Task RegisterAsync(StudentModel model)
        {
           await _context.Student.InsertOneAsync(model);
        }
        public async Task UpdateAsync(StudentModel student)
        {
            await _context.Student.ReplaceOneAsync(
                doc => doc.Id == student.Id,
                student, new UpdateOptions { IsUpsert = true });
        }
        public async Task RemoveAsync(string id)
        {
            var filter = Builders<StudentModel>.Filter.Eq("Id", id);
            await _context.Student.DeleteOneAsync(filter);
           
        }

        public async Task<bool> IsExist(string id)
        {
            var filter = Builders<StudentModel>.Filter.Eq("Id", id);
            var student = await _context.Student
                                  .Find(filter)
                                  .FirstOrDefaultAsync();
            if (student == null)
                return false;
            return true;
        }

    }
}
