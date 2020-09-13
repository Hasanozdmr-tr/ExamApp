using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApp.Models
{
    public class ExamListModel
    {
        public int ExamId { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
