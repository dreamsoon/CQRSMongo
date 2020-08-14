using CQRS.Core.Domains;
using CQRS.Data.SQLServerRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQRS.Service.Serviceses.Student.SQLService
{
    public class SQLEntryService:ISQLEntryService
    {
        #region Filed
        private readonly IRepository<Entry> _repositoryEntry = null;

        #endregion
        public SQLEntryService(IRepository<Entry> repositoryEntry)
        {
            _repositoryEntry = repositoryEntry;
        }
        public IQueryable<Entry> GetAll() 
        {
          return  _repositoryEntry.Table;
        }
    }
}
