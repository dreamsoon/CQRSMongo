using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Core.Domains.BaseDomains
{
	public abstract class BaseEntity : Entity
	{
		//public BaseEntity()
		//{
		//	UpdateOn = DateTime.Now;
		//}
		public int ID { get; set; }
		//public DateTime CreateOn { get; set; }
		//public DateTime UpdateOn { get; set; }
	}
}
