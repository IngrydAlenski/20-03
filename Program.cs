//Criar um vetor de idade com 4 posicoes
//Use um for 

//string[] idades = new string[4];

//for (int i = 0; i < idades.Length; i++)
//{
//    Console.WriteLine("Por favor informe a idade:");
//    idades[i] = Console.ReadLine();
//for (int i = 0; i < idades.Length; ++i)
//}
//{
//    Console.WriteLine("Idade: ");
//    Console.WriteLine(idades[i]);
//}





//// Vetor - Arrays
//string[] nomes = new string[15];
//nomes = "Ingryd";
//nomes = "Karina';

// // Length - Largura - Quantidade
// for (int i = 0; i < nomes.Length; i++)
//{
//    Console.WriteLine("Informe o nome: ");
//    nomes[i] = Console.ReadLine();
//}


//    // 1 Listando vom for 
//for (int i = 0; i < nomes.Length; i++)
//    {
//        Console.WriteLine(nomes[i]);
//    }

//// 2 - Listando com foreach (para cada)
//foreach (var item in nomes)
//{
//    Console.WriteLine(item);
//}



//Crie um programa que declare um array de 5 números inteiros e utilize um laço de repetição para somar todos os valores. No final, exiba a soma na tela.




//int[] numerosInt = new int[5];

//for (int i = 0; i < numerosInt.Length; ++i)
//{
//    Console.WriteLine(" Por favor informe um numero: ");
//    numerosInt[i] = int.Parse(Console.ReadLine());
//}
//int soma = 0;
//for (int i = 0; i < numerosInt.Length; ++i)
//{
//    soma = numerosInt[i] + soma;
//}
//Console.WriteLine(soma);


//Crie um programa que declare um array de 5 números inteiros e utilize um laço de repetição para encontrar o maior número do array. No final, exiba o maior valor encontrado.

//int[] numerosMaior = new int[5];
//int MaiorNumero = 0;
//for (int i = 0; i < numerosMaior.Length; ++i)
//{
//    Console.WriteLine(" Por favor informe um numero: ");
//    numerosMaior[i] = int.Parse(Console.ReadLine());
//}
//    for (int i = 0; i < numerosMaior.Length; ++i)
//    {
//        if (numerosMaior[i] > MaiorNumero)
//        {
//            MaiorNumero = numerosMaior[i];
//        }

//    }

//    Console.WriteLine(MaiorNumero);

//Vamos criar um programa que gerencie uma **lista de notas de alunos** e calcule a média. O usuário poderá:

//1.Inserir as notas de um aluno. (Cada aluno tem 5 notas)





try
{
    
    int[] notas = new int[5];
    int soma = 0;
    int Media = 0;
    for (int i = 0; i < notas.Length; ++i)
    {
        Console.WriteLine(" Por favor informe a nota: ");
        notas[i] = int.Parse(Console.ReadLine());

        if (notas[i] < 0)
        {
            Console.WriteLine("Essa nota  não e valida. ");
        }
        if (notas[i] > 10)
        {
            Console.WriteLine("Essa nota não e valida");
        }
    }
    for (int i = 0; i < notas.Length; ++i)
    {
        Console.WriteLine(notas[i]);
    }
    for (int i = 0; i < notas.Length; ++i)
    {
        soma = notas[i] + soma;
    }
    Console.WriteLine(soma);

    Media = soma / notas.Length;

    Console.WriteLine("Sua media e: " + Media);

    if (Media > 7)
    {
        Console.WriteLine("Parabens, voce foi aprovado! ");
    }
    else
    {
        Console.WriteLine("Sinto muito, voce foi reprovado.");
    }

}
catch (FormatException ex)
{
    Console.WriteLine(" Apenas numeros são aceitos ");
}

