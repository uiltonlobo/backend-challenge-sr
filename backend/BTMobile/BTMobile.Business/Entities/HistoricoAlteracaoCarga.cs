﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BTMobile.Business.Entities
{
    public class HistoricoAlteracaoCarga : BaseEntity
    {
        public DateTime DataHoraAlteracao { get; set; }
        public double NovaCarga { get; set; }

        public ExercicioSerie ExercicioSerie { get; set; }
    }
}
