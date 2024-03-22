using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers{
    public class PrestamoController : Controller{
        public IActionResult Index(){
            return View();
        }
        
    }
}