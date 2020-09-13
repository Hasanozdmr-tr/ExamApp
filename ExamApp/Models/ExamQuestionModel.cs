using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApp.Models
{
    public class ExamQuestionModel
    {
        public Exam Exam { get; set; }
        public List<Question> Questions { get; set; }
    }
}
