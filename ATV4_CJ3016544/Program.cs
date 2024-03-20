Console.WriteLine("===============================================\n    digite a Operação que deseja realizar\n 1-Adição\n 2-Subtração\n 3-Multiplicação\n 4-Divisão\n===============================================");
int ope = int.Parse(Console.ReadLine());
switch (ope)
{
    case 1:
        Console.WriteLine("Digite os Numeros que deseja fazer a adiçao");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("A adição destes dois numeros resultara em" + num1 + num2);
        break;
        case 2:
        Console.WriteLine("Digite os Numeros que deseja fazer a subtração");
        int num3 = int.Parse(Console.ReadLine());
        int num4 = int.Parse(Console.ReadLine());
        Console.WriteLine("A subtração destes dois numeros resultara em" + (num3 - num4));
        break;
        case 3:
        Console.WriteLine("Digite os Numeros que deseja fazer a multiplicação");
        int num5 = int.Parse(Console.ReadLine());
        int num6 = int.Parse(Console.ReadLine());
        Console.WriteLine("A adição destes dois numeros resultara em" + num5 * num6);
        break;
        case 4:
        Console.WriteLine("Digite os Numeros que deseja fazer a Divisão");
        int num7 = int.Parse(Console.ReadLine());
        int num8 = int.Parse(Console.ReadLine());
        Console.WriteLine("A Divisão destes dois numeros resultara em" + num7 / num8);
        break;


}