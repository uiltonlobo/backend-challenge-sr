using BTMobile.Business.DB;
using BTMobile.Business.Entities;
using BTMobile.Business.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BTMobile.Business.Business
{
    public class FichaBusiness : GenericBusiness<Ficha>, IFichaBusiness
    {
        protected BTMobileContext contexto;
        private IFichaRepository fichaRepository;

        public FichaBusiness()
        {
            this.contexto = new BTMobileContext();
            fichaRepository = new FichaRepository(this.contexto);
        }

        public override void Incluir(Ficha entidade)
        {
            this.fichaRepository.Incluir(entidade);
        }
    }
}
