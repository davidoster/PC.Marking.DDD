namespace Domain {
    public class Section {
        public int Id { get; set; }
        public string Description { get; set; }
        public float Weight { get; set; } // einai kai sto dictionary, isws einai debrecated.
        public List<Question> Questions { get; set; }
        public int? AwardedSectionMarks { get; set; }


    }
}