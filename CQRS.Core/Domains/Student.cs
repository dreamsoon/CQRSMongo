using CQRS.Core.Domains.BaseDomains;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Core.Domains
{
   public class Student:BaseEntity
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public long Mobile { get; set; }
    }
}
