double numerador, denominador, resultado;

Console.WriteLine("Digite o numerador..:");
numerador = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o denominador..:");
denominador = Convert.ToDouble(Console.ReadLine());

if (denominador == 0) 
    Console.WriteLine("Não é possível dividir por zero.");
else
{
    resultado = numerador / denominador;
Console.WriteLine($"{numerador} dividido por {denominador} é ={resultado}");
}
