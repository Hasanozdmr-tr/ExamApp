using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Entities
{
    public class Role:ITable
    {
        public int Id { get; set; }
        public string RoleName { get; set; }

        public List<User> Users { get; set; }
    }
}
