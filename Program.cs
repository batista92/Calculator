int num1 = 0; int num2 = 0;

Console.WriteLine("Calculadora de Console em C#\r");
Console.WriteLine("----------------------------\n");

Console.WriteLine("Digite um número. e pressione ENTER");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite outro número, e pressione ENTER");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(
    @"Escolha uma das opções da lista abaixo: 
    a - Adição
    s - Subtração
    m - Multiplicação
    d - Divisão"
);
Console.Write("Digite uma opção: ");

switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Seu Resultado: {num1} + {num2} = " + (num1 + num2));
        break;
    case "s":
        Console.WriteLine($"Seu Resultado: {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"Seu Resultado: {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        Console.WriteLine($"Seu Resultado: {num1} / {num2} = " + (num1 / num2));
        break;
}

Console.WriteLine("Pressione qualquer tecla para fechar a Calculadora...");
Console.ReadKey();
