﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            Stack<long> pilhaResultados = new Stack<long>();

            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' }); //Implemente o calculo de divisao

            Calculadora calculadora = new Calculadora();


            while (filaOperacoes.Count > 0)
            {
                Operacoes operacao = filaOperacoes.Dequeue();
                calculadora.calcular(operacao);
                pilhaResultados.Push(operacao.resultado);
                Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA, operacao.operador, operacao.valorB, operacao.resultado);

                Console.WriteLine("Operações restantes na fila:");
                foreach (var operacoesRestantes in filaOperacoes)
                {
                    Console.WriteLine("{0} {1} {2}", operacoesRestantes.valorA, operacoesRestantes.operador, operacoesRestantes.valorB);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Resultados na pilha:");

            while (pilhaResultados.Count > 0)
            {
                Console.WriteLine(pilhaResultados.Pop());
            }

            Console.ReadLine();


        }
    }
}