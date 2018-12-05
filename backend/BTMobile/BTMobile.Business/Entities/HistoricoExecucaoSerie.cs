using System;
using System.Collections.Generic;
using System.Text;

namespace BTMobile.Business.Entities
{
    public class HistoricoExecucaoSerie : BaseEntity
    {
        public int SerieFichaId { get; set; }
        public DateTime DataHoraExecucao { get; set; }

        public SerieFicha SerieFicha { get; set; }
    }
}
