using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Core.Domains.BaseDomains
{
	public interface IDateEntity
	{
		DateTime CreateOn { get; set; }
		DateTime UpdateOn { get; set; }
	}
}
