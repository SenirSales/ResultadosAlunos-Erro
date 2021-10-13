using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResultadosAlunosMVC.Models
{
    public class Alunos
    {
        public int Id { get; set; }

        [StringLength(80, MinimumLength = 3)]
        [Required]
        [Display(Name = "Aluno")]
        public string Nome { get; set; }
        public int Id_Notas { get; set; }
        public int Id_Faltas { get; set; }
    }
}
