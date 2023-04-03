// coca-cola
// pepsi
// fanta
// monster

// crie um menu de opcoes e peca para o usuario escolher uma das opcoes a depender da opcao, exiba uma mensagem se gostaria de acrescentar gelo, se sim, exiba uma mensagem que a bebida em questao sera com adicional de gelo, caso contrario a bebida e sem gelo adicional.

Console.WriteLine(@$"Escolha uma bebida: 
|----------------------|
|       BEBIDAS        |
|                      |
|   coca-cola (1)      |
|   pepsi (2)          |
|   fanta (3)          |    
|   monster (4)        |
|----------------------|
");

int escolha = int.Parse(Console.ReadLine());

switch (escolha)
{
    case 1:
        escolha = 1;
        Console.WriteLine($"Adiciona gelo?");
        
         

        break;
    default:
        break;
}



