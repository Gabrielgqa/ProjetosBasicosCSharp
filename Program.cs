Menu();

static void Menu() {
    Console.Clear();
    Console.WriteLine("Bem vindo à calculadora C#!");
    Console.WriteLine("---------------------------");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");
    Console.WriteLine("5 - Sair");
    Console.WriteLine("---------------------------");
    Console.WriteLine("Selecione uma operação:");
    short opcao = Convert.ToInt16(Console.ReadLine());

    switch (opcao)
    {
        case 1: {
            Soma();
            break;
        }
        case 2: {
            Subtracao();
            break;
        }
        case 3: {
            Divisao();
            break;
        }
        case 4: {
            Multiplicacao();
            break;
        }
        case 5: {
            System.Environment.Exit(0);
            break;
        }
        default: {
            Menu();
            break;
        }
    }
}

static void Soma() {
    Console.Clear();
    Console.WriteLine("Primeiro valor: ");
    float primeiroValor = Convert.ToSingle(Console.ReadLine());
    Console.WriteLine("Segundo valor: ");
    float segundoValor = Convert.ToSingle(Console.ReadLine());

    float resultado = primeiroValor + segundoValor;
    Console.WriteLine($"O resultado da soma é: {resultado}");
    Console.ReadKey();
    Menu();
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
    Menu();
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
    Menu();
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
    Menu();
}