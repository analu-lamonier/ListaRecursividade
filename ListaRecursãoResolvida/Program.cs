using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaRecursãoResolvida
{
    internal class Program
    {
        static void Main(string[] args)
        {


        
            /*-----------------------------------------------------------------------
            
            1) Escreva uma função (em C#) que calcule a multiplicação de dois números 
            naturais x e y, segundo a definição recursiva abaixo: 
            a. 𝑥 ∗ 𝑦 = 𝑥, 𝑠𝑒 𝑦 = 1 
            b. 𝑥 ∗ 𝑦 = 𝑥 ∗ (𝑦 − 1) + 𝑥, 𝑠𝑒 𝑦 > 1
            */

            int Multiplica(int x, int y)
            {
                if (y == 1)
                    return x;
                else
                    return x + Multiplica(x, y - 1);
            }

           
            

            Console.WriteLine("Multiplicação 10 e 1 = " + Multiplica(10, 1));
            Console.WriteLine("Multiplicação 10 e 2 = " + Multiplica(10, 2));



            /*-----------------------------------------------------------------------
            
            2) Escreva uma função recursiva que recebe um número natural i e retorna o valor 
            do número da sequência de Fibonacci que está na posição i. 
            */


            int Fibonacci(int i)
            {
                if (i == 1 || i == 2)
                    return 1;
                else
                    return Fibonacci(i - 1) + Fibonacci(i - 2);
            }

            Console.WriteLine("número da sequência de Fibonacci que está na posição 1 -> " + Fibonacci(1));
            Console.WriteLine("número da sequência de Fibonacci que está na posição 6 -> " + Fibonacci(6));

            /*-----------------------------------------------------------------------
            
            3) Busca Binária. Considere um vetor de números inteiros ordenados de forma 
            crescente. Escreva uma função recursiva que receba um número n e retorne o 
            índice i deste número neste vetor. Caso o número n não esteja neste vetor 
            ordenado, retorne i = -1. 
            */

            int BuscaBinaria(int[] vet, int num, int n)
            {

                if (n == 1)
                {
                    return 0;
                }
                else if (num == vet[n - 1])
                {
                    return n - 1;
                }
                else
                {
                    return BuscaBinaria(vet, num, n - 1);
                }
            }

            int[] array1 = new int[5] { 1, 3, 7, 12, 8 };

            Console.WriteLine("O indice do número 7 no vetor é " + BuscaBinaria(array1, 7, array1.Length));



            /* -----------------------------------------------------------------------
            
            4) Imagine a como um vetor de números inteiros. Apresente algoritmos recursivos 
            para calcular: 

            a. O elemento máximo do vetor; -------------------------------------------*/

            int Maximo(int n, int[] v)
            {
                int x;
                if (n == 1)
                {
                    x = v[0];
                }
                else
                {
                    x = Maximo(n - 1, v);
                    if (x < v[n - 1])
                    {
                        x = v[n - 1];
                    }
                }
                return x;
            }

            int[] valores = { 11, 10, 4, -4, 2, -7, 9 };
            Console.WriteLine("Máximo: " + Maximo(valores.Length, valores));

            // b. O elemento mínimo do vetor; ------------------------------------------

            int Minimo(int n, int[] v)
            {
                int y;

                if (n == 1)
                {
                    y = v[0];
                }
                else
                {
                    y = Minimo(n - 1, v);
                    if (y > v[n - 1])
                    {
                        y = v[n - 1];
                    }
                }
                return y;
            }

            Console.WriteLine("Mínimo: " + Minimo(valores.Length, valores));

            //c. A soma dos elementos do vetor; ------------------------------------------

            int SomaVetor(int n, int[] v)
            {

                
                if (n == 1)
                {
                    return v[0];
                }
                return v[n - 1] + SomaVetor(n-1, v);
                
            }

            Console.WriteLine("Soma: " + SomaVetor(valores.Length, valores));



            // d. A média dos elementos do vetor. ------------------------------------------

            int Media(int[] v, int n)
            {
                int aux = n;
                if (n == 0) 
                { 
                    return 0;
                }
                else if (n == aux)
                {
                     return (v[n - 1] + Media(v, n - 1)) / 5;
                }
                else return v[n - 1] + Media(v, n - 1);
            }

            Console.WriteLine("Média: " + Media(valores, valores.Length));

            /*-----------------------------------------------------------------------
            
            5) Torre de Hanói é um "quebra-cabeça" que consiste em uma base contendo três pinos, 
            em um dos quais são dispostos alguns discos uns sobre os outros, em ordem crescente 
            de diâmetro, de cima para baixo. O problema consiste em passar todos os discos de um 
            pino para outro qualquer, usando um dos pinos como auxiliar, de maneira que um disco 
            maior nunca fique em cima de outro menor em nenhuma situação. O número de discos 
            pode variar sendo que o mais simples contém apenas três. Implementar o algoritmo 
            para solucionar o problema das Torres de Hanoi, para três discos.*/


            void hanoi(int n, char orig, char dest, char aux)
            {
                if (n == 1)
                    Console.WriteLine("A -> B\n", dest);
                else
                {
                    hanoi(n - 1, orig, aux, dest);
                    Console.WriteLine("C -> B\n", n, dest);
                    hanoi(n - 1, aux, dest, orig);
                }
            }

            hanoi(3, 'A', 'B', 'C');
                

            Console.ReadLine();

        }

























}


}

