using BTMobile.Business.DB;
using BTMobile.Business.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BTMobile.Business.Repository
{
    public class FichaRepository : GenericRepository<Ficha>, IFichaRepository
    {
        public FichaRepository(BTMobileContext contexto) : base(contexto)
        {
        }

        public override void Incluir(Ficha entidade)
        {
            base.Incluir(entidade);
        }
    }
}
