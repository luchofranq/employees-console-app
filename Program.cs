string[,] empleados = new string[,]{
    {" Sueldo","Empleado 1(Pablo) ", "Empleado 2(Lucas)", "Empleado 3(Marco)", "Empleado 4(Ezequiel)" },
    {"Mes 1:","                 ", "                ", "                ","                   " },
    {"Mes 2:","                 ", "                ", "                ","                   "},
    {"Mes 3:","                 ", "                ", "                ","                   "},
     };

for (int i = 0; i <= empleados.GetLength(0); i++)
{

    Console.Write(" | " + empleados[0, i]);
}

Console.WriteLine("");
for (int i = 1; i < empleados.GetLength(0); i++)
{
    for (int j = 0; j < empleados.GetLength(1); j++)
    {
        Console.Write(" |  " + empleados[i, j]);
    }
    Console.WriteLine(" ");
}
Console.WriteLine("");
for (int i = 1; i < empleados.GetLength(0); i++)
{
    for (int j = 1; j < empleados.GetLength(1); j++)
    {
        Console.WriteLine("\nIngrese el valor para el mes {0}, empleado {1}: ", i, j);
        string input = "";
        input = Console.ReadLine();

        empleados[i, j] = input;
    }
    Console.WriteLine(" ");
}
for (int i = 0; i <= empleados.GetLength(0); i++)
{

    Console.Write(" | " + empleados[0, i]);
}

Console.WriteLine("");
for (int i = 1; i < empleados.GetLength(0); i++)
{
    for (int j = 0; j < empleados.GetLength(1); j++)
    {
        Console.Write(" |  " + empleados[i, j]);
    }
    Console.WriteLine(" ");
}
Console.Write("\n");
Console.WriteLine("----------------------------------------------------");
Console.WriteLine("----------------------------------------------------");
Console.WriteLine("----------------------------------------------------");
Console.WriteLine("INGRESO ACUMULADO ULTIMOS 3 MESES\n");







int suma = 0;
int[] arr = new int[6];
for (int j = 1; j < 5; j++)
{
    int suma1 = 0;
    
    for (int i = 1; i < 4; i++)
    {
        int.TryParse(empleados[i, j], out suma);
        suma1 += suma;


    }
    Console.WriteLine(empleados[0, j] + " = " + suma1);
    arr[j] = suma1;
}




Console.WriteLine("\n");
int max = 0;
string ganador = "";
for (int i = 0; i < arr.GetLength(0); i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
        ganador = empleados[0, i];
    }
}
Console.WriteLine("El empleado que mas cobró es : " + ganador + " (Sueldo acumulado: " + max + ")");


Console.ReadKey();
