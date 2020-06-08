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
	public partial class aaFConsultar : Form
	{
		public aaFConsultar()
		{
			InitializeComponent();
			aaMostrar();
		}

		public void aaMostrar()
		{// funcao que mostra todos os itens da lista

            int aaContador = 0;

			this.lstItens.Items.Clear();

			

			for (int i = 0; i < aaLista.aaItens.Count(); i++)
			{
				this.lstItens.Items.Add(aaLista.aaItens[i].aaCodigo + "  "
					+ aaLista.aaItens[i].aaDescricao + "  "
					+ aaLista.aaItens[i].aaQtde + "  R$"
					+ aaLista.aaItens[i].aaPrecoUnitario + "  Meses: "
					+ aaLista.aaItens[i].aaMeses());
				aaContador = aaContador + aaLista.aaItens[i].aaQtde;

			}
            this.txtProdutos.Text = Convert.ToString(aaContador);
        }

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			aaBusca();
		}

		public void aaBusca()
		{// metodo para buscar no Listbox
			int aux;

			int aacontador = 0;

			bool aaCerto;

			this.lstItens.Items.Clear(); // limpa o lst


			for (int i = 0; i < aaLista.aaItens.Count; i++) // percorre a Lista
			{
				aaCerto = true;

				if (this.txtCodigo.Text.Trim().Length > 0) // se na Lista algum iten tiver com essa descrição ele guarda no aaCerto
					aaCerto = aaCerto && (aaLista.aaItens[i].aaDescricao.Contains(this.txtCodigo.Text));

				if (int.TryParse(this.txtCodigo.Text, out aux)) // se na Lista algum iten tiver com esse codigo ele guarda no aaCerto
					aaCerto = aaCerto && (aaLista.aaItens[i].aaCodigo == aux);

				if (aaCerto)
				{// escreve no listbox.
					this.lstItens.Items.Add(aaLista.aaItens[i].aaCodigo + "  "
						+ aaLista.aaItens[i].aaDescricao + "  "
						+ aaLista.aaItens[i].aaQtde + "  R$"
						+ aaLista.aaItens[i].aaPrecoUnitario + "  Meses: "
						+ aaLista.aaItens[i].aaMeses());
					aacontador = aacontador + aaLista.aaItens[i].aaQtde;

				}
			}
			this.txtProdutos.Text = Convert.ToString(aacontador); // mostra o total de produtos
		}

		private void lstItens_DoubleClick(object sender, EventArgs e)
		{
			aaFIncluir f;
			int aaPos;

			f = new aaFIncluir();
			aaPos = this.lstItens.SelectedIndex;

			if (aaPos >= 0)
			{
				f.txtCodigo.Text = aaLista.aaItens[aaPos].aaCodigo.ToString();
				f.txtDescri.Text = aaLista.aaItens[aaPos].aaDescricao.ToString(); ;
				f.txtPrecoU.Text = aaLista.aaItens[aaPos].aaPrecoUnitario.ToString(); ;
				f.txtQtd.Text = aaLista.aaItens[aaPos].aaQtde.ToString(); ;
				f.dtpDataFabric.Value = aaLista.aaItens[aaPos].aaData_fabricacao;
				this.Close();
				f.Show();
			}
		}

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            btnBuscar.PerformClick();
        }
    }
}
