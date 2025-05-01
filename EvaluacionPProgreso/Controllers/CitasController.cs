using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EvaluacionPProgreso.Models;
using System.Threading.Tasks;
using System.Linq;
using EvaluacionPProgreso.Data;

namespace EvaluacionPProgreso.Controllers 
{
    public class CitasController : Controller
    {
        private readonly DanielSierraDBEvaluacionPProgreso _context;

        public CitasController(DanielSierraDBEvaluacionPProgreso context)
        {
            _context = context;
        }

        // GET: Citas/Create
        public IActionResult Create()
        {
            ViewData["MascotaId"] = new SelectList(_context.Mascota, "Id", "Nombre");
            return View();
        }

        // POST: Citas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FechaVisita,Motivo,RequiereMedicacion,Tarifa,MascotaId")] Cita cita)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cita);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["MascotaId"] = new SelectList(_context.Mascota, "Id", "Nombre", cita.MascotaId);
            return View(cita);
        }

        // Puedes agregar aquí el método Index si lo necesitas para el redirect
        public IActionResult Index()
        {
            var citas = _context.Cita.Include(c => c.Mascota).ToList();
            return View(citas);
        }
    }
}
