using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trabalhoo.Models;
using Trabalhoo.Services;
using System.Collections.Generic;

namespace TrabalhooTest
{
    [TestClass]
    public class Testes
    {
       private PrincipalServices prinService = new PrincipalServices();

        private List<Princi> contas = new List<Princi>() {
            new Princi()  {                              // Receber, Valor = 10, Não Quitada
                Descricao = "",
                Efetuada = false,
                Id = 1,
                Lancamento = DateTime.Now,
                Tipo = Trabalhoo.TipoDaConta.Receber,
                Valor = 10.0F,
                Vencimento = DateTime.Now.AddDays(10)
            },
            new Princi()  {                             // Pagar, Valor = 5, Não Quitada
                Descricao = "",
                Efetuada = false,
                Id = 2,
                Lancamento = DateTime.Now,
                Tipo = Trabalhoo.TipoDaConta.Pagar,
                Valor = 5.0F,
                Vencimento = DateTime.Now.AddDays(10)
            },
            new Princi()  {                             // Receber, Valor = 20, Quitada
                Descricao = "",
                Efetuada = true,
                Id = 3,
                Lancamento = DateTime.Now,
                Tipo = Trabalhoo.TipoDaConta.Receber,
                Valor = 20.0F,
                Vencimento = DateTime.Now.AddDays(10)
            },
            new Princi()  {                             // Pagar, Valor = 10, Não Quitada
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
        public void ResultadoQTDContaPagar()           // Retorna quantidade de contas a Pagar
        {
            var result = this.prinService.QTDContaPagar(contas);
            Assert.AreEqual(2, result);
        }

        [TestMethod] 
        public void ResultadoQTDContaReceber()           // Retorna quantidade de contas a Receber
        {
            var result = this.prinService.QTDContaReceber(contas);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ResultadoValorTotalReceberERecebido()  // Retorna Valor total de contas a receber
        {                                                  // As recebidas e não recebidas
            var result = this.prinService.ValorTotalReceberERecebido(contas);
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void ResultadoTotalContasReceber()  // Retorna Valor total de contas a receber
        {                                          
            var result = this.prinService.TotalContasReceber(contas);
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void ResultadoTotalContasPagar()  // Retorna Valor total de contas a Pagar
        {
            var result = this.prinService.TotalContasPagar(contas);
            Assert.AreEqual(15, result);
        }

    }
}
