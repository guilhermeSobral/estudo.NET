using Estudo.NET.Models.DAO;
using Estudo.NET.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Estudo.NET.Controllers
{
    public class UsuarioController : Controller
    {

        private UsuarioDAO dao;

        public UsuarioController(UsuarioDAO dao)
        {
            this.dao = dao;
        }
        
        public ActionResult Form()
        {
            return View();
        }

        public ActionResult Adiciona(Usuario usuario)
        {
            if(ModelState.IsValid)
            {
                dao.Adiciona(usuario);
                return RedirectToAction("Index");
            } 
            else
            {
                return View("Form", usuario);
            }
        }

        public ActionResult Index()
        {
            IList<Usuario> lista = dao.Lista();
            return View(lista);
        }
    }
}