using AppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wflSistema;
using System.Data;

namespace AppMVC.Controllers
{
    public class ClientesController : Controller
    {

        
        //
        // GET: /Clientes/

        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(ClientesModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.CUIL = model.Cuil;
            }
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Insertar(ClientesModel cli)
        {
            wflClientes owflcli = new wflClientes();
            string strmensaje="";
            owflcli.insertarRegistro(ref strmensaje, cli.IDCliente,cli.Cuil, cli.Nombre, cli.Domicilio,cli.Apellido,cli.Localidad ,cli.Telpar ,cli.Telcel, cli.email ,cli.Observa);
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Buscar(ClientesModel cli)
        {
            wflClientes owflcli = new wflClientes();
            DataTable cliente = new DataTable();
            ClientesModel _cliente = new ClientesModel();
            string strmensaje = "";
            owflcli.obtenerRegistro(cli.IDCliente,ref cliente );
            try
            {
            _cliente.IDCliente=Convert.ToInt16(cliente.Rows[0]["idcliente"]);
            _cliente.Nombre = cliente.Rows[0]["nombre"].ToString();
            _cliente.Apellido = cliente.Rows[0]["apellido"].ToString();
            _cliente.Domicilio = cliente.Rows[0]["domicilio"].ToString();
            _cliente.Localidad = cliente.Rows[0]["localidad"].ToString();
            _cliente.Cuil = cliente.Rows[0]["cuil"].ToString();
            _cliente.Telpar = cliente.Rows[0]["telpart"].ToString();
            _cliente.Telcel = cliente.Rows[0]["telcel"].ToString();
            _cliente.email = cliente.Rows[0]["email"].ToString();
            _cliente.Observa = cliente.Rows[0]["observa"].ToString();
            }
            catch{}
            
            return View(_cliente);
        }
    }
}
