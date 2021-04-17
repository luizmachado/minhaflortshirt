using System;
using Microsoft.AspNetCore.Mvc;
using minhaflortshirt.Models;

namespace minhaflortshirt.Controllers
{
    public class ColaboradorController : Controller
    {
        public IActionResult Listar()
        {
            ColaboradorViewModel viewModel = new ColaboradorViewModel();
            ColaboradorRepository cr = new ColaboradorRepository();
            viewModel.Colaboradores = cr.List();

            return View(viewModel);
        }
    }
}