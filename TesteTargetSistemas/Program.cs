int primeiroNumero = 0, segundoNumero = 1, numeroAtual = 0;

Console.Write("Informe um número para saber se faz parte da sequência Fibonacci: ");
string entrada = Console.ReadLine()!;

if (int.TryParse(entrada, out int entradaConvertida))
{
    if (entradaConvertida == 0 || entradaConvertida == 1)
    {
        Console.WriteLine($"\nO Número {entrada} pertence a sequência de Fibonacci");
    }

    if (entradaConvertida > 1)
    {
        for (int i = 0; i <= entradaConvertida; i++)
        {
            i = primeiroNumero + segundoNumero;
            primeiroNumero = segundoNumero;
            segundoNumero = i;
            numeroAtual = i;

            if (i == entradaConvertida)
            {
                Console.WriteLine($"\nO Número {entrada} pertence a sequência de Fibonacci");
            }
        }

        if (numeroAtual != entradaConvertida)
        {
            Console.WriteLine($"\nO Número {entrada} não pertence a sequência de Fibonacci");
        }
    }
}

else
{
    Console.WriteLine("\nValor inválido");
}
