using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTracking
{
    public class UnityOfWork
    {
        private ContextTeste _context;
        public UnityOfWork(ContextTeste context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            //Não precisa.
        }
    }
}
