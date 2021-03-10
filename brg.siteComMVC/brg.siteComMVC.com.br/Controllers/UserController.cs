using brg.siteComMVC.com.br.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace brg.siteComMVC.com.br.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            List<UserViewModel> usuario = new List<UserViewModel>();

            usuario.Add(new UserViewModel(Guid.NewGuid(), "Glauco","Santos","glauco@gmail.com","(11) 94072-8535","Rua Maringá - 433","Brazil",1500,"411.223.168/79"));
            usuario.Add(new UserViewModel(Guid.NewGuid(), "Rafael","Kiss","rafa@gmail.com","(11) 97070-7070","Casa do Krlho","Brazil",1.750,"***.***.***/03"));
            usuario.Add(new UserViewModel(Guid.NewGuid(), "Humberto","Filho","betin@gmail.com","(11) 97070-7070","Longe pra porra", "Brazil", 2500, "***.***.***/18"));
            return View(usuario);
        }

        public IActionResult AddUser()
        {
            return View();
        }

        public IActionResult Adicionar()
        {

            return View();
        }
    }
}
