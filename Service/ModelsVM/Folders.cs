using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ModelsVM
{
    public class Folders
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int? UserID { get; set; }

        public int countSet { get; set; }
        public bool Added { get; set; }
    }
}