using Dapper;
using Trabalhoo.Models;
using System.Collections.Generic;
using System.Linq;

namespace Trabalhoo.Repositories
{
    class PrincipalRepository : Repository<Princi>
    {
        
        public List <Princi> RetornaCampos()
        {
            string query = " SELECT id, valor, tipo AS Tipo, " +
                           " descricao, vencimento, lancamento, efetuada " +
                           " FROM contas ";

            return _conn.Query<Princi>(query).ToList();
        }

        public List<Princi> RetornaReceber()
        {
            string query = " SELECT id, valor, tipo AS Tipo, " +
                           "        descricao, vencimento, lancamento, efetuada " +
                           "        FROM contas " +
                           "        WHERE tipo = 0 ";

            return _conn.Query<Princi>(query).ToList();
        }

        public List<Princi> RetornaPagar()
        {
            string query = " SELECT id, valor, tipo AS Tipo, " +
                           "        descricao, vencimento, lancamento, efetuada " +
                           "        FROM contas " +
                           "        WHERE tipo = 1 ";

            return _conn.Query<Princi>(query).ToList();
        }
    }
}
