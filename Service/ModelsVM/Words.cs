using Service.ModelsVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class Words
    {
        public int ID { get; set; }
        public string English { get; set; }
        public string TiengViet { get; set; }
        public int? SetID { get; set; }
    }

    public class DetailWords
    {
        public List<Words> Words { get; set; }
        public Users user { get; set; }
        public Courses course { get; set; }
    }

    public class CreateWord
    {
        public int id { get; set; }
        public string English { get; set; }
        public string TiengViet { get; set; }
    }
}