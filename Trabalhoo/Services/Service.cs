using Trabalhoo.Repositories;
using System;
using System.Collections.Generic;

namespace Trabalhoo.Services
{
    public class Service<T> : IDisposable where T : class
    {
        private Repository<T> _repository { get; set; }

        protected void SetRepository(Repository<T> repository)
        {
            _repository = repository;
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T Get(long id)
        {
            return _repository.Get(id);
        }

        public long Insert(T obj)
        {
            return _repository.Insert(obj);
        }

        public bool Update(T obj)
        {
            return _repository.Update(obj);
        }

        public bool Delete(T obj)
        {
            return _repository.Delete(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
