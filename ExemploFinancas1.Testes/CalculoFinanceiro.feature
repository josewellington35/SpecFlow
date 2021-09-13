Feature: CalculoFinanceiro
	
@mytag
Scenario: SimulacaoCalculo01
    Given que o valor do empréstimo foi R$ 10000,00
	And foi definido uma taxa de 2% mensais
	And em um periodo de 12 meses
	When eu solicitar o valor ao final do período
	Then o  valor total a ser pago será R$ 12682,42
Scenario: SimulacaoCalculo02
    Given que o valor do empréstimo foi R$ 11937,28
	And foi definido uma taxa de 2% mensais
	And em um periodo de 12 meses
	When eu solicitar o valor ao final do período
	Then o  valor total a ser pago será R$ 30598,88
Scenario: SimulacaoCalculo03
    Given que o valor do empréstimo foi R$ 15000,00
	And foi definido uma taxa de 2% mensais
	And em um periodo de 12 meses
	When eu solicitar o valor ao final do período
	Then o  valor total a ser pago será R$ 122208,78
