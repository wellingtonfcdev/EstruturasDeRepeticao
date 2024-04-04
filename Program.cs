int numero = 5;

Console.WriteLine($"{numero} x 1 = {numero * 1}");
Console.WriteLine("**************************\n");
//For
for(int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}

//While
Console.WriteLine("\n********* WHILE *********** " + DateTime.Now);

int contWhile = 0;
while(contWhile <= 10)
{
    Console.WriteLine($"{numero} x {contWhile} = {numero * contWhile}");
    contWhile++;

    if(contWhile == 9)
    {
        break;
    }
}

Console.WriteLine("\n********* DO WHILE *********** " + DateTime.Now);

int soma = 0, num = 0;

do
{
    Console.WriteLine("Digite um número (0 para)");
    num = Convert.ToInt32(Console.ReadLine());

    soma += num;

}while(num != 0);

Console.WriteLine($"Total da soma dos números digitados é: {soma}");


Console.WriteLine("\n********* Menu Interativo *********** " + DateTime.Now);

string opcao;
bool exibirMenu = true;

while(exibirMenu)
{
    
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastro Cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("3 - Apagar Cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro Cliente");
            break;
        case "2":
            Console.WriteLine("Buscar Cliente");
            break;
        case "3":
            Console.WriteLine("Apagar Cliente");
            break;
        case "4":
            Console.WriteLine("Encerrado");
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}
Console.WriteLine("O programa encerrou");