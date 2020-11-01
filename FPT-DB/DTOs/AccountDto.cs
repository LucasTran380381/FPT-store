namespace FptDB.DTOs
{
    public class AccountDto
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string FullName { get; set; }

        public string Address { get; set; }

        public RoleDto Role { get; set; }
        public StatusDto Status { get; set; }

        public AccountDto(string email, string password, string fullName, string address, RoleDto role,
            StatusDto status)
        {
            Email = email;
            Password = password;
            FullName = fullName;
            Address = address;
            this.Role = role;
            this.Status = status;
        }
    }
}