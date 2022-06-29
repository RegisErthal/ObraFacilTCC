using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ObraFacil.Infra.Contexts;
using ObraFacil.Infra.Entities;

namespace ObraFacil.Server.Controllers
{
    public class FundacaoModelsController : Controller
    {
        private readonly ObraFacilContext _context;

        public FundacaoModelsController(ObraFacilContext context)
        {
            _context = context;
        }

        // GET: FundacaoModels
        public async Task<IActionResult> Index()
        {
              return _context.Fundacao != null ? 
                          View(await _context.Fundacao.ToListAsync()) :
                          Problem("Entity set 'ObraFacilContext.Fundacao'  is null.");
        }

        // GET: FundacaoModels/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.Fundacao == null)
            {
                return NotFound();
            }

            var fundacaoModel = await _context.Fundacao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fundacaoModel == null)
            {
                return NotFound();
            }

            return View(fundacaoModel);
        }

        // GET: FundacaoModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FundacaoModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TamanhoAlicerce,AlturaPedra,LarguraPedra,ProfundidadePedra,QuantidadeEstacas,BarrasFerro,AlturaViga,ProfundidadeViga,PrevisaoEntrega")] FundacaoModel fundacaoModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fundacaoModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fundacaoModel);
        }

        // GET: FundacaoModels/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.Fundacao == null)
            {
                return NotFound();
            }

            var fundacaoModel = await _context.Fundacao.FindAsync(id);
            if (fundacaoModel == null)
            {
                return NotFound();
            }
            return View(fundacaoModel);
        }

        // POST: FundacaoModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,TamanhoAlicerce,AlturaPedra,LarguraPedra,ProfundidadePedra,QuantidadeEstacas,BarrasFerro,AlturaViga,ProfundidadeViga,PrevisaoEntrega")] FundacaoModel fundacaoModel)
        {
            if (id != fundacaoModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fundacaoModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FundacaoModelExists(fundacaoModel.Id))
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
            return View(fundacaoModel);
        }

        // GET: FundacaoModels/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.Fundacao == null)
            {
                return NotFound();
            }

            var fundacaoModel = await _context.Fundacao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fundacaoModel == null)
            {
                return NotFound();
            }

            return View(fundacaoModel);
        }

        // POST: FundacaoModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.Fundacao == null)
            {
                return Problem("Entity set 'ObraFacilContext.Fundacao'  is null.");
            }
            var fundacaoModel = await _context.Fundacao.FindAsync(id);
            if (fundacaoModel != null)
            {
                _context.Fundacao.Remove(fundacaoModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FundacaoModelExists(long id)
        {
          return (_context.Fundacao?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
