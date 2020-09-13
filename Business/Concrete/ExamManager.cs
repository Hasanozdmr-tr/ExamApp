using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ExamManager : IExamService
    {
        private readonly IExamDal _examDal;

        public ExamManager(IExamDal examDal)
        {
            _examDal = examDal;
        }

        public void Delete(Exam entity)
        {
            _examDal.Delete(entity);
        }

        public List<Exam> GetAll()
        {
            return _examDal.GetAll();
        }

        public Exam GetById(int id)
        {
            return _examDal.GetById(id);
        }

        public void Save(Exam entity)
        {
            _examDal.Save(entity);
        }

        public void Update(Exam entity)
        {
            _examDal.Update(entity);
        }
    }
}
