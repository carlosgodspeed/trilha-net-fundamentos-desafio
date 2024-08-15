using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

// Solicita ao usuário o preço inicial e o preço por hora
Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            // Chama o método para adicionar um veículo
            es.AdicionarVeiculo();
            break;

        case "2":
            // Chama o método para remover um veículo
            es.RemoverVeiculo();
            break;

        case "3":
            // Chama o método para listar os veículos
            es.ListarVeiculos();
            break;

        case "4":
            // Encerra o loop e finaliza o programa
            exibirMenu = false;
            break;

        default:
            // Caso o usuário digite uma opção inválida
            Console.WriteLine("Opção inválida");
            break;
    }

    // Pausa para que o usuário possa ver a mensagem antes de limpar a tela
    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

// Mensagem final ao encerrar o programa
Console.WriteLine("O programa se encerrou");
