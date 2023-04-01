using Calculator;

bool endApp = false;

while (!endApp)
{
    Console.Clear();
    Console.WriteLine("Calculadora de Console em C#\r");
    Console.WriteLine("----------------------------\n");
    string numInput1 = "";
    string numInput2 = "";
    double result = 0;

    Console.WriteLine("Digite um número. e pressione ENTER");
    numInput1 = Console.ReadLine();

    double cleanNum1 = 0;
    while (!double.TryParse(numInput1, out cleanNum1))
    {
        Console.Write("Entrada invalida! Por favor digite um valor numérico: ");
        numInput1 = Console.ReadLine();
    }

    Console.WriteLine("Digite outro número. e pressione ENTER");
    numInput2 = Console.ReadLine();

    double cleanNum2 = 0;
    while (!double.TryParse(numInput2, out cleanNum2))
    {
        Console.Write("Entrada invalida! Por favor digite um valor numérico: ");
        numInput2 = Console.ReadLine();
    }

    Console.WriteLine(
        @"Escolha uma das opções da lista abaixo: 
            a - Adição
            s - Subtração
            m - Multiplicação
            d - Divisão"
    );
    Console.Write("Digite uma opção: ");
    string op = Console.ReadLine();

    try
    {
        result = Calculator.Calculator.DoOperation(cleanNum1, cleanNum2, op);
        if (double.IsNaN(result))
        {
            Console.WriteLine("Esta operação resultará em um erro matemático.\n");
        }
        else
        {
            Console.WriteLine("Seu resultado: {0:0.##}\n", result);
        }

    }
    catch (Exception e)
    {
        Console.WriteLine("Ah não! Ocorreu uma exceção ao tentar fazer as contas.\n - Detalhes: " + e.Message);
    }

    Console.WriteLine("Pressione qualquer tecla para fechar a Calculadora...");
    Console.ReadKey();
}
return;
