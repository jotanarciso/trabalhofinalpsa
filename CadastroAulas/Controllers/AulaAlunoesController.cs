using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CadastroAulas.Models;

namespace CadastroAulas.Controllers
{
    public class AulaAlunoesController : Controller
    {
        private readonly Contexto _context;

        public AulaAlunoesController(Contexto context)
        {
            _context = context;
        }

        // GET: AulaAlunoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.AulaAluno.ToListAsync());
        }

        // GET: AulaAlunoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aulaAluno = await _context.AulaAluno
                .FirstOrDefaultAsync(m => m.key == id);
            if (aulaAluno == null)
            {
                return NotFound();
            }

            return View(aulaAluno);
        }

        // GET: AulaAlunoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AulaAlunoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("key,Aluno,Codcred")] AulaAluno aulaAluno)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aulaAluno);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aulaAluno);
        }

        // GET: AulaAlunoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aulaAluno = await _context.AulaAluno.FindAsync(id);
            if (aulaAluno == null)
            {
                return NotFound();
            }
            return View(aulaAluno);
        }

        // POST: AulaAlunoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("key,Aluno,Codcred")] AulaAluno aulaAluno)
        {
            if (id != aulaAluno.key)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aulaAluno);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AulaAlunoExists(aulaAluno.key))
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
            return View(aulaAluno);
        }

        // GET: AulaAlunoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aulaAluno = await _context.AulaAluno
                .FirstOrDefaultAsync(m => m.key == id);
            if (aulaAluno == null)
            {
                return NotFound();
            }

            return View(aulaAluno);
        }

        // POST: AulaAlunoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aulaAluno = await _context.AulaAluno.FindAsync(id);
            _context.AulaAluno.Remove(aulaAluno);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AulaAlunoExists(int id)
        {
            return _context.AulaAluno.Any(e => e.key == id);
        }
    }
}
