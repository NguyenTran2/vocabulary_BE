using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ModelsVM
{
    public class LearnedDates
    {
        public int ID { get; set; }
        public DateTime? Date { get; set; }
        public int? UserID { get; set; }
    }
}