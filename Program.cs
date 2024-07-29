using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número del 1 al 7 para seleccionar un día de la semana:");
        Console.Write("1. Lunes\n2. Martes\n3. Miércoles\n4. Jueves\n5. Viernes\n6. Sábado\n7. Domingo\n");
        Console.Write("Número: ");

        // Leer el número ingresado por el usuario
        int dia = Convert.ToInt32(Console.ReadLine());

        // Mostrar el nombre del día correspondiente
        string nombreDia;

        switch (dia)
        {
            case 1:
                nombreDia = "Lunes";
                break;
            case 2:
                nombreDia = "Martes";
                break;
            case 3:
                nombreDia = "Miércoles";
                break;
            case 4:
                nombreDia = "Jueves";
                break;
            case 5:
                nombreDia = "Viernes";
                break;
            case 6:
                nombreDia = "Sábado";
                break;
            case 7:
                nombreDia = "Domingo";
                break;
            default:
                nombreDia = "Número no válido. Por favor, ingrese un número entre 1 y 7.";
                break;
        }

        // Mostrar el resultado
        Console.WriteLine($"El día correspondiente es: {nombreDia}");

        // Esperar a que el usuario presione una tecla antes de cerrar
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }
}
