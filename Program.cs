Console.WriteLine("--- Fluxograma Da Engenharia ---\n");

Console.Write("O objeto está se movendo (S/N)? ");
bool estaSeMovendo = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper() == "S";

Console.Write("Deveria se mover (S/N)? ");
bool deveria = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper() == "S";

string mensagem;

if (!estaSeMovendo)
{
    if (!deveria)
    {
        mensagem = "Excelente!";
    }
    else
    {
        mensagem = "Aplique WD-40.";
    }
}
else
{
    if (deveria)
    {
        mensagem = "Excelente!";
    }
    else
    {
        mensagem = "Aplique Silver Tape.";
    }
}

Console.WriteLine();
Console.WriteLine(mensagem);