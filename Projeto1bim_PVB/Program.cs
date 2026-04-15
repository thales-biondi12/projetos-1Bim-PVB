/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: 08/04/2026
* Autores do Projeto: Ryan Nicolas Cantuaria Pessoa
*                     Thales Andrade Biondi
* Turma: 2H
* Atividade Proposta em aula
* Observação: 
* 
* Program.cs
* ************************************************************/

using System;

namespace Projeto_1Bim
{
    class Program
    {
        static void Main(string[] args)
        {
            double Totalpico = 0;
            int Totalnum = 0;
            double TotalNaoPico = 0;
            double somaNpico = 0;
            int MaiorPico = -1;
            int num2;
            int tamanho;
            int temp;
            int anterior;
            int atual;
            bool subindo;
            bool descendo;
            bool ehPico;

            double MediaNaoPico;
            double PercentualPico;

            int num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                Totalnum++;
                num2 = num;

                temp = num;
                anterior = temp % 10;
                temp /= 10;

                tamanho = 1;
                subindo = false;
                descendo = false;
                ehPico = true;

                while (temp > 0)
                {
                    atual = temp % 10;

                    if (atual > anterior)
                    {
                        subindo = true;
                        if (descendo)
                        {
                            ehPico = false;
                        }
                    }
                    else if (atual < anterior)
                    {
                        descendo = true;
                    }
                    else
                    {
                        ehPico = false;
                    }

                    anterior = atual;
                    temp /= 10;
                    tamanho++;
                }

                if (tamanho < 3 || !subindo || !descendo)
                {
                    ehPico = false;
                }

                if (ehPico)
                {
                    Totalpico++;

                    temp = num2;
                    while (temp > 0)
                    {
                        atual = temp % 10;
                        if (atual > MaiorPico)
                            MaiorPico = atual;
                        temp /= 10;
                    }
                }
                else
                {
                    TotalNaoPico++;
                    somaNpico += num2;
                }

                num = int.Parse(Console.ReadLine());
            }

            MediaNaoPico = TotalNaoPico > 0 ? somaNpico / TotalNaoPico : 0;
            PercentualPico = Totalnum > 0 ? Totalpico / Totalnum * 100 : 0;

            Console.WriteLine("Total de Números de Pico: " + Totalpico);

            Console.WriteLine(MaiorPico == -1 ? "Maior dígito em picos: N/A" : "Maior dígito em picos: " + MaiorPico);

            Console.WriteLine(TotalNaoPico > 0 ? "Média dos não-picos: " + MediaNaoPico.ToString("0.00") : "Média dos não-picos: N/A");

            Console.WriteLine("Porcentagem de picos: " + PercentualPico.ToString("0.00") + "%");
        }
    }
}