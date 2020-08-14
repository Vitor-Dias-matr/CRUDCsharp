using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CRUDCharp.Controllers
{
    public class Funcionarios : Controller
    {

        // TODO: Fazer o crud dos funcionarios
        public IActionResult Index()
        {
            return View();
        }
    }
}
