namespace FptDB.DTOs
{
    public class AccountDto
    {
        public AccountDto(string email, string password, string fullName, string address, string phone, RoleDto role,
            StatusDto status)
        {
            Email = email;
            Password = password;
            FullName = fullName;
            Address = address;
            Phone = phone;
            Role = role;
            Status = status;
        }

        public string Email { get; set; }

        public string Password { get; set; }

        public string FullName { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public RoleDto Role { get; set; }
        public StatusDto Status { get; set; }
    }
}