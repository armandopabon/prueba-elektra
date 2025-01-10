// See https://aka.ms/new-console-template for more information
using PruebaElektra.Implementations;
using PruebaElektra.Interfaces;

var arrayRandom = new int[]{ 1,3,5,12,34 };
IValidations _iValidations = new Validations();

//Encontrar Maximo
int max = _iValidations.CalculateMax(arrayRandom);
Console.WriteLine($"El número mayor en el array {string.Join(',', arrayRandom)} es: {max}");

//Encontrar Minimo
int min = _iValidations.CalculateMin(arrayRandom);
Console.WriteLine($"El número Menor en el array {string.Join(',', arrayRandom)} es: {min}");


string input = "ANA";

//Validar Palindromo
bool result = _iValidations.ValidatePalindrome(input);

Console.WriteLine($"La palabra {input} {(result ? "es": "no es")} palindroma!");
Console.ReadKey();


