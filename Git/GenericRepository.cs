using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace JobSearchAPI
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        private JSDbContextAPI _jsdbContextAPI;
        private DbSet<TEntity> dbset;
        public GenericRepository(JSDbContextAPI jSDbContextAPI)
        {
            _jsdbContextAPI = jSDbContextAPI;
            dbset = jSDbContextAPI.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null,Func<IQueryable<TEntity>,IOrderedQueryable<TEntity>> orderBy = null,string includeProperties = "")
        {
            IQueryable<TEntity> query = dbset;
            if(filter != null)
            {
                query = query.Where(filter);
            }
            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }
            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else{ return query.ToList(); }
        }

        public virtual TEntity GetById(object id)
        {
            return dbset.Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            dbset.Add(entity);
        }

        public virtual TEntity DeleteById(object id)
        {
            TEntity entityToDelete = dbset.Find(id);
            Delete(entityToDelete);
            return entityToDelete;
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            if (_jsdbContextAPI.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbset.Attach(entityToDelete);
            }
            dbset.Remove(entityToDelete);
        }

        //public virtual void Update(TEntity entityToUpdate)
        //{
        //    dbset.Attach(entityToUpdate);
        //    _jsdbContextAPI.Entry(entityToUpdate).State = EntityState.Modified;
        //}
        //public virtual TEntity UpdateById(object id, TEntity updatedEntity)
        //{
        //    var existing = dbset.Find(id);
        //    if (existing == null)
        //        throw new KeyNotFoundException($"Entity of type {typeof(TEntity).Name} with key {id} not found.");

        //    _jsdbContextAPI.Entry(existing).CurrentValues.SetValues(updatedEntity);
        //    var key = _jsdbContextAPI.Model
        //      ?.FindEntityType(typeof(TEntity))
        //      ?.FindPrimaryKey()
        //      ?.Properties
        //      ?.Select(p => p.Name);
        //    foreach (var keyName in key)
        //    {
        //        var originalValue = typeof(TEntity).GetProperty(keyName)?.GetValue(existing);
        //        typeof(TEntity).GetProperty(keyName)?.SetValue(_jsdbContextAPI.Entry(existing).Entity, originalValue);
        //    }
        //    return updatedEntity;
        //}
        public virtual TEntity UpdateById(object id, TEntity updatedEntity)
        {
            var existing = dbset.Find(id);
            if (existing == null)
                throw new KeyNotFoundException($"Entity of type {typeof(TEntity).Name} with key {id} not found.");

            var keyProperties = _jsdbContextAPI.Model
                ?.FindEntityType(typeof(TEntity))
                ?.FindPrimaryKey()
                ?.Properties
                .Select(p => p.Name)
                .ToHashSet();

            var properties = typeof(TEntity).GetProperties();
            foreach (var prop in properties)
            {
                if (keyProperties.Contains(prop.Name)) continue; 
                var newValue = prop.GetValue(updatedEntity);
                prop.SetValue(existing, newValue);
            }

            return existing;
        }

        public virtual TEntity AddUserother(TEntity entity)
        {
            dbset.Add(entity);
            return entity;
		}

	}
}

