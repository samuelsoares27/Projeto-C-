using NubancoApp.Repositories;
using System.Collections.Generic;
using System.Linq;
using NubancoApp.Models;

namespace NubancoApp.Services
{
    class PrincipalServices : Service<Princi>
    {
        private PrincipalRepository _repository { get; set; }

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
                if (item.Tipo == trabalho.TipoDaConta.Pagar)
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
                if (item.Tipo == trabalho.TipoDaConta.Pagar)
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
                if (item.Tipo == trabalho.TipoDaConta.Receber)
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
                if (item.Tipo == trabalho.TipoDaConta.Pagar)
                {
                    saldo += item.Valor;
                }
            }

            if (contas.Where(f => !f.Efetuada).Where(f => f.Tipo == trabalho.TipoDaConta.Pagar).Count() == 0) return 0.0D;

            return saldo / contas.Where(f => !f.Efetuada).Where(f => f.Tipo == trabalho.TipoDaConta.Pagar).Count();
        }

        public double ValorMedioContasReceber(List<Princi> contas)
        {
            var saldo = 0.0D;
            foreach (var item in contas.Where(f => !f.Efetuada))
            {
                if (item.Tipo == trabalho.TipoDaConta.Receber)
                {
                    saldo += item.Valor;
                }
            }

            if (contas.Where(f => !f.Efetuada).Where(f => f.Tipo == trabalho.TipoDaConta.Receber).Count() == 0) return 0.0D;

            return saldo / contas.Where(f => !f.Efetuada).Where(f => f.Tipo == trabalho.TipoDaConta.Receber).Count();
        }
    }
}





