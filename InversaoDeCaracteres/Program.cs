string frase;
do
{
    Console.Write("Digite uma frase ou palavra para recebe-lá invertida:");
    frase = Console.ReadLine()!;
    List<char> fraseSeparada = frase.ToCharArray().ToList();
    List<char> fraseSeparadaCopia = new List<char>();
    int contador = fraseSeparada.Count - 1;

    for (int i = 0; i < fraseSeparada.Count; i++)
    {
        fraseSeparadaCopia.Add(fraseSeparada[contador]);
        contador--;
    }

    foreach (char c in fraseSeparadaCopia)
    {
        Console.Write(c);
    }

    if(frase == string.Empty)
    {
        Console.WriteLine("Precisa informar uma frase ou palavra para ser invertida");
    }
}
while (frase == string.Empty);
   