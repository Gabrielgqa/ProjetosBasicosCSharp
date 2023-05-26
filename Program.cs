Console.Clear();
Console.WriteLine("Primeiro valor: ");
float primeiroValor = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Segundo valor: ");
float segundoValor = Convert.ToSingle(Console.ReadLine());

float result = primeiroValor + segundoValor;
Console.WriteLine("O resultado da soma é: "+ result);
Console.WriteLine($"O resultado da soma é: {primeiroValor + segundoValor}");
Console.WriteLine($"O resultado da soma é: {result}");