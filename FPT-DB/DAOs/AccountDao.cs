using System;
using System.Collections.Generic;
using FptDB.DTOs;
using Microsoft.Data.SqlClient;

namespace FptDB.DAOs
{
    public class AccountDao : IDao<AccountDto, string>
    {
        public List<AccountDto> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<AccountDto> GetTop(int offset)
        {
            throw new NotImplementedException();
        }

        public AccountDto Get(string id)
        {
            throw new System.NotImplementedException();
        }

        public bool Save(AccountDto t)
        {
            // bool result;
            // try
            // {
            //     using var connection = DbUtil.GetConn();
            //     string sql =
            //         "insert into accounts (email, pwd, fullname, phone, fk_status, fk_roles, address) values (@email, @pwd, @fullname, @phone, @fk_status, @fk_roles, @address)";
            //     using var command = new SqlCommand(sql, connection);
            //     command.Parameters.AddWithValue("@email", t.Email);
            //     command.Parameters.AddWithValue("@pwd", t.Password);
            //     command.Parameters.AddWithValue("@fullname", t.FullName);
            //     command.Parameters.AddWithValue("@phone", t.Phone);
            //     command.Parameters.AddWithValue("@fk_status", t.Status.Id);
            //     command.Parameters.AddWithValue("@fk_roles", t.Role.Id);
            //     command.Parameters.AddWithValue("@address", t.Address);
            //     connection.Open();
            //     result = command.ExecuteNonQuery() > 0;
            // }
            // catch (SqlException e)
            // {
            //     result = false;
            //     throw new Exception(e.Message);
            // }
            //
            // return result;
            
            using var connection = DbUtil.GetConn();
            string sql =
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
            throw new System.NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}