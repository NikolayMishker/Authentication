using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Authentication.Models;
using Microsoft.AspNetCore.Authorization;

namespace Authentication.Controllers
{
    public class HomeController : Controller
    {
        //Атрибут Authorize предотвращает неаутентифицированный доступ к методу Index
        //Если анонимный пользователь попытается обратиться к этому методу, то его 
        //перенаправит по пути Account/Login, то есть на метод логина.

       [Authorize]
        public IActionResult Index()
        {
            return Content(User.Identity.Name);
        }
    }
}
