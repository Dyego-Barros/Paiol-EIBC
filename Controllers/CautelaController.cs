using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Paiol_EIBC.Models;
using iTextSharp.text.pdf;
using Rotativa;
using Rotativa.AspNetCore;
using ViewAsPdf = Rotativa.AspNetCore.ViewAsPdf;
using Microsoft.AspNetCore.Authorization;
using System.Net;

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
            using (StreamWriter writer = new StreamWriter("Logs/Eibc_logs.txt", true))
            {
                writer.Write(User.Identity.Name + " " + $" Cadastrou uma Nova Cautela para {cautela.militar_recebedor} para a missão {cautela.missao} em {cautela.data_saida}");
                writer.WriteLine(" "+ "IP utilizado para cadastrar a cautela"+" " + Dns.GetHostByName(Dns.GetHostName()).AddressList[3].ToString() + " " + "Data de cadastro"+ " " + DateTime.Today.ToShortDateString());
                writer.Close();


            }
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

            using (StreamWriter writer = new StreamWriter("Logs/Eibc_logs.txt", true))
            {
                writer.Write(User.Identity.Name + " " + $" Editou a  Cautela de {cautela.militar_recebedor} para a missão {cautela.missao} em {cautela.data_saida}");
                writer.WriteLine(" " + "IP utilizado para editar a cautela" + " " + Dns.GetHostByName(Dns.GetHostName()).AddressList[3].ToString() + " " + "Data de edição" + " " + DateTime.Today.ToShortDateString());
                writer.Close();


            }
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
            using (StreamWriter writer = new StreamWriter("Logs/Eibc_logs.txt", true))
            {
                writer.Write(User.Identity.Name + " " + $" Deletou a Cautela de {cautela.militar_recebedor} para a missão {cautela.missao} em {cautela.data_saida}");
                writer.WriteLine(" " + "IP utilizado para deletar a cautela" + " " + Dns.GetHostByName(Dns.GetHostName()).AddressList[3].ToString() + " " + "Data de exclusão" + " " + DateTime.Today.ToShortDateString());
                writer.Close();


            }
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