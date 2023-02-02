using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace proyectoprueba.Controllers
{
    public class formulario : Controller
    {
        // GET: formulario
        public ActionResult addUser()
        {
            return View();
        }

    }
}
