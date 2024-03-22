using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers{
    public class UsuarioController : Controller{
        public IActionResult Index(){
            return View();
        }
        
    }
}