using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trab
{
    [Serializable] // indicação para a classe poder ser serializada 
                   //Chamada de diretiva de compilação
    public class aaProduto
	{
		public int aaCodigo { get; private set; } // acessor. Leitura livre, alteração negada.
		public string aaDescricao { get; private set; }
		public DateTime aaData_fabricacao { get; private set; }
		public int aaQtde { get; private set; }
		public double aaPrecoUnitario { get; private set; }


		public void aaSetCodigo(int a)
		{//função para alterar o codigo
			this.aaCodigo = a;
		}

		public void aaSetDescricao(string a)
		{
			this.aaDescricao = a;
		}

		public void aaSetDataFabricacao(DateTime a)
		{
            if ((DateTime.Now.Date > a.Date) || (DateTime.Now.Date == a.Date))
            {
                this.aaData_fabricacao = a;
            }
            else throw new Exception("Data maior que a atual."); 
		}
		public void aaSetQtde(string a)
		{
            try
            {
                this.aaQtde = Convert.ToInt32(a);
            }
            catch (Exception) {  }
		}
		public void aaSetPrecoU(string a)
		{
            try
            {
                this.aaPrecoUnitario = Convert.ToDouble(a);
            }
            catch (Exception) { }
        }
		public int aaMeses() // metodo Meses
		{
			int aaMeses = 0;
			aaMeses = DateTime.Now.Year - this.aaData_fabricacao.Year ; // ve quantos anos foram

			aaMeses = aaMeses * 12; // multiplica os anos por 12 pra virar meses

            if (DateTime.Now.Month > this.aaData_fabricacao.Month) // se Mes atual menor que Mes guardado 
            {
                aaMeses = aaMeses + (DateTime.Now.Month - this.aaData_fabricacao.Month); // Mes mais a diferença entre
                // os meses ( atual e o guardado )
            }
			if ((DateTime.Now.Day < this.aaData_fabricacao.Day) || (DateTime.Now.Month > aaData_fabricacao.Month))// se dia atual menor que dia guardado
			{
					aaMeses--; // Meses menos 1
			}
			

			return (aaMeses);
		}
	}
}
