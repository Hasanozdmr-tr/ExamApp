using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RoleManager : IRoleService
    {
        private readonly IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public void Delete(Role entity)
        {
            _roleDal.Delete(entity);
        }

        public List<Role> GetAll()
        {
            return _roleDal.GetAll();
        }

        public Role GetById(int id)
        {
            return _roleDal.GetById(id);
        }

        public void Save(Role entity)
        {
            _roleDal.Save(entity);
        }

        public void Update(Role entity)
        {
            _roleDal.Update(entity);
        }
    }
}
