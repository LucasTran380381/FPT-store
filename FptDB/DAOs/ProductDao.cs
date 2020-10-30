using System.Collections.Generic;
using FptDB.DTOs;

namespace FptDB.DAOs
{
    public class ProductDao: IDao<Product, string>

    {
        public List<Product> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Product Get(string id)
        {
            throw new System.NotImplementedException();
        }

        public bool Save(Product t)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Product t)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}