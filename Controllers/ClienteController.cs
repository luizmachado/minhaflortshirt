using System;
using Microsoft.AspNetCore.Mvc;
using minhaflortshirt.Models;

namespace minhaflortshirt.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Listar()
        {
            ClienteViewModel viewModel = new ClienteViewModel();
            ClienteRespository cr = new ClienteRespository();
            viewModel.Clientes = cr.List();

            return View(viewModel);
        }
    }
}