using System;

namespace Esquerda_Volver.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char direcaoDoSargento;
            Console.Write("Digite a quantidade de comandos emitidos pelo sargento: ");
            int qntComandos = int.Parse(Console.ReadLine());

            while (qntComandos != 0) {

                Console.Write("Digite os comandos: ");
                string comandos = Console.ReadLine();
                char[] comandosChar = comandos.ToCharArray();
                direcaoDoSargento = 'N';

                for (int i = 0; i < qntComandos; i++)
                {
                    if (direcaoDoSargento == 'N')
                    {
                        if ((comandosChar[i] == 'E'))
                        {
                            direcaoDoSargento = 'O';
                        }

                        if (comandosChar[i] == 'D')
                        {
                            direcaoDoSargento = 'L';
                        }
                    }

                    else if (direcaoDoSargento == 'S')
                    {
                        if ((comandosChar[i] == 'E'))
                        {
                            direcaoDoSargento = 'L';
                        }

                        if (comandosChar[i] == 'D')
                        {
                            direcaoDoSargento = 'O';
                        }
                    }

                    else if (direcaoDoSargento == 'L')
                    {
                        if ((comandosChar[i] == 'E'))
                        {
                            direcaoDoSargento = 'n';
                        }

                        if (comandosChar[i] == 'D')
                        {
                            direcaoDoSargento = 'S';
                        }
                    }

                    else if (direcaoDoSargento == 'O')
                    {
                        if ((comandosChar[i] == 'E'))
                        {
                            direcaoDoSargento = 'S';
                        }

                        if (comandosChar[i] == 'D')
                        {
                            direcaoDoSargento = 'N';
                        }
                    }

                }

                Console.WriteLine(direcaoDoSargento);
                Console.WriteLine();

                Console.Write("Digite a quantidade de comandos emitidos pelo sargento: ");
                qntComandos = int.Parse(Console.ReadLine());

            }
        }
    }
}
