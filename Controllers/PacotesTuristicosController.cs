using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using atividade2.Models;
using atividade2.Controllers;

namespace atividade2.Controllers
{
    public class PacotesTuristicosController : Controller
    {  
    /*    Inicia CadastraPacotes(V)      */
    public IActionResult CadastraPacotes()
    {   
    /*    Validação de cadastro           */
        if(HttpContext.Session.GetInt32("id")==null)
        return RedirectToAction("LoginCliente", "Clientes");
        /*    Validação de cadastro           */
        return View();
    }        
   [HttpPost]
    public IActionResult CadastraPacotes(PacotesTuristicos pacotes)
    {   
        PacotesTuristicosRepository pr = new PacotesTuristicosRepository();
        pr.InserirPacote(pacotes);
        ViewBag.Mensagem = "Pacote Cadastrado com sucesso!!";

        return View();
    }
    /*    encerrando CadastrarPacotes(V) */

    /*     Iniciando ListaPacotes(V)      */
    public IActionResult ListaPacotes(PacotesTuristicos pacotes)
    {   /*        Validação de Login       */
        if(HttpContext.Session.GetInt32("id") ==null)
        return RedirectToAction("LoginCliente", "Clientes");
        /*        Validação de Login        */
        PacotesTuristicosRepository pr = new PacotesTuristicosRepository();
        List<PacotesTuristicos> lista = pr.ListarPacotes(pacotes);
        return View(lista);
        
    }
    /*  Encerrando ListaPacotes(V)        */
    /*   Iniciando Deletar(V)             */
    public IActionResult Deletar (int idViagem)
    {   
    /*    Validação de cadastro           */
        if(HttpContext.Session.GetInt32("id") == null)
        return RedirectToAction("LoginCliente", "Clientes");
    /*    Validação de cadastro           */
        PacotesTuristicosRepository pr = new PacotesTuristicosRepository();
        pr.Deletar(idViagem);
        return RedirectToAction("ListaPacotes");
    }
    /*    encerrando Deletar(V)            */

    /*    Iniciando AtualizarPacotes(V)     */
    public IActionResult AtualizarPacotes(int idViagem)
    {   
        /*    Validação de cadastro           */
        if(HttpContext.Session.GetInt32("id")==null)
        return RedirectToAction("LoginCliente", "Clientes");
        /*    Validação de cadastro           */
        PacotesTuristicosRepository pr = new PacotesTuristicosRepository();
        PacotesTuristicos pacotesEncontrado = pr.BuscarPorId(idViagem);
        return View(pacotesEncontrado);
    }
    [HttpPost]
    public IActionResult AtualizarPacotes(PacotesTuristicos pacotesEncontrado)
    {
        PacotesTuristicosRepository pr = new PacotesTuristicosRepository();
        pr.AtualizarPacotes(pacotesEncontrado);
        return RedirectToAction("ListaPacotes");
    }
     /*    encerrando AtualizarPacotes(V)    */
    }
    
}