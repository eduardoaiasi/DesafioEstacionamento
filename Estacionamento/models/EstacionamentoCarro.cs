using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Estacionamentoa.models
{
    public class EstacionamentoCarro
    {
        private decimal precoInicial;
        private decimal precoPorHora;
        List<string> veiculos = new List<string>();
        public void Estacionamento(decimal precoPorHora, decimal precoInicial)
        {
            this.precoPorHora = precoPorHora;
            this.precoInicial = precoInicial;
        }
        
        public void AdicionarCarro()
        {
            Console.WriteLine("Digite a placa do veiculo:");
            string? placa = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(placa))
            {
                veiculos.Add(placa);
                Console.WriteLine($"O veiculo com a placa {placa} foi estacionado");
            }
            else
            {
                Console.WriteLine("Placa não pode ser vazia");
            }
        }

        public void RemoverCarro()
        {
            Console.WriteLine("Digite a placa do veiculo para remover:");
            string? placa = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(placa))
            {
                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))//verifica se o valor existe na Lista e set para ser em uppercase
                {
                    Console.WriteLine("Digite a quantidade de horas que você estacionou:");

                    if (decimal.TryParse(Console.ReadLine(), out decimal horas))//tenta converter o valor para inteiro, retorna um valor inteiro
                    {
                        decimal precoFinal = precoInicial + (precoPorHora * horas); //calcula o valor a ser pago

                        Console.WriteLine($"O preço a ser pago é de {precoFinal}. Tempo estacionado: {horas} horas");
                        veiculos.Remove(placa);
                    }
                }
                else
                {
                    Console.WriteLine("Este veiculo não está estacionado aqui");
                }
            }
            else
            {
                Console.WriteLine("Placa não pode ser vazia!");
            }
           
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine($"Placa do veiculo estacionado: {veiculo}");
                }
            }
            else
            {
            Console.WriteLine("Não há veiculos estacionados aqui");
           }
        }
    }
}