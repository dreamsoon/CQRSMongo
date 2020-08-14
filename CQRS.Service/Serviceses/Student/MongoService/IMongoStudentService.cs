using CQRS.Core.Models;
using CQRS.Data.Databases.MongoDB;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Service.Serviceses.Student.MongoService
{
    public interface IMongoStudentService
    {

        Task<List<StudentModel>> GetAllAsync();
        Task<bool> IsExist(string id);
        Task RegisterAsync(StudentModel model);
        Task RemoveAsync(string id);
        Task UpdateAsync(StudentModel student);
    }
}
