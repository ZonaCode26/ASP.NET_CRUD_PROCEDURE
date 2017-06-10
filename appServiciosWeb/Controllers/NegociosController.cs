using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Dominio.Entidades;
using Dominio.Repositorio;

namespace appServiciosWeb.Controllers
{
    public class NegociosController : Controller
    {
        HerramientaBL herramientaBL = new HerramientaBL();
        ProveedorBL proveedorBL = new ProveedorBL();


        // GET: Negocios
        public ActionResult Index()
        {
            return View(herramientaBL.listadoHerramienta());
        }

        public ActionResult AgregarHerramienta() {

            ViewBag.proveedor = new  SelectList(proveedorBL.listaProveedor(), "idprov", "nomprov");


            return View( new tb_herramienta() );

        }

        [HttpPost]public ActionResult AgregarHerramienta(tb_herramienta reg)
        {

            ViewBag.proveedor = new SelectList(proveedorBL.listaProveedor(), "idprov", "nomprov",reg.idprov);

            ViewBag.mensaje = herramientaBL.AgregarHerramienta(reg);

            return View(reg);
        }

        public ActionResult ActualizarHerramienta(string id) {

            var reg = herramientaBL.listadoHerramienta().Where(x=> x.idHer==id).FirstOrDefault();

            ViewBag.proveedor = new SelectList(proveedorBL.listaProveedor(), "idprov", "nomprov", reg.idprov);


            return View( reg );

        }


        [HttpPost]
        public ActionResult ActualizarHerramienta(tb_herramienta reg) {

            ViewBag.proveedor = new SelectList(proveedorBL.listaProveedor(),"idprov","nomprov",reg.idprov);


            ViewBag.mensaje = herramientaBL.ActualizarHerramienta(reg);

            return View(reg);

        }




    }
}