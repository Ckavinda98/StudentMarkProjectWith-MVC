using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentMarkProject.Web.Models;

namespace StudentMarkProject.Web.Controllers
{
    public class StudentMarksController : Controller
    {
        private readonly StudentMarkProjectDbContext _context;

        public StudentMarksController(StudentMarkProjectDbContext context)
        {
            _context = context;
        }

        // GET: StudentMarks
        public async Task<IActionResult> Index()
        {
            return View(await _context.StudentMarks.ToListAsync());
        }

        // GET: StudentMarks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentMark = await _context.StudentMarks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentMark == null)
            {
                return NotFound();
            }

            return View(studentMark);
        }

        // GET: StudentMarks/Create
        public IActionResult Create()
        {
            var newStudentMarkViewModel = new StudentMarkViewModel();
            newStudentMarkViewModel.Students = _context.Students.ToList();
            newStudentMarkViewModel.Teachers = _context.Teachers.ToList();
            newStudentMarkViewModel.Subjects = _context.Subjects.ToList();
            return View(newStudentMarkViewModel);
        }

        // POST: StudentMarks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StudentMarkViewModel newStudentMarkViewModel)
        {
            if (ModelState.IsValid)
            {
                var newStudentMark = new StudentMark
                {
                    StudentId = newStudentMarkViewModel.StudentId,
                    TeacherId = newStudentMarkViewModel.TeacherId,
                    SubjectId = newStudentMarkViewModel.SubjectId,
                };
                _context.Add(newStudentMark);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(newStudentMarkViewModel);
        }

        // GET: StudentMarks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentMark = await _context.StudentMarks.FindAsync(id);
            if (studentMark == null)
            {
                return NotFound();
            }
            return View(studentMark);
        }

        // POST: StudentMarks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Marks,StudentId,TeacherId,SubjectId")] StudentMark studentMark)
        {
            if (id != studentMark.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentMark);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentMarkExists(studentMark.Id))
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
            return View(studentMark);
        }

        // GET: StudentMarks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentMark = await _context.StudentMarks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentMark == null)
            {
                return NotFound();
            }

            return View(studentMark);
        }

        // POST: StudentMarks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentMark = await _context.StudentMarks.FindAsync(id);
            if (studentMark != null)
            {
                _context.StudentMarks.Remove(studentMark);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentMarkExists(int id)
        {
            return _context.StudentMarks.Any(e => e.Id == id);
        }
    }
}
