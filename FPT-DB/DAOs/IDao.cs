using System.Collections.Generic;

namespace FptDB.DAOs
{
    public interface IDao<T, in TId>
    {
        public List<T> GetAll();

        public List<T> GetTop(int offset);

        public T Get(TId id);

        public bool Save(T t);

        public bool Update(T t);

        public bool Delete(TId id);
    }
}