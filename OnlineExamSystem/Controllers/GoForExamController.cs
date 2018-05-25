using System.Linq;
using Microsoft.AspNetCore.Mvc;
using OnlineExamSystem.Data;

namespace OnlineExamSystem.Controllers
{
    public class GoForExamController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GoForExamController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult ExamDetails(int id)
        {
            var model = _context.ExamPaper.FirstOrDefault(x => x.Id == id);
            return View(model);
        }

        
        public IActionResult Questions(int id)
        {
            var model = _context.Question.Where(x => x.ExamPaperId == id);
            return Json(model.ToList());
        }
    }
}