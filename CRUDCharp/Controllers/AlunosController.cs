using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDCharp.Models.Alunos;
using CRUDCharp.Models.Contexto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CRUDCharp.Controllers
{
    public class AlunosController : Controller
    {
        private readonly Contexto _contexto;
        public AlunosController(Contexto contexto)
        {
            _contexto = contexto;
        }

        // lista todos os alunos  _contexto.Aluno.ToList();
        public IActionResult Index()
        {
            var listar = _contexto.Aluno.ToList();
            SemestreAluno();
            return View(listar);
        }

        
        // retorna ums view em branco para prencher os dados
        [HttpGet]
        public IActionResult Create()
        {
            var aluno = new Aluno();
            SemestreAluno();
            return View(aluno);
        }

        // Metodo Post Envia as informações preenchidas para o banco
        
        [HttpPost]
        public IActionResult Create(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                _contexto.Aluno.Add(aluno);
                _contexto.SaveChanges();
                // RedirectToAction retorna para Index inicial
                return RedirectToAction("Index");
            }
            SemestreAluno();
            return View(aluno);
        }

        // Redireciona para a tela de Edição
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var aluno = _contexto.Aluno.Find(id);
            SemestreAluno();
            return View(aluno);
        }

        // TODO : Arrumar o POST do EDIT , esta criando um aluno novo

        // Faz a Edição
        [HttpPost]
        public IActionResult Edit(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                _contexto.Aluno.Update(aluno);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            SemestreAluno();
            return View(aluno);
        }

        // Redireciona para a tela de Delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var aluno = _contexto.Aluno.Find(id);
            SemestreAluno();
            return View(aluno);
        }

        // TODO : Arrumar o POST do DELETE 

        // Deleta O aluno 
        [HttpPost]
        public IActionResult Delete(Aluno _aluno)
        {
            var aluno = _contexto.Aluno.Find(_aluno);
            if (aluno != null)
            {
                _contexto.Aluno.Remove(aluno);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(aluno);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var aluno = _contexto.Aluno.Find(id);
            SemestreAluno();
            return View(aluno);
        }

        public void SemestreAluno()
        {
            var semestre = new List<SelectListItem>
            {
                new SelectListItem{ Value="1", Text = "1"},
                new SelectListItem{ Value="2", Text = "2"},
                new SelectListItem{ Value="3", Text = "3"},
                new SelectListItem{ Value="4", Text = "4"},
                new SelectListItem{ Value="5", Text = "5"},
                new SelectListItem{ Value="6", Text = "6"},
                new SelectListItem{ Value="7", Text = "7"},
                new SelectListItem{ Value="8", Text = "8"},
                new SelectListItem{ Value="9", Text = "9"},
                new SelectListItem{ Value="10", Text ="10"}
            };
            ViewBag.Semestre = semestre;
        }

    }
}
