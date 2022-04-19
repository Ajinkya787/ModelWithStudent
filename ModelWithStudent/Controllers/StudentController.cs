using Microsoft.AspNetCore.Mvc;

namespace ModelWithStudent.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}
