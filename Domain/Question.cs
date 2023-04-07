namespace Domain {
    public class Question {
        public int Id { get; set; }
        public string Body { get; set; }
        public List<Option> OptionsAvailable { get; set; }
    }
}