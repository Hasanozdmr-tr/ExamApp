using DataAccess.Abstract;
using DataAccess.Context;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class UserRepository : GenericRepository<User>, IUserDal
    {
        public User GetUserByUsername(string username)
        {
            using var context = new ExamContext();
            return context.Users.SingleOrDefault(x => x.Username == username);
        }

        public User GetUserByUsernameAndPassword(string username, string password)
        {
            using var context = new ExamContext();
            return context.Users.SingleOrDefault(x => x.Username == username && x.Password == password);
        }
    }
}
