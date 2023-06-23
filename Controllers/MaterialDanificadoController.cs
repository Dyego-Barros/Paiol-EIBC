using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Paiol_EIBC.Models;
using System;

namespace Paiol_EIBC.Controllers;

public class MaterialDanificadoController: Controller
{
    private readonly MaterialDanificadoService _service;
    public MaterialDanificadoController(MaterialDanificadoService service)
    {
        _service = service;
    }
    [Authorize]
    public IActionResult Index()
    {
        var listMaterialDanificado = _service.GetAll();
        return View(listMaterialDanificado);
    }
    [Authorize]
    [HttpGet]
    public IActionResult Create()
    {
        return View();

    }
    [Authorize]
    [HttpPost]
    public IActionResult Create(MaterialDanificado materialDanificado)
    {
        if(ModelState.IsValid)
        {
            _service.Create(materialDanificado);
            TempData["MaterialDanificadoCreate"] = "Material Cadastrado com sucesso!";
            return Redirect("/MaterialDanificado");

        }else
        {
            TempData["ErrorMaterialDanificado"] = "Error ao Cadastar Material danificado";
            return Redirect("/MaterialDanificado");
        }

    }
    [Authorize]
    [HttpGet]
    public IActionResult Details(int id)
    {

        var details = _service.GetId(id);
        return View(details);

    }
    [Authorize]
    [HttpGet]
    public IActionResult Edit(int id)
    {
        var edit = _service.GetId(id);
        return View(edit);
    }
    [Authorize]
    [HttpPost]
    public IActionResult Edit(int id, MaterialDanificado materialDanificado)
    {
        if(id == materialDanificado.id)
        {

            _service.Update(materialDanificado);
            TempData["MaterialDanificadoEdit"] = "Material Editado com sucesso!";
            return Redirect("/MaterialDanificado");

        }else
        {
            TempData["ErrorEditMaterialDanificado"] = "Error ao editar Material!";
            return Redirect("/MaterialDanificado");
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
    public IActionResult Delete(int id, MaterialDanificado danificado)
    {
        if (id == danificado.id)
        {
            _service.Delete(danificado);
            TempData["MaterialDanificadoDelete"] = "Material Danificado Excluido com Sucesso!";
            return Redirect("/MaterialDanificado");

        }
        else
        {
            TempData["MaterialDanificadoDeleteError"] = "Error ao Excluir Material Danificado!";
            return Redirect("/MaterialDanificado");
        }

    }
}