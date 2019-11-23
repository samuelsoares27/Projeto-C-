using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Dapper.Contrib.Extensions;
using System;

namespace NubancoApp.Repositories
{
    public class Repository<T> : IDisposable where T : class
    {
        protected readonly MySqlConnection _conn;
        private string _connectionString = "Server=localhost;Port=3306;Database=bdTrabalho;Uid=root;Pwd=;";

        public Repository()
        {
            _conn = new MySqlConnection(_connectionString);
        }

        public IEnumerable<T> GetAll()
        {
            return _conn.GetAll<T>();
        }

        public T Get(long id)
        {
            return _conn.Get<T>(id);
        }

        public long Insert(T obj)
        {
            return _conn.Insert(obj);
        }

        public bool Update(T obj)
        {
            return _conn.Update(obj);
        }

        public bool Delete(T obj)
        {
            return _conn.Delete(obj);
        }

        public void Dispose()
        {
            _conn.Close();
        }
    }
}
