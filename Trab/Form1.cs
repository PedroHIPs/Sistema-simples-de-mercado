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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
            aaLista.ler(); 
		}

		private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Environment.Exit(0); // fecha o programa
		}

		private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
		{// abre o formulario Incluir.
			aaFIncluir f;
			f = new aaFIncluir();


			f.ShowDialog(); // abre o form e interrompe a execução, modo modal.

		}

		private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			aaFConsultar f;
			f = new aaFConsultar();

			f.Show(); // abre o form

		}
	}
}
