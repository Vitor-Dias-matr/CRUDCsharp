using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace CRUDCharp.Models.Alunos
{
    public class Aluno
    {
        [Display(Description ="ID")]
        public int AlunoId { get; set; }

        [Display(Description ="Nome")]
        public string Nome { get; set; }

        [Display(Description ="Idade")]
        public int Idade { get; set; }

        //TODO: Arrumar o Sexo colocar masculino ou feminino

        [Display(Description ="Sexo")]
        public bool Sexo { get; set; }

        [Display(Description ="Curso")]
        public string Curso { get; set; }

        [Display(Description ="Semestre")]
        public int Semestre { get; set; }

    }
}
