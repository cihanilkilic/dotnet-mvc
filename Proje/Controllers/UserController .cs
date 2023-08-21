using Microsoft.AspNetCore.Mvc;

namespace Proje.Controllers
{
    public class UserController : Controller
    {

        public IActionResult Login()
        {
            // id parametresine göre bir kullanıcı profili görüntüle
            // ...
            return View(); // Profile.cshtml görünümünü döndür
        }
        public IActionResult Register()
        {
            // id parametresine göre bir kullanıcı profili görüntüle
            // ...
            return View(); // Profile.cshtml görünümünü döndür
        }
    }
}
