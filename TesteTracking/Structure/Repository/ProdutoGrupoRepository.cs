using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteTracking.Domain.Commmands;
using TesteTracking.Domain.Entities;

namespace TesteTracking
{
    public class ProdutoGrupoRepository
    {
        private ContextTeste _context;
        public ProdutoGrupoRepository(ContextTeste context)
        {
            _context = context; 
        }

        public ProdutoGrupoCommand BuscarPorId(Guid id)
        {
            return _context.Grupos.Where(g => g.Id == id).Select(g=> new ProdutoGrupoCommand(g.Id, g.NomeGrupo)).FirstOrDefault();
        }

        public void Inserir(ProdutoGrupo grupo)
        {
            _context.Grupos.Add(grupo);
        }

        public void Atualizar(ProdutoGrupo grupo)
        {
            _context.Entry<ProdutoGrupo>(grupo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
