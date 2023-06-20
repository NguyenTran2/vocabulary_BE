using Service.ModelsVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface ILearnedDate
    {
        List<LearnedDates> GetDateInLastestWeek();
    }
}