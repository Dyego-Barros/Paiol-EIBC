using Microsoft.AspNetCore.Mvc;
using Paiol_EIBC.Models;
using ToastNotifications.Core;
using AspNetCoreHero.ToastNotification;
using Microsoft.AspNetCore.Authorization;
using NuGet.Protocol.Plugins;
using System.Net;

namespace Paiol_EIBC.Controllers;

    
    public class MaterialController : Controller
    {
        private readonly MaterialService _service;


        public MaterialController(MaterialService service)
        {
            _service = service;
        }
    [Authorize]
    public IActionResult Index()
        {
            var listMaterial = _service.GetAll();
            return View(listMaterial);
        }
    [Authorize]
    [HttpGet]
        public IActionResult Create()
        {
            return View();

        }
    [Authorize]
    [HttpPost]        
        public IActionResult Create(Material material)
        {
          
           
            if(ModelState.IsValid)
            {
                
                _service.Create(material);
                TempData["CreateMaterial"] = "Material Criado com sucesso!";
            using (StreamWriter writer = new StreamWriter("Logs/Eibc_logs.txt", true))
            {
                writer.Write(User.Identity.Name + " " + $" Cadastrou o material {material.nome_material} quantidade do material {material.quantidade} ");
                writer.WriteLine(" " + "IP utilizado para cadastrar material" + " " + Dns.GetHostByName(Dns.GetHostName()).AddressList[3].ToString() + " " + "Data decadastro" + " " + DateTime.Today.ToShortDateString());
                writer.Close();


            }
            return Redirect("/Material");
            }else
            {
                 TempData["ErrorMaterial"] = "Error ao Criar Material";
                return Redirect("/Material");

            }
    }
    [Authorize]

    [HttpGet]
        public IActionResult Edit(int id)
        {
            var material = _service.GetId(id);
            return View(material);
        }
    [Authorize]
    [HttpPost]
        public IActionResult Edit(int id, Material material)
        {
            if(id == material.id)
            {
                _service.Update(id, material);
                TempData["EditMaterial"] = "Material editado com sucesso!";
            using (StreamWriter writer = new StreamWriter("Logs/Eibc_logs.txt", true))
            {
                writer.Write(User.Identity.Name + " " + $" Editou o material {material.nome_material} quantidade do material {material.quantidade} ");
                writer.WriteLine(" " + "IP utilizado para editar material" + " " + Dns.GetHostByName(Dns.GetHostName()).AddressList[3].ToString() + " " + "Data de edição" + " " + DateTime.Today.ToShortDateString());
                writer.Close();


            }
            return Redirect("/Material");

            }else
            {
                TempData["EditMaterialError"] = "Error ao Editar Material";
                 return Redirect("/Material");

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
        public IActionResult Delete(int id)
      {
        var delete = _service.GetId(id);
        return View(delete);
      }
    [Authorize]
    [HttpPost]
      public IActionResult Delete(int id, Material material)
      {
        if(id == material.id)
        {

            _service.Delete(id,material);
            TempData["DeleteMaterial"] = "Material Deletado com sucesso";
            using (StreamWriter writer = new StreamWriter("Logs/Eibc_logs.txt", true))
            {
                writer.Write(User.Identity.Name + " " + $" Deletou o material {material.nome_material} quantidade do material {material.quantidade} ");
                writer.WriteLine(" " + "IP utilizado para deletar material" + " " + Dns.GetHostByName(Dns.GetHostName()).AddressList[3].ToString() + " " + "Data de exclusão" + " " + DateTime.Today.ToShortDateString());
                writer.Close();


            }
            return Redirect("/Material");

        }else
        {
            TempData["ErrorDeleteMaterial"] = "Error ao deletar Material";
            return Redirect("/Material");
        }
      }
    }
