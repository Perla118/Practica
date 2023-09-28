using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa un número entero: ");
        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out int numero))
        {
            int longitud = userInput.Length;
            int mitad = longitud / 2;

            // Obtener el dígito en la mitad del número
            int digitoMitad = int.Parse(userInput[mitad].ToString());

            Console.WriteLine("Dígito en la mitad del número: " + digitoMitad);

            // Verificar si es par o impar
            Console.WriteLine("Es par: " + (digitoMitad % 2 == 0));
            Console.WriteLine("Es impar: " + (digitoMitad % 2 != 0));

            // Verificar si es negativo o positivo
            Console.WriteLine("Es negativo: " + (digitoMitad < 0));
            Console.WriteLine("Es positivo: " + (digitoMitad > 0));

            // Verificar si es primo
            bool esPrimo = EsPrimo(digitoMitad);
            Console.WriteLine("Es primo: " + esPrimo);
        }
        else
        {
            Console.WriteLine("No se pudo convertir el número ingresado a un entero.");
        }
    }

    // Método para verificar si un número es primo
    static bool EsPrimo(int numero)
    {
        if (numero <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
                return false;
        }

        return true;
    }
}
