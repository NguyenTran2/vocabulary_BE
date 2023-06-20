using Service.Models;

namespace VocabularyProject.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Account { get; set; } = String.Empty;
        public string Name { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
        public string LinkAvatar { get; set; } = String.Empty;

        public virtual List<Set> Sets { get; set; }
        public virtual List<Folders> Folders { get; set; }
        public virtual List<LearnedDates> LearnedDates { get; set; }
    }
}