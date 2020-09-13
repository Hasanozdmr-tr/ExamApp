using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Entities
{
   public class Question:ITable
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string AOptions { get; set; }
        public string BOptions { get; set; }
        public string COptions { get; set; }
        public string DOptions { get; set; }
        public string SuccessOption { get; set; }
        public string UserOptions { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
    }
}
