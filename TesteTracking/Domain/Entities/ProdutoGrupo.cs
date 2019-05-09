using System;

namespace TesteTracking.Domain.Entities
{
    public class ProdutoGrupo
    {
        public ProdutoGrupo(Guid id, string nomeGrupo)
        {
            Id = id;
            NomeGrupo = nomeGrupo;
        }

        public Guid Id { get; private set; }
        public string NomeGrupo { get; private set; }
    }
}
