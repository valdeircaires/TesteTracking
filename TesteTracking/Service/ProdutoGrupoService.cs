using System;
using TesteTracking.Domain.Commmands;
using TesteTracking.Domain.Entities;

namespace TesteTracking.Service
{
    public class ProdutoGrupoService
    {
        private ProdutoGrupoRepository _repo;
        private UnityOfWork _uow;
        public ProdutoGrupoService(ProdutoGrupoRepository repo, UnityOfWork uow)
        {
            _repo = repo;
            _uow = uow;
        }

        public ProdutoGrupoCommand ObterGrupoPorId(Guid id)
        {
            return _repo.BuscarPorId(id);
        }

        public void Inserir(ProdutoGrupoCommand grupo)
        {
            _repo.Inserir(new ProdutoGrupo(grupo.Id, grupo.NomeGrupo));
            Commit();
        }

        public void Atualizar(ProdutoGrupoCommand grupo)
        {
            _repo.Atualizar(new ProdutoGrupo(grupo.Id, grupo.NomeGrupo));
            Commit();
        }

        private void Commit()
        {
            _uow.Commit();
        }

        private void Rollback()
        {
            _uow.Rollback();
        }
    }
}
