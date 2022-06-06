using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuieroPizza.BL;

namespace QuieroPizza.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var produtosBL = new ProductosBL();
            var listadeProductos = produtosBL.ObtenerProductos();

            return View(listadeProductos);
        }
    }
}