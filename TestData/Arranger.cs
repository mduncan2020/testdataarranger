using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestData
{
    public class Arranger<T> : IDisposable where T : class, new()
    {
        public ICollection<T> Entities { get; private set; }

        public Arranger()
        {
            Entities = new List<T>();
        }

        public T Create()
        {
            T newEntity = new T();
            return Create(newEntity);
        }

        public T Create(T newEntity)
        {
            return Persist(newEntity);
        }

        protected T Persist(T entity)
        {
            // TODO add to db
            Entities.Add(entity);
            return entity;
        }

        protected void Delete(T entity)
        {
            // TODO remove from db
            Entities.Remove(entity);
        }

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                for (int i = this.Entities.Count - 1; i >= 0; i--)
                {
                    var toDelete = this.Entities.ElementAt(i);
                    this.Delete(toDelete);
                }
            }
        }

        #endregion
    }
}
