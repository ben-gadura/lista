using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_10
{
    internal class Program
    {
        public static void exercicio1()
        {
            int[] vet2;
            float media = 0;
            Console.WriteLine("entre com um tamanho");
            int T = int.Parse(Console.ReadLine());
            vet2 = new int[T];
            Random rand = new Random();
            for (int i = 0; i < T; i++)
            {
                vet2[i] = rand.Next(10, 50);
                media = media + vet2[i];
            }
            for (int i = 0; i < T; i++)
            {
                Console.WriteLine("posição[{0}] = {1}", i, vet2[i]);
            }
            Console.WriteLine(media / (float)T);
            Console.ReadKey();
        }



        public static void EXERCICIO2()
        {
            int[] vet2;
            float media = 0, numPar = 0, numImpar = 0;
            Console.WriteLine("entre com um tamanho");
            int T = int.Parse(Console.ReadLine());
            vet2 = new int[T];
            Random rand = new Random();
            for (int i = 0; i < T; i++)
            {
                vet2[i] = rand.Next(10, 50);

                if (vet2[i] % 2 == 0)
                {
                    numPar = numPar + vet2[i];
                }
                else
                    numImpar = numImpar + vet2[i];

            }
            for (int i = 0; i < T; i++)
            {
                Console.WriteLine("posição[{0}] = {1}", i, vet2[i]);
            }
            Console.WriteLine("Os numeros pares são " + numPar + "os numeros impares são " + numImpar);
            Console.ReadKey();
        }


        public static void EXERCICIO3()
        {
            int[] vet2;
            float media = 0;
            Console.WriteLine("entre com um tamanho");
            int T = int.Parse(Console.ReadLine());
            vet2 = new int[T];
            Random rand = new Random();
            for (int i = 0; i < T; i++)
            {
                vet2[i] = rand.Next(10, 50);
                Console.WriteLine("posição[{0}] = {1}", i, vet2[i]);
            }
            for (int i = T - 1; i >= 0; i--)
            {
                Console.WriteLine("posição[{0}] = {1}", i, vet2[i]);
            }
            Console.ReadKey();
        }

        public static void EXERCICIO4()
        {
            int[] vet2;
            float media = 0, numPar = 0, numImpar = 0;
            Console.WriteLine("entre com um tamanho");
            int T = int.Parse(Console.ReadLine());
            vet2 = new int[T];
            Random rand = new Random();
            int cont = 0;
            for (int i = 0; i < T; i++)
            {
                vet2[i] = rand.Next(10, 50);

                if (vet2[i] % 3 == 0 && vet2[i] % 5 == 0)
                {
                    numPar = numPar + vet2[i];
                    cont++;
                }

            }
            for (int i = 0; i < T; i++)
            {
                Console.WriteLine("posição[{0}] = {1}", i, vet2[i]);
            }
            Console.WriteLine("Os numeros pares são " + numPar / (float)cont);
            Console.ReadKey();
        }


        static void Main(string[] args)
        {

            int opção;

            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("digite 1 para exercicio 1");
                Console.WriteLine("digite 2 para exercicio 2");
                Console.WriteLine("digite 3 para exercicio 3");
                Console.WriteLine("digite 4 para exercicio 4");

                opção = int.Parse(Console.ReadLine());

                switch (opção)
                {
                    case 1:
                        exercicio1();
                        break;

                    case 2:
                        EXERCICIO2();
                        break;


                    case 3:
                        EXERCICIO3();
                        break;

                    case 4:
                        EXERCICIO4();
                        break;
                }




            }while (opção != 0);
        }
    }
}
