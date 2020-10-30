using System.Collections.Generic;

namespace FptDB.DAOs
{
    public interface IDao<T, in TIdType>
    {
        public List<T> GetAll();

        public T Get(TIdType id);

        public bool Save(T t);

        public bool Update(T t);

        public bool Delete(TIdType id);
    }
}