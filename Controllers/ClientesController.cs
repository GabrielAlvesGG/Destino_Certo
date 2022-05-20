using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using atividade2.Models;

namespace atividade2.Controllers
{
    public class ClientesController : Controller
    {   

    /*                  iniciando CadastroClientes(V)         */
       public IActionResult CadastroClientes()
       {    
           return View();
       } 
       [HttpPost]
       public IActionResult CadastroClientes(Cliente cliente)
       {
           ClientesRepository cr = new ClientesRepository();
           cr.Inserir(cliente);
            ViewBag.Mensagem = "Cadastro Feito com sucesso";

           return View("Cadastra");
       }
       /*               encerrando CadastroClientes(V)        */
       
       /*               Iniciando Cadastrado(V)                */

        public IActionResult Cadastrado()
        {
            return View();
        }

       /*               encerrando Cadastrado(V)        */

       /*               iniciando ListaClientes(V)            */
       public IActionResult ListaClientes(Cliente clientes)
       {    
           if(HttpContext.Session.GetInt32("id")==null)
           return View("LoginCliente");
           ClientesRepository cr = new ClientesRepository();
           List<Cliente> lista = cr.ListarClientes(clientes);
           return View(lista);
       }
       /*               encerrando ListaCliente(V)            */
       
       /*               Iniciando  Deletar(V)                 */
        public IActionResult Deletar(int id)
        {   if(HttpContext.Session.GetInt32("id")== null)
            return View("LoginCliente");
            ClientesRepository cr = new ClientesRepository();
            cr.Deletar(id);
            return RedirectToAction("ListaClientes");
        }
        /*              encerrando Deletar(V)                 */

        /*              Iniciando  Atualizar(V)               */
        public IActionResult Atualizar(int id)
        {   
            if(HttpContext.Session.GetInt32("id") == null)
            return View("LoginCliente");
            ClientesRepository cr = new ClientesRepository();
            Cliente clienteEncontrado = cr.BuscarPorId(id);
            return View(clienteEncontrado);
        }
        [HttpPost]
        public IActionResult Atualizar(Cliente cliente)
        {   
            ClientesRepository cr = new ClientesRepository();
            cr.Atualizar(cliente);
            return RedirectToAction("ListaClientes");
        }
        /*              Encerrando Atualizar(V)               */
 
        /*              Iniciando  ValidandoCliente(V)        */

        public IActionResult LoginCliente()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginCliente(Cliente cliente)
        {
            ClientesRepository cr = new ClientesRepository();
            Cliente clienteEncontrado =  cr.ValidandoCliente(cliente);
            if(clienteEncontrado != null)
            {   
                HttpContext.Session.SetInt32("id", clienteEncontrado.id);
                HttpContext.Session.SetString("nome", clienteEncontrado.nome);
                ViewBag.Mensagem = "Você está logado!";
                return RedirectToAction("CadastraPacotes", "PacotesTuristicos");

            }
            else
            {
                ViewBag.Mensagem = "Erro ao logar verifique os campos preenchidos!";
            }
            return View();
        }
        /*               Encerrando LoginCliente(V)            */

        /*               Iniciando Logout(V)                   */

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("LoginCliente");
        }
        /*               Encerrnado Logout(V)                  */
    }   

}