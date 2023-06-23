using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Paiol_EIBC;
using Paiol_EIBC.Models;
using Paiol_EIBC.Repositories.Services;
using Microsoft.AspNetCore.Authorization;

namespace Paiol_EIBC.Controllers
{
    public class CautelaDevolvidaController : Controller
    {
        private readonly CautelaDevolvidaService _service;


        public CautelaDevolvidaController(CautelaDevolvidaService service)
        {
            _service = service;
        }
        [Authorize]
        public IActionResult Index()
        {
            var listAll = _service.GetALL();
            return View(listAll);
        }
        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public IActionResult Create(CautelaDevolvida devolvida)
        {
            if(devolvida != null)
            {
                _service.Create(devolvida);
                TempData["DevoluçãoSucesso"] = "Devolução Cadastrada Com Sucesso!";
                return Redirect("/CautelaDevolvida");
            }else
            {
                TempData["ErrorDevolução"] = "Error ao Cadastar Devolução";
                return Redirect("/CautelaDevolvida");
            }

        }
        [Authorize]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var getCautela = _service.GetId(id);
            return View(getCautela);
        }
        [Authorize]
        [HttpPost]
        public IActionResult Edit(int id, CautelaDevolvida devolvida)
        {
            if (id == devolvida.id)
            {
                _service.Update(devolvida);
                TempData["EdiçãoCautelaDevolvida"] = "Cautela Devolvida Editada com Sucesso!";
                return Redirect("/CautelaDevolvida");

            }else
            {
                TempData["ErrorEdiçãoDevolvida"] = "Error ao editar Devolução";
                return Redirect("/CautelaDevolvida");
            }
        }
        [Authorize]
        [HttpGet]
        public IActionResult Details(int id)
        {
            if(id != null)
            {
               var details= _service.GetId(id);
                return View(details);
            }else
            {
                TempData["ErrorIdDevolução"] = "ID informado é inválido!";
                return Redirect("/CautelaDevolvida");

            }

        }
        [Authorize]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var delete = _service.GetId(id);
            return View(delete);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Delete(int id, CautelaDevolvida devolvida)
        {
            if(id == devolvida.id)
            {
                _service.Delete(id, devolvida);
                TempData["DeleteDevolvida"] = " Devolução Excluida co Sucesso ";
                return Redirect("/CautelaDevolvida");
            }
            else
            {
                TempData["ErrorDeleteDevolvida"] = "Error ao Excluir devolvida!";
                return Redirect("/CautelaDevolvida");
            }
        }
    }
}
