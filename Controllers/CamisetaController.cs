using System;
using Microsoft.AspNetCore.Mvc;
using minhaflortshirt.Models;

namespace minhaflortshirt.Controllers
{
    public class CamisetaController : Controller
    {
        public IActionResult Listar()
        {
            CamisetaViewModel viewModel = new CamisetaViewModel();
            CamisetaRepository cr = new CamisetaRepository();
            viewModel.Camisetas = cr.List();

            return View(viewModel);
        }
    }
}