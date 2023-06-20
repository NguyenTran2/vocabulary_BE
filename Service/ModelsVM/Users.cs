using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ModelsVM
{
    public class Users
    {
        public int ID { get; set; }
        public string Account { get; set; } = String.Empty;
        public string Name { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
        public string LinkAvatar { get; set; } = String.Empty;
    }
}