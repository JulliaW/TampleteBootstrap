using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TamplateBootstrap.Context;

namespace TamplateBootstrap.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly Contexto db = new Contexto();

        // GET: Funcionario
        public ActionResult Index()
        {
            return View(db.Funcionarios.ToList());
        }
    }
}