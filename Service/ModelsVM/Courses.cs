using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ModelsVM
{
    public class Courses
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int? UserID { get; set; }
        public int NumberOfWord { get; set; }
        public Users User { get; set; }
        public int? UserSharedID { get; set; }
        public DateTime NewestDateLearn { get; set; }
    }
}