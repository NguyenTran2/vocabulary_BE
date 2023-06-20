namespace VocabularyProject.Models
{
    public class Word
    {
        public int ID { get; set; }
        public string English { get; set; } = String.Empty;
        public string TiengViet { get; set; } = String.Empty;
        public int Status { get; set; }

        public int? SetID { get; set; }

        public Set Sets { get; set; }
    }
}