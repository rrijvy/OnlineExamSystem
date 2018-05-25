using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineExamSystem.Models
{
    public class ExamPaper
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Exam title")]
        public string ExamTitle { get; set; }

        [Required]
        [Display(Name = "Subject title")]
        public string SubjectName { get; set; }

        [Required]
        [Display(Name = "Subject code")]
        public string SubjectCode { get; set; }

        [Required]
        [Display(Name = "Total marks")]
        public int TotalMarks { get; set; }

        public string Instruction { get; set; }

        [Required]
        [Display(Name = "Exam date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public List<Question> Questions { get; set; }
    }
}
