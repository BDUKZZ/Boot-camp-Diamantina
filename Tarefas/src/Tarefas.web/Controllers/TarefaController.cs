using Microsoft.AspNetCore.Mvc;
using Tarefas.web.Models;

namespace Tarefas.web.Controllers
{
    public class TarefaController : Controller 
    {
        public IActionResult Create ()
        {
           return View();
        }
    }
      public IActionResult Index(){
        var listaDeTarefas = new List<TarefaViewModel>()
        {
            new TarefaViewModel(){Titulo = "Escovar os dentes"},
            new TarefaViewModel(){Titulo = "Arrumar a cama"},
            new TarefaViewModel(){Titulo = "Por o lixo para fora",Descricao = "somente ás terças"}
        }

        return View(listaDeTarefas);
      }
}