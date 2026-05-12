int a = 2;

if (a % 2 == 0)
{
    Console.WriteLine("es par.");
}
else
{
    Console.WriteLine("es ímpar.");
}

double b = 3.5;

if (b > 0)
{
    Console.WriteLine("Es positivo.");
}

else if (b < 0)
{
    Console.WriteLine("Es negativo.");
}
else
{
    Console.WriteLine("Es cero.");
}

int c = 76;

bool esMayorDeEdad = c >= 18;

if (esMayorDeEdad)
{
    Console.WriteLine("Es mayor de edad.");
}
else
{
    Console.WriteLine("No es mayor de edad.");
}

int d = 42;

if (d >= 1 && d <= 100)
{
    Console.WriteLine("El número está en el rango de 1 a 100.");
}
else
{
    Console.WriteLine("El número está fuera del rango.");
}

string e = "Sábado";

 if (e == "Sábado" || e == "Domingo")
{
    Console.WriteLine("Es un día de fin de semana.");
}
else
{
    Console.WriteLine("No es un día válido.");
}

int f = 27;
string categoria = (f >= 18) ? "Es mayor" : "Es menor";

Console.WriteLine(categoria);

int gDia = 3;
string gNombreDia = gDia switch
{
    1 => "Lunes",
    2 => "Martes",
    3 => "Miércoles",
    4 => "Jueves",
    5 => "Viernes",
    6 => "Sábado",
    7 => "Domingo",
    _ => "Número de día no válido"
};

Console.WriteLine(gNombreDia);

string producto = "leche";

string categoria2 = producto switch
{
    "leche"    => "lácteos",
    "lentejas" => "legumbre",
    "manzana"  => "fruta",
    _          => "categoría desconocida" // El "else" del switch
};

Console.WriteLine($"El producto {producto} pertenece a: {categoria2}");

bool esMayorDeEdad2 = true;
bool tieneLicencia = false;
bool puedeConducir = esMayorDeEdad2 && tieneLicencia;
Console.WriteLine($"Puede conducir: {puedeConducir}");