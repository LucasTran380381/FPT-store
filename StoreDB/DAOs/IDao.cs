using System.Collections.Generic;

namespace StoreDB.DAOs
{
    public interface IDao<T>
    {
        public List<T> GetAll();

        public T Get(string id);

        public bool Save(T t);

        public bool Update(T t);

        public bool Delete(T t);
    }
}