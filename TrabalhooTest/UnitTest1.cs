using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trabalhoo.Models;
using Trabalhoo.Services;
using System.Collections.Generic;

namespace TrabalhooTest
{
    [TestClass]
    public class UnitTest1
    {
       private PrincipalServices prinService = new PrincipalServices();

        private List<Princi> contas = new List<Princi>() {
            new Princi()  {
                Descricao = "",
                Efetuada = false,
                Id = 1,
                Lancamento = DateTime.Now,
                Tipo = Trabalhoo.TipoDaConta.Receber,
                Valor = 10.0F,
                Vencimento = DateTime.Now.AddDays(10)
            },
            new Princi()  {
                Descricao = "",
                Efetuada = false,
                Id = 2,
                Lancamento = DateTime.Now,
                Tipo = Trabalhoo.TipoDaConta.Pagar,
                Valor = 5.0F,
                Vencimento = DateTime.Now.AddDays(10)
            },
            new Princi()  {
                Descricao = "",
                Efetuada = false,
                Id = 3,
                Lancamento = DateTime.Now,
                Tipo = Trabalhoo.TipoDaConta.Receber,
                Valor = 20.0F,
                Vencimento = DateTime.Now.AddDays(10)
            },
            new Princi()  {
                Descricao = "",
                Efetuada = false,
                Id = 4,
                Lancamento = DateTime.Now,
                Tipo = Trabalhoo.TipoDaConta.Pagar,
                Valor = 10.0F,
                Vencimento = DateTime.Now.AddDays(10)
            }
        };

        [TestMethod]
        public void Saldo_DeveRetornarOValorCorreto()
        {
            var result = this.prinService.Saldo(contas);
            Assert.AreEqual(15.0D, result);
        }
    }
}
