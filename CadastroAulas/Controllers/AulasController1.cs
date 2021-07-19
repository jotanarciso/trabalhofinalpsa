using CadastroAulas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroAula.Controllers
{
    public class AulasController : Controller
    {

        private readonly Contexto _contexto;

        public AulasController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _contexto.Aulas.ToListAsync());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Aula aula)
        {
            if (ModelState.IsValid)
            {
                _contexto.Add(aula);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(aula);
            }
        }
        [HttpGet]
        public IActionResult Edit(int? codcred)
        {
            if (codcred != null)
            {
                Aula aula = _contexto.Aulas.Find(codcred);
                return View(aula);
            }
            else return NotFound();
        }

        [HttpPost] public async Task<IActionResult> Edit(int? codcred, Aula aula)
        {
            if (codcred != null)
            {
                if (ModelState.IsValid)
                {
                    _contexto.Update(aula);
                    await _contexto.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }

                else return View(aula);
            }
            else return NotFound();
        }

        [HttpGet]
        public IActionResult Delete(int? codcred)
        {
            if (codcred != null)
            {
                Aula aula = _contexto.Aulas.Find(codcred);
                return View(aula);
            }
            else return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete (int? codcred, Aula aula)
        {
            if (codcred != null)
            {
                _contexto.Remove(aula);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else return NotFound();
        }
    }
}
