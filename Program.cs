// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("BIENVENIDO");
Console.WriteLine("¿Que desea hacer hoy?");
Console.WriteLine("1. Encontrar número mayor y menor");
Console.WriteLine("2. Validar palindromo");
var option = Console.ReadLine();
var wait = true;

do
{
    if (option != null && int.Parse(option) == 1)
    {
        Console.WriteLine("Ingresar los numeros del arreglo");
        var input = Console.ReadLine();
        try
        {
            var numbers = input.Trim().Split(" ").ToList().ConvertAll(int.Parse);
            findMin(numbers);
            findMax(numbers);

            Console.WriteLine("¿Desea realizar otro cálculo? (s/n):");
        }
        catch (Exception)
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese solo números separados por espacio.");
        }
    }
    else if (option != null && int.Parse(option) == 2)
    {
        Console.WriteLine("Ingresar la palabra");
        var input = Console.ReadLine().Trim();
        validatePalindrome(input);
        Console.WriteLine("¿Desea validar otra palabra? (s/n):");
    }
    string response = Console.ReadLine().Trim().ToLower();
    wait = response == "s";

} while (wait);

void validatePalindrome(string input)
{
    input = Regex.Replace(input, @"\s+", "");
    string reverse = string.Empty;
    for (int i = input.Length - 1; i >= 0; i--)
    {
        reverse += input[i];
    }
    if (input == reverse)
    {
        Console.WriteLine("La palabra es palindroma!");
    }
    else
    {
        Console.WriteLine("La palabra NO es palindroma!");
    }
}

void findMax(List<int> numbers)
{
    int max = numbers[0];
    if (numbers.Count > 0)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > max) max = numbers[i];
        }
        Console.WriteLine($"El número mayor es -> {max}");
    }
}

void findMin(List<int> numbers)
{
    int min = numbers[0];
    if (numbers.Count > 0)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] < min) min = numbers[i];
        }
        Console.WriteLine($"El número menor es -> {min}");
    }
}

