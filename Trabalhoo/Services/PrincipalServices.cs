using Trabalhoo.Repositories;
using System.Collections.Generic;
using System.Linq;
using Trabalhoo.Models;

namespace Trabalhoo.Services
{
    public class PrincipalServices : Service<Princi>
    {
        private PrincipalRepository _repository { get; set; }

        public List<Princi> Retorna()
        {
            return _repository.RetornaCampos();
        }

        public List<Princi> RetornaRec()
        {
            return _repository.RetornaReceber();
        }

        public List<Princi> RetornaPag()
        {
            return _repository.RetornaPagar();
        }

        public PrincipalServices()
        {
            _repository = new PrincipalRepository();
            this.SetRepository(_repository);
        }

        public double ValorTotalReceberERecebido(List<Princi> principal)
        {
            var receber = 0.0D;
            foreach (var item in principal)
            {
                if (item.Tipo == Trabalhoo.TipoDaConta.Receber)
                {
                    receber += item.Valor;
                }
            }

            return receber;
        }

        public double TotalContasPagar(List<Princi> contas)
        {

            var saldo = 0.0D;
            foreach (var item in contas.Where(f => !f.Efetuada))
            {
                if (item.Tipo == Trabalhoo.TipoDaConta.Pagar)
                {
                    saldo += item.Valor;
                }
            }

            return saldo;
        }

        public double TotalContasReceber(List<Princi> contas)
        {
            var saldo = 0.0D;
            foreach (var item in contas.Where(f => !f.Efetuada))
            {
                if (item.Tipo == Trabalhoo.TipoDaConta.Receber)
                {
                    saldo += item.Valor;
                }
            }

            return saldo;
        }

        public double QTDContaReceber(List<Princi> contas)
        {
            var QTD = 0.0D;
            foreach (var item in contas.Where(f => !f.Efetuada))
            {
                if (item.Tipo == Trabalhoo.TipoDaConta.Receber)
                {
                    QTD++;
                }
            }
            return QTD;
        }

        public double QTDContaPagar(List<Princi> contas)
        {
            var QTD = 0.0D;
            foreach (var item in contas.Where(f => !f.Efetuada))
            {
                if (item.Tipo == Trabalhoo.TipoDaConta.Pagar)
                {
                    QTD++;
                }
            }
            return QTD;
        }
    }
}





