using System.ComponentModel.DataAnnotations;

namespace OnlineExamSystem.Models
{
    public class Question
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Question name")]
        public string QuestionName { get; set; }

        [Required]
        [Display(Name = "Option A")]
        public string OptionA { get; set; }

        [Required]
        [Display(Name = "Option B")]
        public string OptionB { get; set; }

        [Required]
        [Display(Name = "Option C")]
        public string OptionC { get; set; }

        [Required]
        [Display(Name = "Option D")]
        public string OptionD { get; set; }

        [Required]
        [Display(Name = "Right answer")]
        public string RightAnswer { get; set; }

        [Required]
        [Display(Name = "Exam name")]
        public int ExamPaperId { get; set; }

        [Display(Name = "Exam Paper")]
        public ExamPaper ExmaPaper { get; set; }
    }
}
