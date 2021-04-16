using System;
using Microsoft.AspNetCore.Mvc;
using minhaflortshirt.Models;

namespace minhaflortshirt.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Fornecedor()
        {
            return View();
        }
       [HttpPost]
       public IActionResult CadastroFornecedor(Fornecedor novoFornecedor)
       {
           try
           {
               FornecedorRepository fr = new FornecedorRepository();
               fr.Insert(novoFornecedor);

               return Json(new { Status = "OK"});
           }
           catch(Exception e)
           {
               return Json(new {Status = "FALHA", Mensagem = e.Message});
           }

       } 
        public IActionResult Camiseta()
        {
            CadastroViewModel viewModel = new CadastroViewModel();

            FornecedorRepository fr = new FornecedorRepository();
            viewModel.Fornecedores = fr.List();
            return View(viewModel);
        }
       [HttpPost]
       public IActionResult CadastroCamiseta(Camiseta novaCamiseta)
       {
           try
           {
               CamisetaRepository cr = new CamisetaRepository();
               cr.Insert(novaCamiseta);

               return Json(new { Status = "OK"});
           }
           catch(Exception e)
           {
               return Json(new {Status = "FALHA", Mensagem = e.Message});
           }

       } 
    }
}