namespace ProjetoDiamante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int espacos, x;

            Console.WriteLine("Digite um número impar: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 != 0)
            {
                x = 1;
                espacos = (numero - 1) / 2;

                for (int linha = 1; espacos > 0; linha++)
                {
                    for (int cont = 1; cont <= espacos; cont++)
                    {
                        Console.Write(" ");
                    }

                    for (int count = 1; count <= x; count++)
                    {
                        Console.Write("X");
                    }

                    espacos--;
                    x += 2;
                    Console.WriteLine();

                }

                for (int linha = 1; x > 0; linha++)
                {
                    for (int count = 1; count <= espacos; count++)
                    {
                        Console.Write(" ");
                    }

                    for (int count = 1; count <= x; count++)
                    {
                        Console.Write("X");
                    }

                    espacos++;
                    x -= 2;
                    Console.WriteLine();
                }
            }

            else
            {
                Console.WriteLine("O número inserido é inválido.");
                Console.ReadLine();
            }

        }
    }
}