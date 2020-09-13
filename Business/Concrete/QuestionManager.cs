using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class QuestionManager : IQuestionService
    {
        private readonly IQuestionDal _questionDal;

        public QuestionManager(IQuestionDal questionDal)
        {
            _questionDal = questionDal;
        }

        public void Delete(Question entity)
        {
            _questionDal.Delete(entity);
        }

        public List<Question> GetAll()
        {
            return _questionDal.GetAll();
        }

        public Question GetById(int id)
        {
            return _questionDal.GetById(id);
        }

        public void Save(Question entity)
        {
            _questionDal.Save(entity);
        }

        public void Update(Question entity)
        {
            _questionDal.Update(entity);
        }
    }
}
