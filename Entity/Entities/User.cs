using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Entities
{
    public class User : ITable
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Role Role { get; set; }
        public int RoleId { get; set; }
    }
}
