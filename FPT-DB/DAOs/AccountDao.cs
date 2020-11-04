using System;
using System.Collections.Generic;
using FptDB.DTOs;
using Microsoft.Data.SqlClient;

namespace FptDB.DAOs
{
    public class AccountDao
    {
        public List<AccountDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<AccountDto> GetTop(int offset)
        {
            throw new NotImplementedException();
        }

        public AccountDto Get(string id)
        {
            throw new NotImplementedException();
        }

        public bool Save(AccountDto t)
        {
            using var connection = DbUtil.GetConn();
            var sql =
                "insert into accounts (email, pwd, fullname, phone, fk_status, fk_roles, address) values (@email, @pwd, @fullname, @phone, @fk_status, @fk_roles, @address)";
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@email", t.Email);
            command.Parameters.AddWithValue("@pwd", t.Password);
            command.Parameters.AddWithValue("@fullname", t.FullName);
            command.Parameters.AddWithValue("@phone", t.Phone);
            command.Parameters.AddWithValue("@fk_status", t.Status.Id);
            command.Parameters.AddWithValue("@fk_roles", t.Role.Id);
            command.Parameters.AddWithValue("@address", t.Address);
            connection.Open();
            var result = command.ExecuteNonQuery() > 0;

            return result;
        }

        public bool Update(AccountDto t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<AccountDto> GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}