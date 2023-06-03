Console.WriteLine(@$"--- Simulador de Luz de Advertência ---

Escreva apenas [A], para ativado, ou [D] para desativado");

Console.WriteLine();

string A = "A";
string D = "D";

Console.Write("Sensor de temperatura...: ");
string temperatura = Console.ReadLine ()!.ToUpper();

if (temperatura == D)
{
    Console.WriteLine();

    Console.WriteLine("A luz de advertência está desativada");
}

else
{
    Console.Write("Sensor de pressão.......: ");
    string pressao = Console.ReadLine ()!.ToUpper();

    Console.Write($"Sensor de rotação.......: ");
    string rotacao = Console.ReadLine()!.ToUpper();

if (pressao == A || rotacao == D)
{
    Console.WriteLine();

    Console.WriteLine("A luz de advertência está ativada");
}

else
{
    Console.WriteLine();

    Console.WriteLine("A luz de advertência está desativada");
}
}