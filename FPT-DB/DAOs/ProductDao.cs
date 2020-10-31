using System;
using System.Collections.Generic;
using FptDB.DTOs;

namespace FptDB.DAOs
{
    public class ProductDao : IDao<ProductDto, string>
    {
        public List<ProductDto> GetAll()
        {
            return null;
        }

        public ProductDto Get(string id)
        {
            throw new NotImplementedException();
        }

        public bool Save(ProductDto t)
        {
            throw new NotImplementedException();
        }

        public bool Update(ProductDto t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}