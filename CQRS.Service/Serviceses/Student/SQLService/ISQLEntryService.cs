using CQRS.Core.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQRS.Service.Serviceses.Student.SQLService
{
    public interface ISQLEntryService
    {
        IQueryable<Entry> GetAll();
    }
}
