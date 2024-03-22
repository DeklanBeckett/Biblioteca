using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers{
    public class LibrosController : Controller{
        public IActionResult Index(){
            return View();
        }
        
    }
}