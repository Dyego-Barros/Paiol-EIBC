using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Paiol_EIBC.Models;

namespace Paiol_EIBC.Controllers;
public class  LoginController : Controller
{
    private readonly UsuarioService _service;
    public LoginController(UsuarioService service)
    {
        _service = service;
    }

    [Authorize]
    public IActionResult Index()
    {

        var Model = _service.GetAll();
        
        return View(Model);
    }
    [Authorize]
    [HttpGet]
    public IActionResult Create()
    {
       
        return View();
    }
    [Authorize]
    [HttpPost]
    public IActionResult Create(Login login)
    {


     if(ModelState.IsValid)
     {
           _service.Create(login);
           TempData["CreateUser"] = "Usuário Criado com Sucesso";
           return Redirect("/Login");
     }
     else{
        return View("Create");
     }

    }
    [Authorize]
    public IActionResult Details(int id)
    {
        var userId = _service.GetId(id);
        return View(userId);
    }
    [Authorize]
    [HttpGet]
    public IActionResult Delete(int id)
    {

        var deleteUser = _service.GetId(id);
        return View(deleteUser);
    }
    [Authorize]
    [HttpPost]
    public IActionResult Delete(int id, Login login)
    {
        if(id == login.id)
        {
          _service.Delete(id,login);

            TempData["DeleteUser"] = "Usuário Deletado com Sucesso!";
            return Redirect("/Login");
        }
        else{
             TempData["ErrorDeleteUser"] = "Error ao tentar Deletar Usuário";
             return View();
        }

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
    public IActionResult Edit(int id, Login login)
    {
        if(id == login.id)
        {
            _service.Update(id, login);
            TempData["EditSuccess"]= "Usuário Editado com sucesso!";
            return Redirect("/Login");
        }else
        {
           TempData["EditError"] = "Error ao Editar Usuário!";
            return Redirect("/Login");
        }
    }

}