using System;

namespace TesteTracking.Domain.Commmands
{
    public class ProdutoGrupoCommand
    {
        public ProdutoGrupoCommand(Guid id, string nomeGrupo)
        {
            Id = id;
            NomeGrupo = nomeGrupo;
        }

        public Guid Id { get; set; }
        public string NomeGrupo { get; set; }
    }
}
