using System;

    class program
{
    static void Main()
    {
        string[] nombres = new string[5];
        int[] edad = new int[5];
        
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese nombre: ");
            nombres[i] = Console.ReadLine();
            Console.WriteLine("Ingrese edad: ");
            edad[i] = Convert.ToInt32(Console.ReadLine()); 
        }

        for (int i = 0; i < 5; i++)
        {
            if (edad[i] >= 18)
            {
                Console.WriteLine(nombres[i]);
            }
        }

    }
}
