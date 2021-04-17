using System;
using Microsoft.AspNetCore.Mvc;
using minhaflortshirt.Models;

namespace minhaflortshirt.Controllers
{
    public class FornecedorController : Controller
    {
        public IActionResult Listar()
        {
            FornecedorViewModel viewModel = new FornecedorViewModel();
            FornecedorRepository cr = new FornecedorRepository();
            viewModel.Fornecedores = cr.List();

            return View(viewModel);
        }
    }
}