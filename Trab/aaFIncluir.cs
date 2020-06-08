using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trab
{
	public partial class aaFIncluir : Form
	{
		public bool aaCondicao;
		public aaFIncluir()
		{
			InitializeComponent();

		}

		private void aaBtnIncluir_Click(object sender, EventArgs e)
		{
			aaProduto aaObj;

			aaCondicao = true;

			if (codRepetido())
			{

				try // testa se a conversão é possível
				{
					aaObj = new aaProduto(); // instancia um noov obj
					aaObj.aaSetCodigo(Convert.ToInt32(this.txtCodigo.Text)); // chama a função para mudar a Descr
					aaObj.aaSetDescricao(this.txtDescri.Text);
					aaObj.aaSetQtde(this.txtQtd.Text);
					aaObj.aaSetPrecoU(this.txtPrecoU.Text);
					aaObj.aaSetDataFabricacao(this.dtpDataFabric.Value);

					aaLista.aaItens.Add(aaObj); // adiciona na classe Lista
					aaLista.gravar(); // grava no arquivo binário

					this.txtCodigo.Clear(); // limpa o textbox
					this.txtDescri.Clear();
					this.txtPrecoU.Clear();
					this.txtQtd.Clear();
					this.txtCodigo.Focus(); // coloca o foco no textbox

					MessageBox.Show("Cadastrado"); // Mostra em um pop-up a mensagem Cadastrado

				}
				catch (Exception ex) { MessageBox.Show(ex.Message); } // mensagem de erro caso a conversão
																	  // não tenha dado certo
			}

		}

		private void btnFechar_Click(object sender, EventArgs e)
		{ // fecha o formulario
			this.Close();
		}

		private bool codRepetido()
		{
			int aaCodigo;

			aaCondicao = true;

			try
			{// ve se tem código repetido
				int aaCodMaior = aaLista.aaItens[0].aaCodigo;
				aaCodigo = Convert.ToInt32(this.txtCodigo.Text); // Codigo que a pessoa acabou de escrever


				for (int i = 0; i < aaLista.aaItens.Count; i++) // ve o maior codigo da lista e atribui a variavel
				{
					if (aaCodMaior < aaLista.aaItens[i].aaCodigo)
						aaCodMaior = aaLista.aaItens[i].aaCodigo;
				}

				for (int i = 0; i < aaLista.aaItens.Count; i++) // ve se existe codigo repetido e defini um maior
				{
					if (aaCodigo == aaLista.aaItens[i].aaCodigo) // tenta achar um cod igual e, caso exista,
						// ele oferece o codigo novo
					{
						aaCodMaior++;
						MessageBox.Show("O código (" + aaCodigo + ") já existe." +
						Environment.NewLine + "Tente um código válido como: " + aaCodMaior);

						this.txtCodigo.Text = Convert.ToString(aaCodMaior);
						this.txtDescri.Focus();
						aaCondicao = false;
						break;
					}
				}

			}

			catch (Exception) { }

			return (aaCondicao);
		}

		private void btnAlterar_Click(object sender, EventArgs e)
		{
			int aaPos;
			int aaCod;

			bool erro = true;

			if (Int32.TryParse(this.txtCodigo.Text.Trim(), out aaCod)) // tenta converter
			{
				if (aaLista.aaBusca(aaCod, out aaPos)) // usa a função busca 
				{
                    try
                    {
                        aaLista.aaItens[aaPos].aaSetDescricao(this.txtDescri.Text); // altera os valores na Lista
                        aaLista.aaItens[aaPos].aaSetPrecoU(this.txtPrecoU.Text);
                        aaLista.aaItens[aaPos].aaSetQtde(this.txtQtd.Text);
                        aaLista.aaItens[aaPos].aaSetDataFabricacao(this.dtpDataFabric.Value);
                        MessageBox.Show("Dados alterados com sucesso.");

                        aaLista.gravar();
                    }
                    catch (Exception ex) { MessageBox.Show("Erro ao alterar." +Environment.NewLine + ex.Message); }
                    

					this.txtCodigo.Clear(); // limpa os textbox no formulario
					this.txtDescri.Clear();
					this.txtPrecoU.Clear();
					this.txtQtd.Clear();
					this.dtpDataFabric.Value = DateTime.Now; // muda a data do dtp no furmulario
				}
			}

		}

		private void txtCodigo_Leave(object sender, EventArgs e)
		{
			int pos;
			int cod;

			try
			{
				cod = Convert.ToInt32(this.txtCodigo.Text); 
				if (aaLista.aaBusca(cod, out pos)) // busca o indice na Lista do codigo desejado e coloca os seus valores
					// nos textbox
				{
					this.txtDescri.Text = aaLista.aaItens[pos].aaDescricao;
					this.txtPrecoU.Text = aaLista.aaItens[pos].aaPrecoUnitario.ToString();
					this.txtQtd.Text = aaLista.aaItens[pos].aaQtde.ToString();
					this.dtpDataFabric.Value = aaLista.aaItens[pos].aaData_fabricacao;
				}
			}
			catch (Exception) { } // não faz nada
		}

		private void btnRemover_Click(object sender, EventArgs e)
		{
			int cod;
			try
			{
				cod = Convert.ToInt32(this.txtCodigo.Text);
				aaLista.remove(cod);
				MessageBox.Show("Removido com sucesso.");
				this.txtCodigo.Clear();
                this.txtDescri.Clear();
                this.txtPrecoU.Clear();
                this.txtQtd.Clear();
				this.txtCodigo.Focus();
                this.dtpDataFabric.Value = DateTime.Now;

                aaLista.gravar(); // salva na Lista
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}
	}
}
