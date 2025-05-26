using MyRestaurantApp.DataAccess.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
// MyRestaurantApp.DataAccess / Repositories / BaseRepository.cs
using MyRestaurantApp.Core.Interfaces;
using System.Linq;

 
namespace MyRestaurantApp.DataAccess.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        protected List<T> _data; // This list will be linked to a static list in InMemoryDatabase

        public BaseRepository(List<T> data)
        {
            _data = data;
        }

        public virtual Task<IEnumerable<T>> GetAllAsync()
        {
            return Task.FromResult<IEnumerable<T>>(_data.ToList()); // .ToList() to return a copy
        }

        public virtual Task<T> GetByIdAsync(Guid id)
        {
            // Uses reflection to find the correct ID property (UId, RId, MId, OId, OLIId, CId)
            var idProperty = typeof(T).GetProperty("UId") ?? typeof(T).GetProperty("RId") ?? typeof(T).GetProperty("MId") ?? typeof(T).GetProperty("OId") ?? typeof(T).GetProperty("OLIId") ?? typeof(T).GetProperty("CId");
            if (idProperty == null)
            {
                throw new InvalidOperationException($"Type {typeof(T).Name} does not have a suitable ID property (UId, RId, MId, OId, OLIId, CId).");
            }
            var entity = _data.FirstOrDefault(e => (Guid)idProperty.GetValue(e) == id);
            return Task.FromResult(entity);
        }

        public virtual Task AddAsync(T entity)
        {
            var idProperty = typeof(T).GetProperty("UId") ?? typeof(T).GetProperty("RId") ?? typeof(T).GetProperty("MId") ?? typeof(T).GetProperty("OId") ?? typeof(T).GetProperty("OLIId") ?? typeof(T).GetProperty("CId");
            if (idProperty == null)
            {
                throw new InvalidOperationException($"Type {typeof(T).Name} does not have a suitable ID property.");
            }

            Guid entityId = (Guid)idProperty.GetValue(entity);
            if (_data.Any(e => (Guid)idProperty.GetValue(e) == entityId))
            {
                // In a real DB, this would be an ID collision. For in-memory, just prevent duplicates.
                throw new InvalidOperationException($"{typeof(T).Name} with ID {entityId} already exists.");
            }

            _data.Add(entity);
            return Task.CompletedTask;
        }

        public virtual Task UpdateAsync(T entity)
        {
            var idProperty = typeof(T).GetProperty("UId") ?? typeof(T).GetProperty("RId") ?? typeof(T).GetProperty("MId") ?? typeof(T).GetProperty("OId") ?? typeof(T).GetProperty("OLIId") ?? typeof(T).GetProperty("CId");
            if (idProperty == null)
            {
                throw new InvalidOperationException($"Type {typeof(T).Name} does not have a suitable ID property.");
            }
            Guid entityId = (Guid)idProperty.GetValue(entity);
            var existingEntity = _data.FirstOrDefault(e => (Guid)idProperty.GetValue(e) == entityId);
            if (existingEntity == null)
            {
                throw new KeyNotFoundException($"{typeof(T).Name} with ID {entityId} not found for update.");
            }

            // In a real application with ORM, you would attach the entity and mark it as modified.
            // For in-memory, we can directly update properties or replace the object.
            // Replacing is simpler for a mock:
            int index = _data.IndexOf(existingEntity);
            if (index != -1)
            {
                _data[index] = entity; // Replace the old object with the updated one
            }
            return Task.CompletedTask;
        }

        public virtual Task DeleteAsync(Guid id)
        {
            var idProperty = typeof(T).GetProperty("UId") ?? typeof(T).GetProperty("RId") ?? typeof(T).GetProperty("MId") ?? typeof(T).GetProperty("OId") ?? typeof(T).GetProperty("OLIId") ?? typeof(T).GetProperty("CId");
            if (idProperty == null)
            {
                throw new InvalidOperationException($"Type {typeof(T).Name} does not have a suitable ID property.");
            }
            var entityToRemove = _data.FirstOrDefault(e => (Guid)idProperty.GetValue(e) == id);
            if (entityToRemove == null)
            {
                throw new KeyNotFoundException($"{typeof(T).Name} with ID {id} not found for deletion.");
            }
            _data.Remove(entityToRemove);
            return Task.CompletedTask;
        }
    }
}