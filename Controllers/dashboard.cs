using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace proyectoprueba.Controllers
{
    public class dashboard : Controller
    {
        // GET: dashboard
        public ActionResult index()
        {
            return View();
        }
    }
}
