

while (true == true)
{
    // Console.Clear();

    Console.WriteLine("-------------------------");
    Console.WriteLine("CALCULADORA 3.0");
    Console.WriteLine("-------------------------");

    Console.WriteLine("1 - SOMAR");
    Console.WriteLine("2 - SUBTRAÇÃO");
    Console.WriteLine("3 - MULTIPLICAÇÃO");
    Console.WriteLine("4 - DIVISÃO");
    Console.WriteLine("5 - TABUADA");
    Console.WriteLine("S - SAIR");

    Console.WriteLine("-------------------------");
    Console.WriteLine("Escolha uma Opção Valida ");

    Console.WriteLine("-------------------------");
    string opcao = Console.ReadLine();

    if (opcao == "S" || opcao == "s")
    {
        break;
    }

    if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5")
    {

        Console.WriteLine("-------------------------");
        Console.WriteLine("Escolha Uma opção VALIDA");
        Console.WriteLine("-------------------------");
        Console.Write("DIGITE ENTER PARA SAIR");
        Console.ReadLine();
        continue;
    }

    if (opcao == "5")
    {
        // Console.Clear();
        Console.WriteLine("-------------------------");
        Console.WriteLine("TABUADA 3.0");
        Console.WriteLine("-------------------------");
        Console.Write("Digite um número Inteiro: ");
        string strTabuada = Console.ReadLine();

        int tabuada = Convert.ToInt32(strTabuada);

        Console.WriteLine(tabuada);

        for (int i = 1; i <= 10; i = i + 1)
        {
            // string linhaTabuada = tabuada + " x " + i + " = " + tabuada * i;
            string linhaTabuada = $"{tabuada} x {i} = {tabuada * i}";
            Console.WriteLine(linhaTabuada);
        }

        Console.WriteLine("Aperte Enter Para Continuar! ");
        Console.ReadLine();
        continue;

    }

    Console.Write("Digite o primeiro Numero: ");
    string StrPrimeiroNumero = Console.ReadLine();

    int primeiroNumero = Convert.ToInt32(StrPrimeiroNumero);

    Console.Write("DIgite o Segundo Numero: ");
    string strSegundoNumero = Console.ReadLine();

    int segundoNumero = Convert.ToInt32(strSegundoNumero);

    int resultado;


    if (opcao == "1")
    {
        resultado = primeiroNumero + segundoNumero;

    }
    else if (opcao == "2")
    {
        resultado = primeiroNumero - segundoNumero;
    }
    else if (opcao == "3")
    {
        resultado = primeiroNumero * segundoNumero;
    }
    else
    {
        resultado = primeiroNumero / segundoNumero;
    }


    Console.Write("O resultado do primeiro e do segundo numero é: " + resultado);


    Console.ReadLine();
}


