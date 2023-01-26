using Microsoft.AspNetCore.Mvc;
using Tarefas.web.Models;

namespace Tarefas.web.Controllers
{
    public class TarefaController : Controller 
    {
        public List<TarefaViewModel> listaDeTarefas { get; set; }

        public TarefaController()
        {
          listaDeTarefas = new List<TarefaViewModel>()
          {
              new TarefaViewModel(){ Id = 1, Titulo = "Escovar os dentes"},
              new TarefaViewModel(){Id = 2, "Arrumar a cama"},
              new TarefaViewModel(){Id = 3, "Por o lixo para fora",Descricao = "somente ás terças"}
          };
        }

        public IActionResult Create ()
        {
           return View();
        }
    
      public IActionResult Index()
      {
        return View(listaDeTarefas);
      }

      public IActionResult Details(int id)
      {
        var tarefa = listaDeTarefas.Find(m => m.Id == id);
        return View(tarefa);
      }
    
    }    
}