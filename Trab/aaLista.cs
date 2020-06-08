using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Trab
{
	public static class aaLista
	{
		public static List<aaProduto> aaItens;
        private static string nomeArq;

		static aaLista() // construtor
		{
			aaItens = new List<aaProduto>(); // instancia os itens
            nomeArq = "dados787.aaa";
		}

        public static void ler() // le o arq binario
        {
            FileStream fs; // objeto arquivo binário
            BinaryFormatter bf;
            try
            {
                fs = new FileStream(nomeArq, FileMode.Open); //abre o arquivo
                bf = new BinaryFormatter();// cria o objeto de serialização
                aaItens = (List<aaProduto>)bf.Deserialize(fs); // le do arquivo e cola 
                // os dados na lista
                fs.Close(); // fecha o arquivo
            }
            catch (Exception) { }
        }

        public static void gravar() // grava no arq binario
        {
            FileStream fs; // objeto arquivo binário
            BinaryFormatter bf;
            try
            {
                fs = new FileStream(nomeArq, FileMode.Create);
                bf = new BinaryFormatter();
                bf.Serialize(fs, aaItens);
                fs.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar: " + ex.Message);
            }
        }

		public static bool aaBusca(int cod, out int pos)
		{// Busca na Lista o indice do item que tem o cod desejado
			int i;
			bool achou = false;

			pos = -1; // pos precisa ter algum valor

			for (i = 0; i < aaLista.aaItens.Count; i++) // roda a lista
			{
				if (aaLista.aaItens[i].aaCodigo == cod) // testa se tem o cod desejado e devolve o indice dele
				{
					pos = i;
					achou = true;
					break;
				}
			}
			return (achou);
		}

		public static void remove(int cod)
		{
			int i;
			for (i = 0; i < aaItens.Count; i++)
			{
				if (aaItens[i].aaCodigo == cod)
					break;
			}
			if (i < aaItens.Count)
				aaItens.RemoveAt(i);
			else
				throw new Exception("Elemento não encontrado.");
		}
	}
}
