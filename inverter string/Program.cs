using System;


namespace inverter_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um texto para inverter: ");
            string input = Console.ReadLine();

            
            char[] caracteres = input.ToCharArray();

            
            int length = caracteres.Length;
            for (int i = 0; i < length / 2; i++)
            {
                
                char temp = caracteres[i];
                caracteres[i] = caracteres[length - i - 1];
                caracteres[length - i - 1] = temp;
            }

            
            string resultado = new string(caracteres);


            Console.WriteLine("String invertida: " + resultado);
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
