using Estacionamentoa.models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao estacionamento!\n" + " Digite o valor inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o valor por Hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("O preço inicial é de R$" + precoInicial + "\n o preco por hora é de R$" + precoPorHora);


EstacionamentoCarro es = new EstacionamentoCarro();

es.Estacionamento(precoInicial, precoPorHora);

bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite uma opção:");
    Console.WriteLine("1-Adicionar Carro");
    Console.WriteLine("2-Remover Carro");
    Console.WriteLine("3-Listar Carros");
    Console.WriteLine("4-Sair");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarCarro();
            break;
        case "2":
            es.RemoverCarro();
            break;
        case "3":
            es.ListarVeiculos();
            break;
        case "4":
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção invalida");
            break;
    }
    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}
Console.WriteLine("O programa se encerrou!");







