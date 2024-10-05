using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using parcial_antaurco.Data;
using parcial_antaurco.Models;

namespace parcial_antaurco.Controllers
{
    public class RemesasController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public RemesasController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // Acción para la página principal (Home)
        public IActionResult Index()
        {
            return View();
        }

        // Acción para mostrar el formulario de creación de remesa
        [HttpGet]
        public IActionResult CrearRemesa()
        {
            return View();
        }

        // Acción para registrar la remesa
        [HttpPost]
        public async Task<IActionResult> CrearRemesa(Remesa remesa)
        {
            if (ModelState.IsValid)
            {
                remesa.MontoFinal = remesa.MontoEnviado; // Inicialmente sin conversión
                remesa.Estado = "Pendiente";
                _context.Remesas.Add(remesa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(remesa);
        }

        // Acción para listar todas las remesas
        public async Task<IActionResult> ListarRemesas()
        {
            var remesas = await _context.Remesas.ToListAsync();
            return View(remesas);
        }

        // Acción para verificar el rol del usuario y mostrar la vista correspondiente
        public async Task<IActionResult> MostrarOpciones()
        {
            var user = await _userManager.GetUserAsync(User);
            var roles = await _userManager.GetRolesAsync(user);

            if (roles.Contains("admin"))
            {
                return RedirectToAction(nameof(ListarRemesas)); // Redirige al admin a listar remesas
            }
            else
            {
                return RedirectToAction(nameof(CrearRemesa)); // Redirige al usuario a crear remesa
            }
        }
    }
}
