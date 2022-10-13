using System;
using System.Linq.Expressions;
using System.Xml;

namespace Lista3AcademiaDotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LISTA 3 //
            //EXERCÍCIO 1
            /*
            int num = 0;

            Console.Write("Digite um número inteiro positivo: ");
            num = int.Parse(Console.ReadLine());

            while (num < 0)
            {

                Console.WriteLine("Valor inválido!");
                Console.Write("Digite um número inteiro positivo: ");
                num = int.Parse(Console.ReadLine());

            }

            Console.Write("Números inteiros pares entre 1 e " + num + ":");

            for (int i = 1; i < num; i++)
            {

                if (i % 2 == 0)
                {

                    Console.Write(" " + i);

                }

            }
            */


            //EXERCÍCIO 2
            /*
            int num = 0;
            char continuar = ' ';

            do
            {

                Console.Write("Digite um número inteiro positivo: ");
                num = int.Parse(Console.ReadLine());

                while (num < 0)
                {

                    Console.WriteLine("Valor inválido!");
                    Console.Write("Digite um número inteiro positivo: ");
                    num = int.Parse(Console.ReadLine());

                }

                Console.Write("Números inteiros pares entre 1 e " + num + ":");

                for (int i = 1; i < num; i++)
                {

                    if (i % 2 == 0)
                    {

                        Console.Write(" " + i);

                    }

                }

                Console.WriteLine("");
                Console.WriteLine("Gostaria de continuar o código? (s/n): ");
                continuar = char.Parse(Console.ReadLine());
                Console.Clear();

            } while (continuar == 's');

            Console.WriteLine("Programa finalizado.");
            */


            //EXERCÍCIO 3
            /*
            int num;

            Console.Write("Digite um número (0 para finalizar): ");
            num = int.Parse(Console.ReadLine());

            while (num > 0)
            {

                if (num % 2 == 0)
                {

                    Console.WriteLine("O número " + num + " é par.");

                }
                else
                {

                    Console.WriteLine("O número " + num + " é ímpar.");

                }

                int qntDeDivisoes = 0;

                for (int i = 1; i <= num; i++)
                {

                    if (num % i == 0)
                    {

                        qntDeDivisoes++;

                    }

                }

                if (qntDeDivisoes > 2)
                {

                    Console.WriteLine("O número " + num + " não é primo.");

                }
                else
                {

                    Console.WriteLine("O número " + num + " é primo.");

                }


                Console.Write("Digite um número (0 para finalizar): ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Zero digitado. Programa finalizado.");
            */



            //EXERCÍCIO 4 
            /*
            string nome = "", fim = "";
            int votoZeca = 0, votoBranco = 0, votoJoao = 0;

            Console.Write("Registre o seu voto (JOAO, ZECA, BRANCO ou FIM, para finalizar o programa): ");
            nome = Console.ReadLine();

            while (fim != "FIM")
            {

                if (nome == "JOAO")
                {

                    votoJoao++;

                }
                else if (nome == "ZECA")
                {

                    votoZeca++;

                }
                else if (nome == "BRANCO")
                {

                    votoBranco++;

                }
                else
                {

                    Console.WriteLine("FIM digitado. Programa finalizado.");
                    break;

                }

                Console.WriteLine("Voto computado.");
                Console.Write("Registre o seu voto (JOAO, ZECA, BRANCO ou FIM, para finalizar o programa): ");
                nome = Console.ReadLine();

            }

            Console.WriteLine("Houveram " + votoJoao + " votos em João.");
            Console.WriteLine("Houveram " + votoZeca + " votos em Zeca.");
            Console.WriteLine("Houveram " + votoBranco + " votos em branco.");
            */



            //EXERCÍCIO 5 
            /*
            string nome = "";
            int votoZeca = 0, votoBranco = 0, votoJoao = 0, votoNulo = 0, votoTotal;

            Console.Write("Registre o seu voto (JOAO, ZECA, BRANCO ou FIM (finalizar o programa)): ");
            nome = Console.ReadLine();

            while (nome != "FIM")
            {

                if (nome == "JOAO")
                {

                    Console.WriteLine("Voto computado.");
                    votoJoao++;

                }
                else if (nome == "ZECA")
                {

                    Console.WriteLine("Voto computado.");
                    votoZeca++;

                }
                else if (nome == "BRANCO")
                {

                    Console.WriteLine("Voto computado.");
                    votoBranco++;

                }
                else
                {

                    Console.WriteLine("Voto computado.");
                    votoNulo++;

                }

                Console.Write("Registre o seu voto (JOAO, ZECA, BRANCO ou FIM (finalizar o programa)): ");
                nome = Console.ReadLine();

            }

            votoTotal = votoBranco + votoJoao + votoNulo + votoZeca;

            Console.WriteLine(" ");
            Console.WriteLine("----------------------------Resultado----------------------------");

            if (votoJoao > votoZeca)
            {

                Console.WriteLine("João é o vencedor!");

            }
            else if (votoJoao < votoZeca)
            {

                Console.WriteLine("Zeca é o vencedor!");

            }
            else {

                Console.WriteLine("Empate!");
            
            }


            Console.WriteLine("Houveram " + votoTotal + " votos no total.");
            Console.WriteLine("Houveram " + votoNulo + " votos nulos.");
            Console.WriteLine("Houveram " + votoJoao + " votos em João.");
            Console.WriteLine("Houveram " + votoZeca + " votos em Zeca.");
            Console.WriteLine("Houveram " + votoBranco + " votos em branco.");
            */



            //EXERCÍCIO 6 
            /*
            int idade = 0;

            Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine());

            while (idade <= 0)
            {

                Console.Write("Digite uma idade válida (maior que zero): ");
                idade = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Idade digitada: " + idade);
            */



            //EXERCÍCIO 7
            /*
            string nome = "";
            int idade = 0;
            double salario = 0;

            //nome.Any(char.IsDigit) faz a leitura se a variável "nome" possui um dígito.
            //string.IsNullOrWhiteSpace(nome) faz a leitura da string nome se ela possui espaços em branco ou se é nula.

            do
            {

                Console.Write("Digite um nome válido: ");
                nome = Console.ReadLine();
                Console.WriteLine("");

            } while (nome.Any(char.IsDigit) || string.IsNullOrWhiteSpace(nome));

            do
            {

                Console.Write("Digite uma idade válida: ");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("");

            } while (idade <= 0);

            do
            {

                Console.Write("Digite um salário válido: ");
                salario = double.Parse(Console.ReadLine());
                Console.WriteLine("");

            } while (salario <= 0);

            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Salário: " + salario);
            */



            //EXERCÍCIO 8 
            /*
            double num;

            do
            {
                Console.Write("Digite um número inteiro: ");
                num = double.Parse(Console.ReadLine());
                Console.WriteLine("");
            }while (num % 1 != 0);

            if (num % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é ímpar.");
            }
            */



            //EXERCÍCIO 9 
            /*

            int cont = 0, cont13 = 0, cont47 = 0, cont8 = 0;

            for (int i = 0; i < 31; i++)
            {
                Console.Write("Digite a quantidade de filhos que você possui: ");
                int filhos = int.Parse(Console.ReadLine());

                if (filhos >= 8)
                {
                    cont8++;
                }
                else if (filhos >= 4)
                {
                    cont47++;
                }
                else if (filhos >= 1)
                {
                    cont13++;
                }
                else
                {
                    cont++;
                }
            }

            Console.WriteLine("");
            Console.WriteLine(cont8+" pessoas possuem mais ou 8 filhos.");
            Console.WriteLine(cont47+" pessoas possuem de 4 a 7 filhos.");
            Console.WriteLine(cont13+" pessoas possuem de 1 a 3 filhos.");
            Console.WriteLine(cont+" pessoas não possuem filhos.");
            */



            //EXERCÍCIO 10 
            /*
            string nome = "";
            char sexo = ' ';
            int idade, contSF=0, contSM=0, media = 0, contIdadeMaior=0, contIdadeMenor=0;

            for (int i = 0; i < 51; i++)
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("");

                Console.Write("Sexo (M ou F): ");
                sexo = char.Parse(Console.ReadLine());
                Console.WriteLine("");

                Console.Write("Idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                if (sexo == 'F' || sexo == 'f')
                {
                    contSF++;
                    media = media + idade;
                }
                else
                {
                    contSM++;
                }

                if (idade > 60)
                {
                    contIdadeMaior++;
                }
                else if (idade < 30)
                {
                    contIdadeMenor++;
                }
                
            }
            media = media / 50;

            Console.WriteLine("Número de pessoas do sexo masculino: "+contSM);
            Console.WriteLine("Número de pessoas do sexo feminino: "+contSF);
            Console.WriteLine("Número de pessoas com idade superior a 60: "+contIdadeMaior);
            Console.WriteLine("Número de pessoas com idade inferior a 30: "+contIdadeMenor);
            Console.WriteLine("Média de idade das mulheres: " + media);
            */



            //EXERCÍCIO 11 
            /**/










        }
    }
}