using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocabularyProject.Models;

namespace Service.Models
{
    public class Folders
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int? UserID { get; set; }

        public User? Users { get; set; }
        public List<Set>? Sets { get; set; }
    }
}