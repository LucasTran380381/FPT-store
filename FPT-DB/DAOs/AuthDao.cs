using System;
using FptDB.DTOs;
using Microsoft.Data.SqlClient;

namespace FptDB.DAOs
{
    public class AuthDao
    {
        public AccountDto Authenticate(string email, string pwd)
        {
            AccountDto account = null;
            try
            {
                using (var connection = DbUtil.GetConn())
                {
                    var sql = @"select email,
       pwd,
       fullname,
       phone,
       roles.id,
       roles.name,
       status.id,
       status.name,
           address
from accounts,
     roles,
     status
where fk_status = status.id
  and fk_status = 1
  and fk_roles = roles.id
  and email = @email
  and pwd = @pwd";
                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@pwd", pwd);

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var fullName = reader.GetString(2);
                                var phone = reader.GetString(3);
                                var roleId = reader.GetInt32(4);
                                var roleName = reader.GetString(5);
                                var statusId = reader.GetInt32(6);
                                var statusName = reader.GetString(7);
                                var address = reader.GetString(8);
                                account = new AccountDto(email, pwd, fullName, address, phone,
                                    new RoleDto(roleId, roleName), new StatusDto(statusId, statusName));
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }

            return account;
        }
    }
}