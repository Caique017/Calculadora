# Calculadora
Case para Engenharia de Software JR

Você precisa corrigir os seguintes problemas no codigo:
  1. Aplicação só está processando o primeiro item da fila infinitamente.

Correção: elemento não estava sendo retirado da fila e foi usado outro método para exibir e retirar o elemento da fila para exibir os outros elementos.

  2. Implemente a funcionalidade de divisão.

Correção: implementado na classe Calculadora

  3. Aplicação não está calculando a penultima operação corretamente.

             Saída esperada no console:

                     14 - 8 = 6

                     5 * 6 = 30

                     2147483647 + 2 = 2147483649

                     18 / 3 = 6

Correção: foi alterado na classe Operacoes que as variáveis valorA e valorB eram do tipo INT não tendo capacidade para a penúltima operação então utilizei um tipo de dado maior.

  5. Implemente uma funcionalidade para imprimir toda a lista de operaçõoes a ser processada após cada calculo realizado.

Correção: implementado na classe Operacoes.

  6. Crie uma nova pilha (Stack) para guardar o resultado de cada calculo efetuado e imprima a pilha ao final

Correção: implementado na classe Program.


Não existe resposta certa ou errada, o objetivo do case é avaliar a linha de raciocínio de cada candidato.
Você é livre para fazer na linguagem de sua preferência, desde que aplique as mesmas funcionalidades e tarefas deste case.
Dica: Utilize Visual Code ou Visual Studio Community para realizar as tarefas.
