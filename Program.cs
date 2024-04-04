int numero = 5;

Console.WriteLine($"{numero} x 1 = {numero * 1}");
Console.WriteLine("**************************\n");
//For
for(int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}

//While
Console.WriteLine("********* WHILE *********** " + DateTime.Now);

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