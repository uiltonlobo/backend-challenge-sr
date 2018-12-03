using System;
using System.Collections.Generic;
using System.Text;

namespace BTMobile.Business.Entities
{
    public class Contrato : BaseEntity
    {
        public bool Ativo { get; set; }

        public Cliente Cliente { get; set; }
    }
}
