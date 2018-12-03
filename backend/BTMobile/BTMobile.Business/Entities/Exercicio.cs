using System;
using System.Collections.Generic;
using System.Text;

namespace BTMobile.Business.Entities
{
    public class Exercicio : BaseEntity
    {
        public Exercicio()
        {
            this.ExerciciosSerie = new List<ExercicioSerie>();
        }

        public string Nome { get; set; }

        public IList<ExercicioSerie> ExerciciosSerie { get; set; }
    }
}
