using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineExamSystem.Models
{
    public class Result
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Exam title")]
        public string ExamTitle { get; set; }

        [Display(Name = "Result date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Total marks")]
        public int TotalMarks { get; set; }

        [Required]
        [Display(Name = "Obtain marks")]
        public int ObtainMarks { get; set; }

        public int UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}
