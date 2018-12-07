using BTMobile.Business.DB;
using BTMobile.Business.Entities;
using BTMobile.Business.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace BTMobile.Business.Business
{
    public class ExercicioSerieBusiness : GenericBusiness<ExercicioSerie>, IExercicioSerieBusiness
    {
        BTMobileContext contexto;
        IGenericRepository<ExercicioSerie> exercicoRepository;
        IGenericRepository<HistoricoAlteracaoCarga> historicoRepository;

        public ExercicioSerieBusiness()
        {
            contexto = new BTMobileContext();
            exercicoRepository = new GenericRepository<ExercicioSerie>(contexto);
            historicoRepository = new GenericRepository<HistoricoAlteracaoCarga>(contexto);
        }

        public void AlterarCarga(int fichaId, int clienteId, int exercicioSerieId, double valorCarga)
        {
            //Verificar se o clienteId é o da ficha

            using (TransactionScope scope = new TransactionScope())
            {
                ExercicioSerie exercicio = exercicoRepository.ObterPorId(exercicioSerieId);

                if (exercicio != null)
                {
                    exercicio.Carga = valorCarga;
                    exercicoRepository.Alterar(exercicio);
                }

                HistoricoAlteracaoCarga historico = new HistoricoAlteracaoCarga();
                historico.DataHoraAlteracao = DateTime.Now;
                historico.ExercicioSerieId = exercicioSerieId;
                historico.NovaCarga = valorCarga;

                historicoRepository.Incluir(historico);

                this.contexto.SaveChanges();
                scope.Complete();
            }
        }
    }
}
