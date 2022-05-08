using Microsoft.AspNetCore.Mvc;
using PostgreSQLEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgreSQLEF.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            //Eviar una lista de usuarios
            List<User> lst = new List<User>();
            using (var db = new Models.DB.pruebaEFContext()) //Conexion
            {
                lst = (from d in db.Usuarios
                       select new User
                       {
                           Id = d.Id,
                           Email = d.Email
                       }).ToList();
            }
                return View(lst);
        }
    }
}
