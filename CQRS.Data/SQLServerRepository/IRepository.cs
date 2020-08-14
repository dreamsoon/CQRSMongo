

using CQRS.Core.Domains.BaseDomains;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace CQRS.Data.SQLServerRepository
{
	public partial interface IRepository<TEntity> where TEntity : Entity
	{

		TEntity GetById(params object[] ids);

		void Insert(TEntity entity);

		void Update(TEntity entity);

		void Delete(TEntity entity);

		System.Linq.IQueryable<TEntity> Table { get; }

		System.Linq.IQueryable<TEntity> TableNoTracking { get; }

		TEntity GetByIdAsNoTracking(params object[] ids);
		Task DeleteAsync(TEntity entity);
		Task UpdateAsync(TEntity entity);
		Task InsertAsync(TEntity entity);
		Task<TEntity> GetByIdAsync(params object[] ids);
		Task<TEntity> GetByIdAsNoTrackingAsync(params object[] ids);

	}
}
