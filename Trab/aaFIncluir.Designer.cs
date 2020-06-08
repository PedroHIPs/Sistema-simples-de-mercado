namespace Trab
{
	partial class aaFIncluir
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnIncluir = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.txtDescri = new System.Windows.Forms.TextBox();
			this.txtQtd = new System.Windows.Forms.TextBox();
			this.txtPrecoU = new System.Windows.Forms.TextBox();
			this.dtpDataFabric = new System.Windows.Forms.DateTimePicker();
			this.btnFechar = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnRemover = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnIncluir
			// 
			this.btnIncluir.Location = new System.Drawing.Point(254, 290);
			this.btnIncluir.Name = "btnIncluir";
			this.btnIncluir.Size = new System.Drawing.Size(99, 32);
			this.btnIncluir.TabIndex = 0;
			this.btnIncluir.Text = "Incluir";
			this.btnIncluir.UseVisualStyleBackColor = true;
			this.btnIncluir.Click += new System.EventHandler(this.aaBtnIncluir_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(26, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Código";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(21, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Descrição";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(17, 157);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "Quantidade";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(367, 74);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(114, 15);
			this.label4.TabIndex = 4;
			this.label4.Text = "Data de Fabricação";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(13, 197);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 15);
			this.label5.TabIndex = 5;
			this.label5.Text = "Preço Unitario";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(104, 64);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(177, 20);
			this.txtCodigo.TabIndex = 6;
			this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
			// 
			// txtDescri
			// 
			this.txtDescri.Location = new System.Drawing.Point(104, 108);
			this.txtDescri.Name = "txtDescri";
			this.txtDescri.Size = new System.Drawing.Size(177, 20);
			this.txtDescri.TabIndex = 7;
			// 
			// txtQtd
			// 
			this.txtQtd.Location = new System.Drawing.Point(104, 152);
			this.txtQtd.Name = "txtQtd";
			this.txtQtd.Size = new System.Drawing.Size(177, 20);
			this.txtQtd.TabIndex = 8;
			// 
			// txtPrecoU
			// 
			this.txtPrecoU.Location = new System.Drawing.Point(104, 196);
			this.txtPrecoU.Name = "txtPrecoU";
			this.txtPrecoU.Size = new System.Drawing.Size(177, 20);
			this.txtPrecoU.TabIndex = 9;
			// 
			// dtpDataFabric
			// 
			this.dtpDataFabric.CustomFormat = "dd-MM-yyyy";
			this.dtpDataFabric.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDataFabric.Location = new System.Drawing.Point(487, 73);
			this.dtpDataFabric.Name = "dtpDataFabric";
			this.dtpDataFabric.Size = new System.Drawing.Size(94, 20);
			this.dtpDataFabric.TabIndex = 10;
			// 
			// btnFechar
			// 
			this.btnFechar.Location = new System.Drawing.Point(382, 290);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(99, 32);
			this.btnFechar.TabIndex = 12;
			this.btnFechar.Text = "Fechar ";
			this.btnFechar.UseVisualStyleBackColor = true;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// btnAlterar
			// 
			this.btnAlterar.Location = new System.Drawing.Point(370, 129);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(99, 32);
			this.btnAlterar.TabIndex = 13;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.UseVisualStyleBackColor = true;
			this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
			// 
			// btnRemover
			// 
			this.btnRemover.Location = new System.Drawing.Point(487, 129);
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.Size = new System.Drawing.Size(94, 32);
			this.btnRemover.TabIndex = 14;
			this.btnRemover.Text = "Remover";
			this.btnRemover.UseVisualStyleBackColor = true;
			this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
			// 
			// aaFIncluir
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(748, 374);
			this.Controls.Add(this.btnRemover);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.dtpDataFabric);
			this.Controls.Add(this.txtPrecoU);
			this.Controls.Add(this.txtQtd);
			this.Controls.Add(this.txtDescri);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnIncluir);
			this.Name = "aaFIncluir";
			this.Text = "Incluir";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnIncluir;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnFechar;
		public System.Windows.Forms.TextBox txtCodigo;
		public System.Windows.Forms.TextBox txtDescri;
		public System.Windows.Forms.TextBox txtQtd;
		public System.Windows.Forms.TextBox txtPrecoU;
		public System.Windows.Forms.DateTimePicker dtpDataFabric;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Button btnRemover;
	}
}