using System.ComponentModel.DataAnnotations;

namespace Domain;
public class Option {
    public int Id { get; set; }
    public string? Text { get; set; }
    public bool? IsCorrect { get; set; }
    public bool? Selected { get; set; }
    public double? MarkValue { get; set; }
    public int QuestionId { get; set; } // afto to theloyme gia bidirectionality
}
