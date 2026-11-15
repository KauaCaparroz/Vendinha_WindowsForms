namespace Vendinha_ProjetoWindowsForms
{
    partial class Form3Clientes
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
            label1 = new Label();
            textPesquisa = new TextBox();
            btnPesquisar = new Button();
            gridClientes = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colIdade = new DataGridViewTextBoxColumn();
            colTotalDevido = new DataGridViewTextBoxColumn();
            btnAnterior = new Button();
            btnProximo = new Button();
            btnEditarCliente = new Button();
            btnExcluirCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)gridClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(375, 61);
            label1.Name = "label1";
            label1.Size = new Size(663, 81);
            label1.TabIndex = 0;
            label1.Text = "CONSULTAR CLIENTES";
            // 
            // textPesquisa
            // 
            textPesquisa.Location = new Point(351, 205);
            textPesquisa.Multiline = true;
            textPesquisa.Name = "textPesquisa";
            textPesquisa.PlaceholderText = "Nome do cliente";
            textPesquisa.Size = new Size(431, 40);
            textPesquisa.TabIndex = 1;
            textPesquisa.TextChanged += textPesquisa_TextChanged;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(769, 205);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(135, 40);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // gridClientes
            // 
            gridClientes.AllowUserToAddRows = false;
            gridClientes.BackgroundColor = SystemColors.ControlLight;
            gridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClientes.Columns.AddRange(new DataGridViewColumn[] { colId, colNome, colIdade, colTotalDevido });
            gridClientes.Location = new Point(351, 247);
            gridClientes.Name = "gridClientes";
            gridClientes.ReadOnly = true;
            gridClientes.RowHeadersWidth = 51;
            gridClientes.Size = new Size(553, 355);
            gridClientes.TabIndex = 3;
            gridClientes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 125;
            // 
            // colNome
            // 
            colNome.HeaderText = "Nome";
            colNome.MinimumWidth = 6;
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            colNome.Width = 125;
            // 
            // colIdade
            // 
            colIdade.HeaderText = "Idade";
            colIdade.MinimumWidth = 6;
            colIdade.Name = "colIdade";
            colIdade.ReadOnly = true;
            colIdade.Width = 125;
            // 
            // colTotalDevido
            // 
            colTotalDevido.HeaderText = "Total devido";
            colTotalDevido.MinimumWidth = 6;
            colTotalDevido.Name = "colTotalDevido";
            colTotalDevido.ReadOnly = true;
            colTotalDevido.Width = 125;
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = Color.DarkBlue;
            btnAnterior.ForeColor = Color.White;
            btnAnterior.Location = new Point(351, 608);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(164, 29);
            btnAnterior.TabIndex = 4;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = false;
            // 
            // btnProximo
            // 
            btnProximo.BackColor = Color.DarkBlue;
            btnProximo.ForeColor = Color.White;
            btnProximo.Location = new Point(740, 608);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(164, 29);
            btnProximo.TabIndex = 5;
            btnProximo.Text = "Próximo";
            btnProximo.UseVisualStyleBackColor = false;
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.BackColor = Color.DarkBlue;
            btnEditarCliente.ForeColor = Color.White;
            btnEditarCliente.Location = new Point(910, 365);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(164, 48);
            btnEditarCliente.TabIndex = 6;
            btnEditarCliente.Text = "Editar Cliente";
            btnEditarCliente.UseVisualStyleBackColor = false;
            btnEditarCliente.Click += btnEditarCliente_Click;
            // 
            // btnExcluirCliente
            // 
            btnExcluirCliente.BackColor = Color.DarkBlue;
            btnExcluirCliente.ForeColor = Color.White;
            btnExcluirCliente.Location = new Point(910, 431);
            btnExcluirCliente.Name = "btnExcluirCliente";
            btnExcluirCliente.Size = new Size(164, 48);
            btnExcluirCliente.TabIndex = 7;
            btnExcluirCliente.Text = "Excluir Cliente";
            btnExcluirCliente.UseVisualStyleBackColor = false;
            btnExcluirCliente.Click += btnExcluirCliente_Click;
            // 
            // Form3Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1317, 754);
            Controls.Add(btnExcluirCliente);
            Controls.Add(btnEditarCliente);
            Controls.Add(btnProximo);
            Controls.Add(btnAnterior);
            Controls.Add(gridClientes);
            Controls.Add(btnPesquisar);
            Controls.Add(textPesquisa);
            Controls.Add(label1);
            Name = "Form3Clientes";
            Text = "Form3Clientes";
            Load += Form3Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)gridClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textPesquisa;
        private Button btnPesquisar;
        private DataGridView gridClientes;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colIdade;
        private DataGridViewTextBoxColumn colTotalDevido;
        private Button btnAnterior;
        private Button btnProximo;
        private Button btnEditarCliente;
        private Button btnExcluirCliente;
    }
}