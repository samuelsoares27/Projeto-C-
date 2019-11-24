using Dapper;
using NubancoApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace NubancoApp.Repositories
{
    class PrincipalRepository : Repository<Princi>
    {
        
        public List <Princi> RetornaCampos()
        {
            string query = " SELECT id, valor, if(tipo = 0, 'Receber', 'Pagar') AS Pagamento, " +
                           " descricao, vencimento, lancamento, efetuada " +
                           " FROM contas ";

            return _conn.Query<Princi>(query).ToList();
        }
    
    }
}
