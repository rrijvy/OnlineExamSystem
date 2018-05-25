using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineExamSystem.Data;
using OnlineExamSystem.Models;

namespace OnlineExamSystem.Controllers
{
    public class ExamPapersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExamPapersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ExamPapers
        public async Task<IActionResult> Index()
        {
            return View(await _context.ExamPaper.ToListAsync());
        }

        // GET: ExamPapers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var examPaper = await _context.ExamPaper
                .SingleOrDefaultAsync(m => m.Id == id);
            if (examPaper == null)
            {
                return NotFound();
            }

            return View(examPaper);
        }

        // GET: ExamPapers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ExamPapers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ExamTitle,SubjectName,SubjectCode,TotalMarks,Instruction,Date")] ExamPaper examPaper)
        {
            if (ModelState.IsValid)
            {
                _context.Add(examPaper);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(examPaper);
        }

        // GET: ExamPapers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var examPaper = await _context.ExamPaper.SingleOrDefaultAsync(m => m.Id == id);
            if (examPaper == null)
            {
                return NotFound();
            }
            return View(examPaper);
        }

        // POST: ExamPapers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ExamTitle,SubjectName,SubjectCode,TotalMarks,Instruction,Date")] ExamPaper examPaper)
        {
            if (id != examPaper.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(examPaper);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExamPaperExists(examPaper.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(examPaper);
        }

        // GET: ExamPapers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var examPaper = await _context.ExamPaper
                .SingleOrDefaultAsync(m => m.Id == id);
            if (examPaper == null)
            {
                return NotFound();
            }

            return View(examPaper);
        }

        // POST: ExamPapers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var examPaper = await _context.ExamPaper.SingleOrDefaultAsync(m => m.Id == id);
            _context.ExamPaper.Remove(examPaper);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExamPaperExists(int id)
        {
            return _context.ExamPaper.Any(e => e.Id == id);
        }
    }
}
