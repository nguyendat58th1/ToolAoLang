using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ToolTinhDiem.Entity;

namespace ToolTinhDiem.Repository
{
	public abstract class BaseRepository<TEntity> where TEntity : class
	{
		public DbContextTransaction BeginTransaction()
		{
			var context = new ToolAoLangContext();
			return context.Database.BeginTransaction();
		}
		public void Create(TEntity entity)
		{
			using (var context = new ToolAoLangContext())
			{
				context.Set<TEntity>().Add(entity);
				context.SaveChanges();
			}
		}

		public void Update(TEntity entity)
		{
			using (var context = new ToolAoLangContext())
			{
				context.Entry(entity).State = EntityState.Modified;
				context.SaveChanges();
			}
		}

		public void Delete(TEntity entity)
		{
			using (var context = new ToolAoLangContext())
			{
				context.Set<TEntity>().Remove(entity);
				context.SaveChanges();
			}
		}

		public TEntity Get(Expression<Func<TEntity, bool>> predicate)
		{
			using (var context = new ToolAoLangContext())
			{
				return context.Set<TEntity>().FirstOrDefault(predicate);
			}
		}

		public List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
		{
			using (var context = new ToolAoLangContext())
			{
				return context.Set<TEntity>().Where(predicate).ToList();
			}
		}

		public List<TEntity> GetAll()
		{
			using (var context = new ToolAoLangContext())
			{
				return context.Set<TEntity>().ToList();
			}
		}
	}
}
