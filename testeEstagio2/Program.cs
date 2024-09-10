using System.Text.Json;

class Program
{
    public static void Main(string[] args)
    {

        // Questão 1
        Console.WriteLine();
        Console.WriteLine("Questão 1:");
        Console.Write("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (PertenceAFibonacci(numero))
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
        }

        // Questão 2
        Console.WriteLine();
        Console.WriteLine("Questão 2:");
        Console.Write("Informe uma string: ");
        string input = Console.ReadLine();

        int contador = 0;

        foreach (char c in input)
        {
            if (c == 'a' || c == 'A')
            {
                contador++;
            }
        }

        if (contador > 0)
        {
            Console.WriteLine($"A letra 'a' (maiúscula ou minúscula) aparece {contador} vezes.");
        }
        else
        {
            Console.WriteLine("A letra 'a' (maiúscula ou minúscula) não foi encontrada.");
        }

        // Questão 3
        Console.WriteLine("Questão 3:\nValor da variável soma: " + Soma());
    }

    // Questão 1
    public static bool PertenceAFibonacci(int numero)
    {
        int a = 0;
        int b = 1;

        if (numero == a || numero == b)
        {
            return true;
        }

        int c = a + b;

        while (c <= numero)
        {
            if (c == numero)
            {
                return true;
            }

            a = b;
            b = c;
            c = a + b;
        }

        return false;
    }

    // Questão 3
    public static int Soma()
    {
        int indice = 13;
        int soma = 0;
        int k = 0;

        while (k < indice)
        {
            k++;

            soma += k;
        }

        return soma;
    }    
}