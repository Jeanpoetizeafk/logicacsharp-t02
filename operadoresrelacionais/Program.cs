using System.Numerics;

int a = 10;
int b = 5;

//Operadores Relacionais
bool maiorque = a > b;
bool menorque = a < b;
bool igual = a == b;
bool diferente = a != b;
bool maiorouigual = a >= b;
bool menorouigual = a <= b;

// exibindo resultado dos operadores relacionais 
Console.WriteLine("\noperadores Relacionais:");
Console.WriteLine($"{a} > {b}: {maiorque}");
Console.WriteLine($"{a} == {b}: {igual}");
Console.WriteLine($"{a} != {b}: {diferente}");
Console.WriteLine($"{a} >= {b}: {maiorouigual}");
Console.WriteLine($"{a} <= {b}: {menorouigual}");