using System.Collections.Generic;

namespace ExemploColecoes.Helper
{
    public class OperacoesLista
    {
        public void ImprimirListaString(List<string> lista) //Apertar na lâmpada e using System.Collections.Generic.Lista
        {
            for (int i = 0; i < lista.Count; i++)
            {
                System.Console.WriteLine($"Índice {i}, Valor: {lista[i]}");
            }
        }
    }
}