using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Paiol_EIBC.Models;

namespace Paiol_EIBC.Controllers;

public class HomeController : Controller
{
    private readonly DatabaseContext _context;

    public HomeController(DatabaseContext context)
    {
        _context = context;
    }
 
    public IActionResult Index()
    {
        return View();
    }
   
    [HttpPost]
    public IActionResult Login(string nip, string password)
    {
        if(nip !=null && password != null)
        {
           var login = _context.logins.FromSql($"SELECT * FROM Users WHERE nip={nip} and password={password}");
           
            var count = login.Count();

            if(count == 1)
            {
                foreach (var usuario in login)
                {
                    List<Claim> claim = new List<Claim>();
                    {
                    claim.Add(new Claim(ClaimTypes.Name,usuario.posto_graduacao + " " + usuario.nome_guerra));
                    claim.Add(new Claim(ClaimTypes.SerialNumber, usuario.id.ToString()));
                    
                    }
                    var authproperties = new AuthenticationProperties()
                    {

                        ExpiresUtc = DateTime.Now.AddHours(8)
                    };


                    var ClaimPrincipal = new ClaimsPrincipal(new ClaimsIdentity(claim, CookieAuthenticationDefaults.AuthenticationScheme));

                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, ClaimPrincipal, authproperties);
                    return Redirect("/Cautela");
                }
               
            }
            else
            {
                TempData["ErrorLogin"] = "Erro ao realizar Login!";
                return Redirect("/Home");
            }

        }
        else
        {
            TempData["ErrorLogin"] = "Erro ao realizar Login!";
            return Redirect("/Home");
        }
        return Redirect("/Home");
    }

    [Authorize]  
    public IActionResult LogOff()
    {
        HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        return Redirect("/Home");
    }

    [HttpGet]
    [Authorize]

    public IActionResult Details()
    {
        var status = "PARCIAL";
        var parcial = _context.cautelaDevolvidas.FromSql($"SELECT * FROM cautelaDevolvida WHERE status_devolucao={status}");
        var parcialArray = parcial.ToArray();
        var parcialCount = parcial.Count();
        var totalQtd01=0;
        var totalQtd02 = 0;
        var totalQtd03 = 0;
        var totalQtd04 = 0;
        var totalQtd05 = 0;
        var totalQtd06 = 0;
        var totalQtd07 = 0;
        var totalQtd08 = 0;
        var totalQtd09 = 0;
        var totalQtd10 = 0;
        var totalQtd11 = 0;
        var totalQtd12 = 0;
        var totalQtd13 = 0;
        var totalQtd14 = 0;
        var totalQtd15 = 0;
        var totalQtd16 = 0;
        var totalQtd17 = 0;
        var totalQtd18 = 0;
        var totalQtd19 = 0;
        var totalQtd20 = 0;
        var totalQtd21 = 0;
        var totalQtd22 = 0;
        var totalQtd23 = 0;
        var totalQtd24 = 0;
        var totalQtd25 = 0;
        var totalQtd26 = 0;
        var totalQtd27 = 0;
        var totalQtd28 = 0;
        var totalQtd29 = 0;
        var totalQtd30 = 0;
        var totalQtd31 = 0;
        var totalQtd32 = 0;
        var totalQtd33 = 0;
        var totalQtd34 = 0; 
        var totalQtd35 = 0;

        for (int i=0; i < parcialCount; i++)
        {
            ViewBag.qtd01 = totalQtd01 = (int)(Convert.ToInt32(parcialArray[i].qtd01) + totalQtd01);
            ViewBag.qtd02 = totalQtd02 = (int)(Convert.ToInt32(parcialArray[i].qtd02) + totalQtd02);
            ViewBag.qtd03 = totalQtd03 = (int)(Convert.ToInt32(parcialArray[i].qtd03) + totalQtd03);
            ViewBag.qtd04 = totalQtd04 = (int)(Convert.ToInt32(parcialArray[i].qtd04) + totalQtd04);
            ViewBag.qtd05 = totalQtd05 = (int)(Convert.ToInt32(parcialArray[i].qtd05) + totalQtd05);
            ViewBag.qtd06 = totalQtd06 = (int)(Convert.ToInt32(parcialArray[i].qtd06) + totalQtd06);
            ViewBag.qtd07 = totalQtd07 = (int)(Convert.ToInt32(parcialArray[i].qtd07) + totalQtd07);
            ViewBag.qtd08 = totalQtd08 = (int)(Convert.ToInt32(parcialArray[i].qtd08) + totalQtd08);
            ViewBag.qtd09 = totalQtd09 = (int)(Convert.ToInt32(parcialArray[i].qtd09) + totalQtd09);
            ViewBag.qtd10 = totalQtd10 = (int)(Convert.ToInt32(parcialArray[i].qtd10) + totalQtd10);
            ViewBag.qtd11 = totalQtd11 = (int)(Convert.ToInt32(parcialArray[i].qtd11) + totalQtd11);
            ViewBag.qtd12 = totalQtd12 = (int)(Convert.ToInt32(parcialArray[i].qtd12) + totalQtd12);
            ViewBag.qtd13 = totalQtd13 = (int)(Convert.ToInt32(parcialArray[i].qtd13) + totalQtd13);
            ViewBag.qtd14 = totalQtd14 = (int)(Convert.ToInt32(parcialArray[i].qtd14) + totalQtd14);
            ViewBag.qtd15 = totalQtd15 = (int)(Convert.ToInt32(parcialArray[i].qtd15) + totalQtd15);
            ViewBag.qtd16 = totalQtd16 = (int)(Convert.ToInt32(parcialArray[i].qtd16) + totalQtd16);
            ViewBag.qtd17 = totalQtd17 = (int)(Convert.ToInt32(parcialArray[i].qtd17) + totalQtd17);
            ViewBag.qtd18 = totalQtd18 = (int)(Convert.ToInt32(parcialArray[i].qtd18) + totalQtd18);
            ViewBag.qtd19 = totalQtd19 = (int)(Convert.ToInt32(parcialArray[i].qtd19) + totalQtd19);
            ViewBag.qtd20 = totalQtd20 = (int)(Convert.ToInt32(parcialArray[i].qtd20) + totalQtd20);
            ViewBag.qtd21 = totalQtd21 = (int)(Convert.ToInt32(parcialArray[i].qtd21) + totalQtd21);
            ViewBag.qtd22 = totalQtd22 = (int)(Convert.ToInt32(parcialArray[i].qtd22) + totalQtd22);
            ViewBag.qtd23 = totalQtd23 = (int)(Convert.ToInt32(parcialArray[i].qtd23) + totalQtd23);
            ViewBag.qtd24 = totalQtd24 = (int)(Convert.ToInt32(parcialArray[i].qtd24) + totalQtd24);
            ViewBag.qtd25 = totalQtd25 = (int)(Convert.ToInt32(parcialArray[i].qtd25) + totalQtd25);
            ViewBag.qtd26 = totalQtd26 = (int)(Convert.ToInt32(parcialArray[i].qtd26) + totalQtd26);
            ViewBag.qtd27 = totalQtd27 = (int)(Convert.ToInt32(parcialArray[i].qtd27) + totalQtd27);
            ViewBag.qtd28 = totalQtd28 = (int)(Convert.ToInt32(parcialArray[i].qtd28) + totalQtd28);
            ViewBag.qtd29 = totalQtd29 = (int)(Convert.ToInt32(parcialArray[i].qtd29) + totalQtd29);
            ViewBag.qtd30 = totalQtd30 = (int)(Convert.ToInt32(parcialArray[i].qtd30) + totalQtd30);
            ViewBag.qtd31 = totalQtd31 = (int)(Convert.ToInt32(parcialArray[i].qtd31) + totalQtd31);
            ViewBag.qtd32 = totalQtd32 = (int)(Convert.ToInt32(parcialArray[i].qtd32) + totalQtd32);
            ViewBag.qtd33 = totalQtd33 = (int)(Convert.ToInt32(parcialArray[i].qtd33) + totalQtd33);
            ViewBag.qtd34 = totalQtd34 = (int)(Convert.ToInt32(parcialArray[i].qtd34) + totalQtd34);
            ViewBag.qtd35 = totalQtd35 = (int)(Convert.ToInt32(parcialArray[i].qtd35) + totalQtd35);

        }
        
        
        
        return View();
    }
}
