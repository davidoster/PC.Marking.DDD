namespace Domain;

public class Question {
        public int Id { get; set; }
        public string Body { get; set; }
        public List<Option> OptionsAvailable { get; set; }
        public List<AwardedAnswer>? AwardedAnswers { get; set; }
        public int? AwardedMarks { get; set; }
        public int MaximumMarks { get; set; }
        public QuestionType QuestionType { get; set; }
        public ScenarioType ScenarioType { get; set; }
}