using System;
using System.Collections.Generic;
using System.Text;

namespace BTMobile.Business.Entities
{
    public class SerieFicha : BaseEntity
    {
        public SerieFicha()
        {
            this.ExerciciosSerie = new List<ExercicioSerie>();
            this.HistoricoExecucaoSerie = new List<HistoricoExecucaoSerie>();
        }

        public string RotuloSerie { get; set; }

        public Ficha Ficha { get; set; }
        public IList<ExercicioSerie> ExerciciosSerie { get; set; }
        public IList<HistoricoExecucaoSerie> HistoricoExecucaoSerie { get; set; }
    }
}
