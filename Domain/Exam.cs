namespace Domain; 
public class Exam {
    public int Id { get; set; }
    public Dictionary<Question, bool> AutoMarkGrade { get; set; }
    public StateEnum State { get; set; }
    public DateTime DateAssigned { get; set; }
    public Dictionary<Question, List<Option>> CandidatesAnswers { get; set; }
    public Dictionary<Question, bool> AutoMark { get; set; } // Ti kanoume me ta multiple answers?
    public Dictionary<Question, bool?>? MarkersMarking { get; set; }
}



    //List<Question> Questions { get; set; } // Q1
    //List<PossibleAnswers> Answers { get; set; }  // Q1.PossibleAnswers[0] = "sdfsdfsdf", Q1.PossibleAnswers[1] = "sdfsdfsdf"
    //List<SubmittedAnswers> SubmittedAnswers { get; set; }
    //List<CorrectAnswers> CorrectAnswers { get; set; }
