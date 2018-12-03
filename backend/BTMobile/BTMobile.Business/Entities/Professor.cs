using System;
using System.Collections.Generic;
using System.Text;

namespace BTMobile.Business.Entities
{
    public class Professor : BaseEntity
    {
        public Professor()
        {
            this.Fichas = new List<Ficha>();
        }

        
        public string Nome { get; set; }

        public IList<Ficha> Fichas { get; set; }
    }
}
