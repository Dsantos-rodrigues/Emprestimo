using System;

class MainClass {
  public static void Main (string[] args) {
    double salariotrabalhador,valorprestacao;
    double percentualsalario;
    const double percentual = 0.2; //20% do salário
    string strsalario, strprestacao;
    //Entrada de Dados
    Console.WriteLine ("Informe o salário do trabalhador:");
    strsalario = Console.ReadLine();
    Console.WriteLine ("Informe o valor da prestação:");
    strprestacao = Console.ReadLine();
    //Conversão dos Valores 
    salariotrabalhador = Convert.ToDouble(strsalario);
    valorprestacao = Convert.ToDouble(strprestacao);
    //Calcular o percentual de 20% do salário
    percentualsalario = salariotrabalhador * percentual;
    if(valorprestacao > percentualsalario){
      Console.WriteLine("Empréstimo não concedido.");
      Console.WriteLine("O valor da prestação ultrapassa 20% do salário.");
      Console.WriteLine("Valor da Prestação:{0}.",valorprestacao);
      Console.WriteLine("Valor máximo do empréstimo:{0}.",percentualsalario);
    }
    else{
      Console.WriteLine("Empréstimo concedido.");
    }
  }
}
