using System.ComponentModel;
using System.Numerics;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.VisualBasic;
using System.ComponentModel.Design;
namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        public decimal precoInicial = 0;
        public decimal precoPorHora = 0;
        public List<string> veiculos = new List<string>();
        

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
            
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI* ok
            List<string> veiculos = new List<string>();
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine("Lista de veículos:");
            foreach (string veiculo in veiculos)
            {
                Console.WriteLine(veiculo);
            }


        }
        

        public void RemoverVeiculo(object v)
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            Console.ReadLine();

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI* FEITO
            Console.WriteLine("Digite a placa do veículo:");
            string placa = Console.ReadLine();
            Console.WriteLine($"Você digitou a placa: {placa}");

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper(CultureInfo.InvariantCulture)))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                Console.ReadLine();
                if (int.TryParse(Console.ReadLine(), out int horasEstacionado)) { }
                else { }
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI* FEITO
                double valorTotal = (double)(precoInicial + precoPorHora * horasEstacionado);
                 int horas = 0;
                 valorTotal = 0;
               

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI* FEITO
                veiculos.Remove(placa);
                Console.WriteLine("\nLista de veículos após a remoção:");
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }

                if (valorTotal > 0) 
                {
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
               //Console.WriteLine("Os veículos estacionados são:");
                foreach (var item in veiculos)
                {
                    Console.WriteLine($"Os veículos estacionados são:{veiculos} e o {ListarVeiculos}");

                }
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI* FEITO
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        internal object GetPlaca()
        {
            throw new NotImplementedException();
        }
    }
}

