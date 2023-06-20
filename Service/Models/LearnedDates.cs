using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocabularyProject.Models;

namespace Service.Models
{
    public class LearnedDates
    {
        public int ID { get; set; }
        public DateTime? Date { get; set; }
        public int? UserID { get; set; }

        public User? Users { get; set; }
    }
}