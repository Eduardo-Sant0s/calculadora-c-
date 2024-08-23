double num1;
double num2;

Console.WriteLine("informe o primeiro número:");
num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("informe o segundo número:");
num2 = Convert.ToDouble(Console.ReadLine());

double soma = num1 + num2;
Console.WriteLine("a soma de " + num1  + " + " + num2  + " é "+ soma);

double subtração = num1 - num2;
Console.WriteLine($"a subtração de {num1} - {num2} é {subtração}");

double multiplicação = num1 * num2;
Console.WriteLine("a multiplicação de {0} x {1} é {2}", num1, num2, multiplicação);

double divisão = num1 / num2;
Console.WriteLine($"a divisão de {num1} ÷ {num2} é {divisão}"); 




