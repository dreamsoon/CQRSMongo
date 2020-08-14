using CQRS.Core.Domains.BaseDomains;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Core.Domains
{
   public class Entry:BaseEntity
    {
        public string Description { get; set; }
        public bool IsExpense { get; set; }
        public decimal Value { get; set; }
    }
}
