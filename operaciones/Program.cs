using System;

    int a = 10; 
    
    int b = 3;

    Console.WriteLine (a * b);

    int c = 100;

    int d = 7;

    Console.WriteLine (c % d);

    double e = 23;

    double f = e * 9.0 / 5.0 +32;

    Console.WriteLine(f);

    string g = "25";

    int h = int.Parse(g);

    Console.WriteLine(g);

    string i = "12$,3";

    string j = i.Replace("$", "");

    if (double.TryParse(j, out double resultado))

    {
    Console.WriteLine($"Es valido: {resultado}");
    }

    int k = 1000;

    double l = 1.21;

    Console.WriteLine (k * l);

    /*División Entera (int / int)
    Ocurre cuando divides dos números de tipo entero. C# asume que, si los ingredientes son enteros, el resultado debe ser un entero.
    Los decimales se eliminan por completo. No se redondea al más cercano, simplemente se "trunca" (se corta la parte decimal).
    Ejemplo: 7 / 2
    Matemáticamente es 3.5.
    En C# es 3.
    
    División Real (double / double o mixta)
    Ocurre cuando al menos uno de los números involucrados es un double (o tiene un punto decimal como 2.0).

    ¿Qué pasa con los decimales? Se conservan con una precisión de hasta 15-17 dígitos.

    Ejemplo: 7.0 / 2.0

    En C# es 3.5.*/

    int contador  = 30; 

    int puntos = 0;

    puntos += contador;

    Console.WriteLine(puntos);

    double valor = 8.12;

    int haciaAbajo = (int)Math.Floor(valor);
    int haciaArriba = (int)Math.Ceiling(valor);
    
    Console.WriteLine($"Hacia abajo: {haciaAbajo}");
    Console.WriteLine($"Hacia arriba: {haciaArriba}");

    TimeSpan t = TimeSpan.FromHours(1000);

    Console.WriteLine($"{t.Days} días y {t.Hours} horas.");

                                        /*GRACIAS POR VER*/