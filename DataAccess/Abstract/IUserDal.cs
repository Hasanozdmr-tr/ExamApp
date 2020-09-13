using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserDal : IGenericDal<User>
    {
        User GetUserByUsernameAndPassword(string username, string password);
        User GetUserByUsername(string username);


    }
}
