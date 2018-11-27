using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_6_exercicios_praticas_de_programação
{
    class Program
    {






        static void Main(string[] args)
        {

            #region Exercicio 1
            ///1. Uma empresa quer transmitir dados pelo telefone, mas está preocupada com a
            ///interceptação telefônica. Todos os seus dados são transmitidos como inteiros de quatro
            ///dígitos.Ela pediu para que você escreva um programa que criptografe seus dados, para
            ///que eles possam ser transmitidos com mais segurança. Seu aplicativo deve ler um inteiro
            ///de quatro dígitos fornecidos pelo usuário e criptografá-lo da seguinte forma: substitua cada
            ///dígitos por(a soma desse dígitos mais 7) módulo 10.Em seguida, troque o primeiro dígito
            ///pelo terceiro e troque o segundo dígito pelo quarto e imprima o inteiro criptografado.


            Console.Write("Digite um numero de 4 digitos :");

            int Entrada = Convert.ToInt32(Console.ReadLine());

            ///modulo de 10 no primeiro digito
            ///vou criar a variavel temporario1 que sera entrada dividido por 1000

            int temporario1 = Entrada / 1000;
            ///agora obtenho o resto da divisão de entrada por 1000

            int resto1 = Entrada % 1000;
            ///agora atribuo o valor numero1 como a divisao da entrada por 1000

            int numero1 = temporario1;

            ///agora vamos obter o segundo digito
            ///vou atribuir o valor temporario 2 que sera o valor de resto1 dividido por 100

            int temporario2 = resto1 / 100;
            ///agora vou atribuir o resto do valor 

            int resto2 = resto1 % 100;
            ///agora vou ter a variavem numero2 que sera igual a variavel temporario2

            int numero2 = temporario2;

            ///agora vamos obter o terceiro digito
            ///vou atribuir o valor temporario 3 que sera o valor de resto 2 / 10

            int temporario3 = resto2 / 10;

            int resto3 = resto2 % 10;

            int numero3 = temporario3;

            int numero4 = resto3;

            ///fazendo a parte da soma da criptografia

            var numero_1_criptografado = (numero1 + 7) % 10;
            var numero_2_criptografado = (numero2 + 7) % 10;
            var numero_3_criptografado = (numero3 + 7) % 10;
            var numero_4_criptografado = (numero4 + 7) % 10;

            Console.WriteLine("Os numeros apos a criptografia são :");

            Console.Write("[0][1][2][3]", numero_3_criptografado, numero_4_criptografado, numero_1_criptografado, numero_2_criptografado);

            Console.ReadLine();
            Console.Clear();

            #endregion

            #region Exercicio 2
            ///Crie um programa em C# que determina se o cliente de uma loja de departamentos
            ///ultrapassou o limite de crédito em uma conta. Para cada cliente modelado em uma classe,
            ///os seguintes dados estão disponíveis:
            ///
            ///a. Número da conta
            ///b. O saldo no início do mês;
            ///c. O total de todos os itens cobrados desse cliente no mês corrente;
            ///d. O total de todos os créditos aplicados na conta desse cliente no mês corrente;
            ///e. O limite de crédito permitido.
            ///
            ///O programa deve fornecer como valores inteiros cada um desses fatos, e através dos
            ///métodos da classe cliente: calcular o novo saldo(= saldo inicial + cobranças - créditos),
            ///exibir o novo saldo e determinar se o novo saldo ultrapassa o limite de crédito do cliente.
            ///Para os clientes cujo limite de crédito foi ultrapassado, o programa deve exibir a
            ///mensagem: “Limite de Crédito Excedido!”. Teste a classe criada, bem como os métodos
            ///propostos na classe principal do seu programa. 

            int saldo = 0;

            Console.WriteLine("Digite o valor do saldo :");
            saldo = int.Parse(Console.ReadLine());

            Cliente_Exercicio2 cliente = new Cliente_Exercicio2(saldo, 2, 200, 300, 4000);
            Console.WriteLine("o seu novo limite de credito é :");
            Console.Write(cliente.calcular_novo_saldo());

            cliente.atualizar_saldo();

            if (cliente.verificar_limite())
            {

            }
            else
            {

            }
            Console.ReadLine();
            Console.Clear();



            #endregion

            #region Exercicio 3

            ///Implemente em C# a função booleana Par que retorna verdadeiro se um número inteiro
            ///passado como parâmetro for par ou falso caso ele seja ímpar.Teste seu programa
            ///chamando a função para verificar os números de 0 à 10. 




            Console.WriteLine("Escreva o numero para verificar se ele é impar ou par :");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("o numero [0] é par", numero);
            }
            else
            {
                Console.WriteLine("o numero [0] é impar", numero);
            }



            Console.ReadKey();
            Console.Clear();

            #endregion

            #region Exercicio 4
            ///Escreva um programa que leia 3 números inteiros referente ao comprimento dos lados de
            ///um triângulo e classifique como: triângulo equilátero, isósceles ou escaleno. 

            Console.Write("Digite o valor do primeiro lado :");
            string triangulo_lado1 = Console.ReadLine();

            Console.Write("Digite o valor do segundo lado :");
            string triangulo_lado2 = Console.ReadLine();

            Console.Write("Digite o valor do terceiro e ultimo lado :");
            string triangulo_lado3 = Console.ReadLine();

            if (triangulo_lado1 == triangulo_lado2 && triangulo_lado2 == triangulo_lado3)
            {

                Console.WriteLine("Este é um triangulo equilátero");

            }
            else if (triangulo_lado1 == triangulo_lado2 || triangulo_lado2 == triangulo_lado3 || triangulo_lado1 == triangulo_lado3)
            {

                Console.WriteLine("Este é um triangulo isósceles");

            }
            else
            {

                Console.WriteLine("Este é um triangulo escaleno");

            }
            Console.ReadLine();
            Console.Clear();



            #endregion

            #region Exercicio 5
            ///Escreva um programa que leia apenas uma letra do alfabeto como entrada e classifique-a
            ///como vogal ou consoante. Seu programa deverá aceitar como entrada apenas um
            ///caractere, ou seja, se o usuário digitar dois ou mais caracteres, o sistema deverá informar
            ///ao usuário a entrada rejeitada. 

            int verifica = 0;

            Console.Write("Digite apenas uma letra do alfabeto :");

            var letra = Console.ReadLine().ToArray();

            string[] vogais = new string[] { "a", "A", "e", "E", "i", "I", "o", "O", "u", "U" };

            if (letra.Length == 1)
            {
                for (int i = 0; i < vogais.Length; i++)
                {
                    if (letra[0].ToString() == vogais[i])
                    {
                        verifica = 1;
                    }
                }

                if (verifica == 1)
                {
                    Console.WriteLine("\n \t A letra digitada é uma VOGAL.");
                }

                else
                {
                    Console.WriteLine("\n \t A letra digitada é uma CONSOANTE ou um caracter qualquer.");
                }

            }
            else
            {
                Console.WriteLine("ENTRADA REJEITADA!");
            }

            Console.ReadKey();
            Console.Clear();




            #endregion

            #region Exercicio 6
            ///“Um número é primo se ele for divisível por 1 e por ele mesmo”. Escreva um programa C#
            ///que verifica se um número é primo. 

            Console.WriteLine("\t Exercício 6: \n");

            Console.WriteLine("Digite um número natural maior que 2 e verifique se ele é Primo ou não:\n");

            int numprimo = 0;
            int restodivisao = 0;
            int denominador = 0;
            int verificador = 0;

            numprimo = int.Parse(Console.ReadLine());

            for (denominador = 2; denominador < numprimo; denominador++)
            {
                restodivisao = numprimo % denominador;

                if (restodivisao == 0)
                {
                    verificador = 1;
                }
            }

            if (verificador == 1)
            {
                Console.WriteLine("O número digitado não é um número PRIMO.");
            }
            else
            {
                Console.WriteLine("O número digitado é um número PRIMO.");
            }
            Console.ReadKey();
            Console.Clear();


            #endregion

































        }

    }
}