using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers{
    public class LoginController : Controller{
        public IActionResult Login(){
            return View();
        }
    }
}