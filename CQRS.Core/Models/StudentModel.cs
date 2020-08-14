
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Core.Models
{
   public class StudentModel: BaseModel
    {
   
        public string Name { get; set; }
        public string Family { get; set; }
        public long Mobile { get; set; }
    }
}
