
//PROPIEDADES
using System;

class Program
{
    static void Main()
    {
        // USO DE LENGTH
        string miCadena = "¡Piensa, sueña, cree y atrévete!";

        int longitud = miCadena.Length;

        Console.WriteLine("La longitud de la cadena es: " + longitud);

        Console.WriteLine("El primer carácter es: " + miCadena[0]);
        Console.WriteLine("El último carácter es: " + miCadena[longitud - 1]);

        // USO DE CHAR
        string miOtraCadena = "Con autodisciplina casi todo es posible";

        char[] caracteres = miOtraCadena.ToCharArray();

        Console.WriteLine("Los caracteres en la cadena son:");
        foreach (char c in caracteres)
        {
            Console.WriteLine(c);
        }

        // USO DE IsNullOrEmpty
        string cadena1 = "";
        string? cadena2 = null;
        string cadena3 = "Si puedes soñarlo, puedes hacerlo";

        // Verificar si las cadenas son nulas o están vacías
        Console.WriteLine("¿La cadena1 es nula o vacía? " + string.IsNullOrEmpty(cadena1));
        Console.WriteLine("¿La cadena2 es nula o vacía? " + string.IsNullOrEmpty(cadena2));
        Console.WriteLine("¿La cadena3 es nula o vacía? " + string.IsNullOrEmpty(cadena3));

        // USO DE IsNullOrWhiteSpace
        string otraCadena1 = "";
        string? otraCadena2 = null;
        string otraCadena3 = "    ";

        // Verificar si las cadenas son nulas, vacías o contienen solo espacios en blanco
        Console.WriteLine("¿La cadena1 es nula, vacía o contiene solo espacios en blanco? " + string.IsNullOrWhiteSpace(otraCadena1));
        Console.WriteLine("¿La cadena2 es nula, vacía o contiene solo espacios en blanco? " + string.IsNullOrWhiteSpace(otraCadena2));
        Console.WriteLine("¿La cadena3 es nula, vacía o contiene solo espacios en blanco? " + string.IsNullOrWhiteSpace(otraCadena3));

        // USO DE EMPTY
        string cadenaVacia = string.Empty;

        // Imprimir la cadena vacía
        Console.WriteLine("La cadena vacía es: " + cadenaVacia);
    }
}

