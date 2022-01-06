using System;
using System.Collections.Generic;
using ExemploColecoes.Helper;

namespace ExemploColecoes
{

   class Program
   {
      static void Main(string[] args)
      {

          int[] arrayNumeros = new int[7] { 100,  1,  4,  0, 8, 15, 19 };

          var minino = arrayNumeros.Min();
          var maximo = arrayNumeros.Max();
          var medio = arrayNumeros.Average();

           System.Console.WriteLine($"Minino: {minino}");
           System.Console.WriteLine($"Maximo: {maximo}");
            System.Console.WriteLine($"Medio: {medio}");




         //  var numerosParesQuery = 
         //         from num in arrayNumeros 
         //         where num % 2 == 0 
         //         orderby num 
         //         select num;


         //  var numerosParesMetado = arrayNumeros.Where(x =>  x % 2 == 0).OrderBy(x => x).ToList();

         //  System.Console.WriteLine("números pares query:" + string.Join(", ", numerosParesQuery));
         //  System.Console.WriteLine("números pares métado:" + string.Join(", ", numerosParesMetado));

         //Declarar Dicionario em C#
         //  Dictionary<string, string> estados = new Dictionary<string, string>();

         //  estados.Add("SP", "São Paulo");
         //  estados.Add("GO", "Goiàs");
         //  estados.Add("SC", "Santa Catarina");

         //  foreach (KeyValuePair<string, string> item in estados)
         //  {
         //     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
         //  }




         //LIFO o ultimo a chegar na fila o primeiro a ser atendido  Pilha
         //  Stack<string> pilhaLivros = new Stack<string>();

         //  pilhaLivros.Push(".NET");
         //  pilhaLivros.Push("C#");
         //  pilhaLivros.Push("Código limpo");

         //  System.Console.WriteLine($"Livros para leitura: {pilhaLivros.Count}");
         //  while (pilhaLivros.Count  >  0)
         //  {
         //     System.Console.WriteLine($"Próximo livro para leitura: {pilhaLivros.Peek()}");
         //     System.Console.WriteLine($"{pilhaLivros.Pop()} Lido com sucesso");
         //     }
         //     System.Console.WriteLine(($"Livros para leitura: {pilhaLivros.Count}"));
         //  }





         //FIFO o primeiro a chegar na fila o primeiro a ser atendido  Fila
         //  Queue<string> fila = new Queue<string>();
         //  fila.Enqueue("Sel");
         //  fila.Enqueue("Brenna");
         //  fila.Enqueue("Thuanna");

         //  while (fila.Count > 0)
         //  {
         //      System.Console.WriteLine($"Pessoas na fila: {fila.Peek()}");
         //     System.Console.WriteLine($"{fila.Dequeue()} atendido");  
         //  }

         //  System.Console.WriteLine($"Pessoas na fila: {fila.Count}");







         //Listas - Obs. List (ctrl +ponto e listar )
         //  OperacoesLista opLista = new OperacoesLista();
         //  List<string> estados = new List<string>{ "SP", "SC", "GO" };    //Apertar na lâmpada e using System.Collections.Generic.List na List
         //  string[] estadosArray = new string[2] { "MG", "MT" };
         // //  estados.Add("SP");
         // //  estados.Add("SC");
         // //  estados.Add("GO");

         //  System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

         //  opLista.ImprimirListaString(estados);

         //  //  System.Console.WriteLine("Removendo o elemento");
         //  //  estados.Remove("SP");

         //  estados.Insert(1, "RJ");

         //  opLista.ImprimirListaString(estados);







         //OperacoesArray - Inicio 
         //  OperacoesArray op = new OperacoesArray();
         //  int[] array = new int[5] { 6, 3, 8, 1, 9 };
         //  int[] arrayCopia = new int[10];

         //  int valorProcurado = 8;



         //Redirecionar um array, usando o  Array.Resize
         //  System.Console.WriteLine($"Capacidade atual do array: {array.Length}");
         //  op.RedimesionarArray(ref array, array.Length * 2);

         //  System.Console.WriteLine($"Capacidade atual do array após redimensionar: {array.Length}");



         //ìndice de array, usando o indexOf
         //  int Índice = op.ObterIndice(array, valorProcurado);
         //  if (Índice > -1) 
         //  {
         //      System.Console.WriteLine("O índice do elemento {0} é: {1}", valorProcurado, Índice);
         //  }
         //  else
         //  {
         //      System.Console.WriteLine("O valor não existente no array. ");
         //  }



         //Obter um valor com array, usando Array.Find
         //  int valorAchado = op.ObterValor(array, valorProcurado);

         //  if (valorAchado > 0)
         //  {
         //      System.Console.WriteLine("Encontrei o valor:");
         //  }

         //  else
         //  {
         //      System.Console.WriteLine("Não encontrei o valor:");
         //  }



         //Array bool, usando Array.ForAll
         //  bool todosMaiorQue = op.TodoMaiorQue(array, valorProcurado);

         //  if (todosMaiorQue)
         //  {
         //      System.Console.WriteLine("Todos os valores são maiores que {0}", valorProcurado);
         //  }
         //  else
         //  {
         //      System.Console.WriteLine("Existem valores maiores que {0}", valorProcurado);
         //  }


         // Array com bool Array.Exists
         //  bool existe = op.Existe(array, valorProcurado);

         //  if (existe)
         //  {
         //      System.Console.WriteLine("Encontrei o valor: {0}", valorProcurado);
         //  }
         // else
         // {
         //     System.Console.WriteLine("Não encontrei o valor: {0}", valorProcurado);
         // }


         //Array com BubbleSort, ordenar array
         // System.Console.WriteLine("Array original:");
         //op.ImprimirArray(array);

         //op.OrdenarBubbleSort(ref array);
         // op.Ordenar(ref array);

         //System.Console.WriteLine("Array ordenado;");
         //op.ImprimirArray(array);


         //Copiando array com Array.Copy
         //  System.Console.WriteLine("Array antes da cópia;");
         // op.ImprimirArray(arrayCopia);

         //  op.Copiar(ref array, ref arrayCopia);

         //  System.Console.WriteLine("Array após a cópia;");
         //  op.ImprimirArray(arrayCopia);



         //Linhas de array com string.Join
         // int[,] matriz = new int[4, 2]
         // {
         //    {8,8},
         //    { 10, 20},
         //    {50, 100},
         //     {90, 200}
         // };
         // for (int i = 0; i < matriz.GetLength(0);  i++)
         // {
         //     for (int j = 0; j < matriz.GetLength(1);  j++)
         //     {
         //             System.Console.WriteLine(matriz[i, j]);
         //     }
         // }
         // int[] arrayInteiros = new int[3];
         // arrayInteiros[0] = 10;
         // arrayInteiros[1] = 20;
         // arrayInteiros[2] = 30;



         //Imprimir array usando o For e ForEach
         // System.Console.WriteLine("Percorrendo o arry pelo For");
         // for (int i = 0; i < arrayInteiros.Length; i++)   //for loop (C#) e tab p/ completar
         // {
         //    System.Console.WriteLine(arrayInteiros[i]);
         // }
         // System.Console.WriteLine("Percorrendo o array pelo ForEach");
         // foreach (int item in arrayInteiros) //foreach statement  e tab p/  completar
         // {
         //     System.Console.WriteLine(item);
      }
   }
}



