using Service.Interfaces;
using Service.ModelsVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocabularyProject.Models;

namespace Service.Services
{
    public class LearnedDateService : ILearnedDate
    {
        private readonly VocabularyDbContext _context;

        public LearnedDateService(VocabularyDbContext context)
        {
            _context = context;
        }

        public List<LearnedDates> GetDateInLastestWeek()
        {
            var firstOfWeek = Common.Common.MondayOfWeek(DateTime.Now);
            var lastOfWeek = Common.Common.SaturdayOfWeek(firstOfWeek);
            var a = _context.LearnedDates.Where(x => x.Date > firstOfWeek && x.Date < lastOfWeek).ToList();
            return a.Select(x => new LearnedDates()
            {
                ID = x.ID,
                Date = x.Date,
                UserID = x.UserID,
            }).ToList();
        }
    }
}