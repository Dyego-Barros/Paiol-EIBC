using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Paiol_EIBC.Models;
using iTextSharp.text.pdf;
using Rotativa;
using Rotativa.AspNetCore;
using ViewAsPdf = Rotativa.AspNetCore.ViewAsPdf;
using Microsoft.AspNetCore.Authorization;

namespace Paiol_EIBC.Controllers;


public class CautelaController :Controller
{

private readonly CautelaService _service;
   
public CautelaController(CautelaService service)
{
    _service = service;

}
    [Authorize]
    public IActionResult Index()
    {
        var listCautela = _service.Getall();

        return View(listCautela);
    }
    [Authorize]
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [Authorize]
    [HttpPost]
    public IActionResult Create(Cautela cautela)
    {

        if (ModelState.IsValid)
        {
            _service.Create(cautela);
            TempData["CreateCautela"] = "Cautela Criada Com Sucesso!";
            return Redirect("/Cautela");

        }
        else
        {
            TempData["ErrorCreateCautela"] = "Error ao Cadastrar Cautela";
            return Redirect("/Cautela");
        }
       


    }
    [Authorize]
    [HttpGet]
    public IActionResult Edit(int id)
    {
        var cautelaId = _service.GteId(id);
        return View(cautelaId);
    }
    [Authorize]
    [HttpPost]
    public IActionResult Edit(int id, Cautela cautela)
    {
        if(ModelState.IsValid)
        {

            _service.Update(cautela);
            TempData["EditCautela"] = "Cautela Editada com Sucesso!";
            return Redirect("/Cautela");

        }
        else
        {
            TempData["ErrorEditCautela"] = "Error ao Editar Cautela!";
            return Redirect("/Cautela");
        }
       
    }
    [Authorize]
    [HttpGet]
    public IActionResult Details(int id)
    {
        var cautelaId = _service.GteId(id);
        return View(cautelaId);
    }
    [Authorize]
    [HttpGet]
    public IActionResult Delete(int id)
    {
        var deleteCautela = _service.GteId(id);
        return View(deleteCautela);
    }
    [Authorize]
    [HttpPost]
    public IActionResult Delete(int id, Cautela cautela)
    {
        if (id == cautela.id)
        {
            _service.Delete(cautela);
            TempData["DeleteCautela"] = "Cautela Deletada com Sucesso!";
            return Redirect("/Cautela");
        }
        else
        {
            TempData["ErrorDeleteCautela"] = "Error ao Deletar Cautela!";
            return Redirect("/Cautela");
        }
       
    }
    [Authorize]
    public IActionResult PDF(int id)
    {
        var cautelaPdf = _service.GteId(id);
       
        return new ViewAsPdf("PDF",cautelaPdf);

    }
}