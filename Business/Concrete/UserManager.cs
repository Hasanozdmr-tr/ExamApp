using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Delete(User entity)
        {
            _userDal.Delete(entity);
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public User GetById(int id)
        {
            return _userDal.GetById(id);
        }

        public User GetUserByUsername(string username)
        {
            return _userDal.GetUserByUsername(username);
        }

        public User GetUserByUsernameAndPassword(string username, string password)
        {
            return _userDal.GetUserByUsernameAndPassword(username, password);
        }

        public void Save(User entity)
        {
            _userDal.Save(entity);
        }

        public void Update(User entity)
        {
            _userDal.Update(entity);
        }
    }
}
