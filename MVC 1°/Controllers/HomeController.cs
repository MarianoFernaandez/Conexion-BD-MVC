using Microsoft.AspNetCore.Mvc;
using MVC_1_.Models;
using System.Diagnostics;


namespace MVC_1_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       
        DbProyectoContext db = new DbProyectoContext();

        public IActionResult SignUp() 
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult SignUp(Usuario usuario)
        {
            if (db.Usuarios.Any(x => x.Email == usuario.Email))
            {
                ViewBag.Notification = "Esta cuenta ya existe";
                return View();
            }
            else
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();

                //HttpContext.Session.SetString("idUsuario", usuario.IdUsuario.ToString());
                HttpContext.Session.SetString("email", usuario.Email.ToString());
                HttpContext.Session.SetString("clave", usuario.Clave.ToString());
                return RedirectToAction("Index", "Home");
            }

        }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
