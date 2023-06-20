namespace VocabularyProject.Models
{
    public class Set
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string NameVi { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int? UserID { get; set; }
        public int? FoldersID { get; set; }
        public string FoldersIDs { get; set; } = string.Empty;

        public string? UserSharedIDs { get; set; }
        public DateTime NewestDateLearn { get; set; }

        public User? Users { get; set; }
        public List<Word> Words { get; set; }
    }
}