using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteTracking.Domain.Commmands;
using TesteTracking.Service;

namespace TesteTracking.App
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecutandoSemErro();
            ExecutandoComErro();
        }

        static void ExecutandoSemErro()
        {
            var contexto = new ContextTeste();
            var uow = new UnityOfWork(contexto);
            var repo = new ProdutoGrupoRepository(contexto);
            var service = new ProdutoGrupoService(repo, uow);

            var id = Guid.NewGuid();

            service.Inserir(new ProdutoGrupoCommand(id, "TESTE"));
            contexto.Dispose();
            contexto = new ContextTeste();
            uow = new UnityOfWork(contexto);
            repo = new ProdutoGrupoRepository(contexto);
            service = new ProdutoGrupoService(repo, uow);

            service.Atualizar(new ProdutoGrupoCommand(id, "TESTE DE ALTERACAO"));

            contexto.Dispose();
            contexto = new ContextTeste();
            uow = new UnityOfWork(contexto);
            repo = new ProdutoGrupoRepository(contexto);
            service = new ProdutoGrupoService(repo, uow);

            service.Atualizar(new ProdutoGrupoCommand(id, "TESTE DE ALTERACAO 2"));

            contexto.Dispose();
            contexto = new ContextTeste();
            uow = new UnityOfWork(contexto);
            repo = new ProdutoGrupoRepository(contexto);
            service = new ProdutoGrupoService(repo, uow);

            var grupo = service.ObterGrupoPorId(id);
            if (grupo != null)
                Console.WriteLine("NOME ATUAL DO GRUPO: " + grupo.NomeGrupo);

            Console.Write("Aperte enter para continuar:");

            Console.ReadLine();
        }

        static void ExecutandoComErro()
        {
            var contexto = new ContextTeste();
            var uow = new UnityOfWork(contexto);
            var repo = new ProdutoGrupoRepository(contexto);
            var service = new ProdutoGrupoService(repo, uow);

            var id = Guid.NewGuid();

            service.Inserir(new ProdutoGrupoCommand(id, "TESTE"));

            service.Atualizar(new ProdutoGrupoCommand(id, "TESTE DE ALTERACAO"));

            service.Atualizar(new ProdutoGrupoCommand(id, "TESTE DE ALTERACAO 2"));

            var grupo = service.ObterGrupoPorId(id);
            if (grupo != null)
                Console.WriteLine("NOME ATUAL DO GRUPO: " + grupo.NomeGrupo);

            Console.Write("Aperte enter para continuar:");

            Console.ReadLine();
        }
    }
}
