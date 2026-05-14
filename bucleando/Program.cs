for (int i = 0; i <= 20; i++)

    Console.Write(i + "\n");

   Console.WriteLine("\n");


for (int a = 0; a <= 20; a += 2)

    Console.Write(a + "\n");

    Console.WriteLine("\n");


    int suma = 0;
    for (int b = 0; b <= 100; b ++)
{
    suma += b;
}

    Console.WriteLine("Total: " + suma);

    Console.WriteLine("\n");


    int contador =10;
    while (contador >= 0)
    {
        Console.WriteLine(contador);
        contador--;
    }

    Console.WriteLine("\n");


   int opcion;

do
{
    Console.Write("Ingrese un número positivo mayor a 0: ");
    
    opcion = int.TryParse(Console.ReadLine(), out opcion) ? opcion : 0;

} while (opcion <= 0);

Console.WriteLine("¡Gracias! Ingresaste el número: " + opcion);

Console.WriteLine("\n");

for (int i = 0; i <= 50; i+=5)

    Console.Write(i + "\n");

    Console.WriteLine("\n");

    string[] letra = { "J", "M", "P", "A", "L" };
    foreach (string l in letra)
    {
        Console.WriteLine(l);
    }

    Console.WriteLine("\n");

for (int z = 0; z <= 20; z++)
{
    if (z == 13) break;
    if (z % 2 == 0) continue;
    Console.WriteLine(z);
}

Console.WriteLine("\n");

for (int x = 0; x <= 20; x++)
{
    if (x % 3 == 0) continue;
    Console.WriteLine(x);
}

Console.WriteLine("\n");

for (int fila = 1; fila <= 5; fila++)
{
    for (int columna = 1; columna <= 5; columna++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}