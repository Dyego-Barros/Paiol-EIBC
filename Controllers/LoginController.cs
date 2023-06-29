using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Paiol_EIBC.Models;
using System.Net;

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
            using (StreamWriter writer = new StreamWriter("Logs/Eibc_logs.txt", true))
            {
                writer.Write(User.Identity.Name + " " + $" Cadastrou o usuário {login.posto_graduacao}  {login.nome_guerra} ");
                writer.WriteLine(" " + "IP utilizado para cadastrar o usuário" + " " + Dns.GetHostByName(Dns.GetHostName()).AddressList[3].ToString() + " " + "Data de cadastro" + " " + DateTime.Today.ToShortDateString());
                writer.Close();


            }
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
            using (StreamWriter writer = new StreamWriter("Logs/Eibc_logs.txt", true))
            {
                writer.Write(User.Identity.Name + " " + $" Excluiu o usuário {login.posto_graduacao}  {login.nome_guerra} ");
                writer.WriteLine(" " + "IP utilizado para excluir o usuário" + " " + Dns.GetHostByName(Dns.GetHostName()).AddressList[3].ToString() + " " + "Data de exclusão" + " " + DateTime.Today.ToShortDateString());
                writer.Close();


            }
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
            using (StreamWriter writer = new StreamWriter("Logs/Eibc_logs.txt", true))
            {
                writer.Write(User.Identity.Name + " " + $"Editou o usuário {login.posto_graduacao}  {login.nome_guerra} ");
                writer.WriteLine(" " + "IP utilizado para editou o usuário" + " " + Dns.GetHostByName(Dns.GetHostName()).AddressList[3].ToString() + " " + "Data de edição" + " " + DateTime.Today.ToShortDateString());
                writer.Close();


            }
            return Redirect("/Login");
        }else
        {
           TempData["EditError"] = "Error ao Editar Usuário!";
            return Redirect("/Login");
        }
    }

}