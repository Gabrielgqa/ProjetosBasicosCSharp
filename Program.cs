Soma();
Subtracao();
Divisao();
Multiplicacao();

static void Soma() {
    Console.Clear();
    Console.WriteLine("Primeiro valor: ");
    float primeiroValor = Convert.ToSingle(Console.ReadLine());
    Console.WriteLine("Segundo valor: ");
    float segundoValor = Convert.ToSingle(Console.ReadLine());

    float resultado = primeiroValor + segundoValor;
    Console.WriteLine($"O resultado da soma é: {resultado}");
    Console.ReadKey();
}

static void Subtracao() {
    Console.Clear();
    Console.WriteLine("Primeiro valor: ");
    float primeiroValor = Convert.ToSingle(Console.ReadLine());
    Console.WriteLine("Segundo valor: ");
    float segundoValor = Convert.ToSingle(Console.ReadLine());

    float resultado = primeiroValor - segundoValor;
    Console.WriteLine($"O resultado da subtração é: {resultado}");
    Console.ReadKey();
}

static void Divisao() {
    Console.Clear();
    Console.WriteLine("Primeiro valor: ");
    float primeiroValor = Convert.ToSingle(Console.ReadLine());
    Console.WriteLine("Segundo valor: ");
    float segundoValor = Convert.ToSingle(Console.ReadLine());

    float resultado = primeiroValor / segundoValor;
    Console.WriteLine($"O resultado da divisão é: {resultado}");
    Console.ReadKey();
}

static void Multiplicacao() {
    Console.Clear();
    Console.WriteLine("Primeiro valor: ");
    float primeiroValor = Convert.ToSingle(Console.ReadLine());
    Console.WriteLine("Segundo valor: ");
    float segundoValor = Convert.ToSingle(Console.ReadLine());

    float resultado = primeiroValor * segundoValor;
    Console.WriteLine($"O resultado da multiplicação é: {resultado}");
    Console.ReadKey();
}