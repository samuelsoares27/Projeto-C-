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
            string query = " SELECT a.valor, if(a.tipo = 0, 'Receber', 'Pagar') AS Pagamento,  a.descricao, a.vencimento, a.lancamento, a.efetuada  FROM contas a ";

            return _conn.Query<Princi>(query).ToList();
        }

    }
}
