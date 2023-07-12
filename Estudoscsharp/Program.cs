Dictionary<string, List<int>> bandasregistradas = new Dictionary<string, List<int>>();

RegistrarBanda();
void RegistrarBanda()
{
    
    // List<string> lista = new List<string>();
    Console.Clear();


    mensagem();

    Caso();

 
   //ExibirBnadas();

}

//void ExibirBnadas(List<string> lista)
//{


//    Console.WriteLine($"As bandas registradas foram: {lista}");

//    for (int i = 0; i < lista.Count; i++)
//    {
//        Console.WriteLine($"As bandas foram :{lista[i]}");

//    }
//    Console.WriteLine("Digite qualquer coisa para voltar ao menu ou N para sair da aplicação");
//     string digitado = Console.ReadLine();
//    if (digitado!="N")
//    {
//        RegistrarBanda();
        
//    }
//    else
//    {
//        Console.WriteLine("Fim do programa :D");
//        Testeloop();
//    }
   
//}
void mensagem()
{

    Console.WriteLine(@"
░██████╗███████╗░░░░░██╗░█████╗░███╗░░░███╗  ██████╗░███████╗███╗░░░███╗
██╔════╝██╔════╝░░░░░██║██╔══██╗████╗░████║  ██╔══██╗██╔════╝████╗░████║
╚█████╗░█████╗░░░░░░░██║███████║██╔████╔██║  ██████╦╝█████╗░░██╔████╔██║
░╚═══██╗██╔══╝░░██╗░░██║██╔══██║██║╚██╔╝██║  ██╔══██╗██╔══╝░░██║╚██╔╝██║
██████╔╝███████╗╚█████╔╝██║░░██║██║░╚═╝░██║  ██████╦╝███████╗██║░╚═╝░██║
╚═════╝░╚══════╝░╚════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝  ╚═════╝░╚══════╝╚═╝░░░░░╚═╝

██╗░░░██╗██╗███╗░░██╗██████╗░░█████╗░░██████╗
██║░░░██║██║████╗░██║██╔══██╗██╔══██╗██╔════╝
╚██╗░██╔╝██║██╔██╗██║██║░░██║██║░░██║╚█████╗░
░╚████╔╝░██║██║╚████║██║░░██║██║░░██║░╚═══██╗
░░╚██╔╝░░██║██║░╚███║██████╔╝╚█████╔╝██████╔╝
░░░╚═╝░░░╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░╚═════╝░
");
}
void Testeloop()
{
    foreach (string banda in bandasregistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
}
void Caso()

{
    
   
    int opcoes = int.Parse(Menu());


    switch (opcoes)
    {
        case 1:
            Registrar();
            break;
        case 2:
            Dici();
            break;
        case -3:
            Registrar();
        break;

        default: Console.WriteLine("Opçao invalida");
            break;
    }
}
void Registrar()
{
    Console.WriteLine("Registrar bandas? (s/n)");
    string registrar = Console.ReadLine()!;
    while (registrar == "s")
    {
        Console.WriteLine("Digite o nome das bandas que deseja registrar");
        string registro = Console.ReadLine()!;
        // lista.Add(registro);


        // ********//chamando o dicionario, e atribuindo a chave e a nota;
        bandasregistradas.Add(registro, new List<int>());
        Testeloop();




        //Console.WriteLine($"A banda registrada foi a {registro}");

        Console.WriteLine("Deseja continuar registrando as bandas? (s/n)");
        registrar = Console.ReadLine();

    }
}
string Menu()
{
    Console.WriteLine("Registrar digite (1)");
    Console.WriteLine("verificar e vizualizar bandas (2)");
    Console.WriteLine("sair digite -3");
    string registrar = Console.ReadLine();
   
    return registrar;
}
void Dici()
{

    //digite qual banda deseja avaliar;
    //se a nota existir no dicionario, atribuir uma nota a ela;
    //senão, volta ao menu principal;
    
    bandasregistradas.Add("Calipson", new List<int>() { 10, 8, 6 });
    bandasregistradas.Add("the betles", new List<int>());

    Console.WriteLine("Digite a banda que deseja avaliar: ");
    string avaliar = Console.ReadLine()!;

    if(bandasregistradas.ContainsKey(avaliar))
    {
        Console.WriteLine($"De uma nota a banda {avaliar}: ");
        int nota = int.Parse(Console.ReadLine()!);

        //atribuindo uma nota a bandas!

        //usando os colchetes encontramos a chave do dicionario e com o metodo .ADD adicionamos a nota para a banda solicitada;

        bandasregistradas[avaliar].Add(nota);
        Console.WriteLine($"\nA nota {nota}, foi registrada com aucesso para  a banda, {avaliar}");

        foreach (var banda in bandasregistradas)
        {
            string nomeBanda = banda.Key;

            
            List<int> notas = banda.Value;

            Console.WriteLine($"Banda: {nomeBanda}");
            Console.WriteLine($"Notas: {notas}");

            foreach (int x in notas)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine(); // Linha em branco para separar as bandas
        }

        Thread.Sleep(4000);
        Console.Clear();
        Caso();

    }
    else
    {
        Console.WriteLine($"\nA banda {avaliar}, não foi encontrada!");
    }




   
}