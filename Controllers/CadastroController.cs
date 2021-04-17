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
            FornecedorViewModel viewModel = new FornecedorViewModel();
            FornecedorRepository fr = new FornecedorRepository();
            viewModel.Fornecedores = fr.ListFornecedor();

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

        public IActionResult Cliente()
        {
            return View();
        }
       [HttpPost]
       public IActionResult CadastroCliente(Cliente novoClliente)
       {
           try
           {
               ClienteRespository cr = new ClienteRespository();
               cr.Insert(novoClliente);

               return Json(new { Status = "OK"});
           }
           catch(Exception e)
           {
               return Json(new {Status = "FALHA", Mensagem = e.Message});
           }

       } 

    }
}