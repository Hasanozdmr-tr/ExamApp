using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService : IGenericService<User>
    {
        User GetUserByUsernameAndPassword(string username,string password);
        User GetUserByUsername(string username);
    }
}
