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

        public double Saldo(List<Princi> principal)
        {
            var pagar = 0.0D;
            var receber = 0.0D;
            foreach (var item in principal)
            {
                if (item.Tipo == Trabalhoo.TipoDaConta.Pagar)
                {
                    pagar += item.Valor;
                }
                else
                {
                    receber += item.Valor;
                }
            }

            return receber - pagar;
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

        public double ValorMedioContasPagar(List<Princi> contas)
        {
            var saldo = 0.0D;
            foreach (var item in contas.Where(f => !f.Efetuada))
            {
                if (item.Tipo == Trabalhoo.TipoDaConta.Pagar)
                {
                    saldo += item.Valor;
                }
            }

            if (contas.Where(f => !f.Efetuada).Where(f => f.Tipo == Trabalhoo.TipoDaConta.Pagar).Count() == 0) return 0.0D;

            return saldo / contas.Where(f => !f.Efetuada).Where(f => f.Tipo == Trabalhoo.TipoDaConta.Pagar).Count();
        }

        public double ValorMedioContasReceber(List<Princi> contas)
        {
            var saldo = 0.0D;
            foreach (var item in contas.Where(f => !f.Efetuada))
            {
                if (item.Tipo == Trabalhoo.TipoDaConta.Receber)
                {
                    saldo += item.Valor;
                }
            }

            if (contas.Where(f => !f.Efetuada).Where(f => f.Tipo == Trabalhoo.TipoDaConta.Receber).Count() == 0) return 0.0D;

            return saldo / contas.Where(f => !f.Efetuada).Where(f => f.Tipo == Trabalhoo.TipoDaConta.Receber).Count();
        }
    }
}





