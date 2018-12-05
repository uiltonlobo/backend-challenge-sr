using System;
using System.Collections.Generic;
using System.Text;

namespace BTMobile.Business.Entities
{
    public class Ficha : BaseEntity
    {
        public Ficha()
        {
            this.Series = new List<SerieFicha>();
        }

        public int ProfessorId { get; set; }
        public int ClienteId { get; set; }
        public DateTime DataCriacao { get; set; }

        public Professor Professor { get; set; }
        public Cliente Cliente { get; set; }
        public IList<SerieFicha> Series { get; set; }
    }
}
