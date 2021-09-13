using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using ExemploFinanceiro;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ExemploFinancas1.Testes
{
    [Binding]
    public sealed class CalcFinanceiroSteps
    {

        private double _valorEmprestimo;
        private double _taxa;
        private int _meses;
        private double _valorFinalPeriodo;




        [Given("que o valor do empréstimo foi R\\$ (.*)")]
        public void CarregarValorEmprestímo(double valorEmprestsimo)
        {

            this._valorEmprestimo = valorEmprestsimo;
        }


        [Given("foi definido uma taxa de (.*)% mensais ")]
        public void CarregarTaxa(double taxa)
        {

            this._taxa = taxa;
        }

        [Given("em período de (.*)% meses ")]
        public void CarregarNumMeses(int meses)
        {

            this._meses = meses;
        }





       

        [When("eu solicictar o valor ao final do período")]
        public void ProcessarCalculo()
        {
            this._valorFinalPeriodo =
                  CalculoFinanceiro.CalcularValorComJurosCompostos(
                      this._valorEmprestimo,
                      this._meses,
                      this._valorFinalPeriodo
                      );
        }

        [Then("o valor total a ser pago será (.*)")]
        public void VerificarResultado(int valorFinalPeriodo)
        {
            Assert.AreEqual(valorFinalPeriodo, this._valorFinalPeriodo);
        }
    }
}
