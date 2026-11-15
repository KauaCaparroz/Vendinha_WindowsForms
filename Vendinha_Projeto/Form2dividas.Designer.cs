
namespace Vendinha_ProjetoWindowsForms
{
    partial class Form2dividas
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
            idcliente = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            valordivida = new TextBox();
            iddivida = new TextBox();
            btnCadastrarDivida = new Button();
            btnConsultarDividas = new Button();
            btnPagarDivida = new Button();
            gridDividas = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colValor = new DataGridViewTextBoxColumn();
            colData = new DataGridViewTextBoxColumn();
            colPaga = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridDividas).BeginInit();
            SuspendLayout();
            // 
            // idcliente
            // 
            idcliente.ForeColor = SystemColors.WindowText;
            idcliente.Location = new Point(477, 245);
            idcliente.MaximumSize = new Size(300, 100);
            idcliente.Name = "idcliente";
            idcliente.Size = new Size(200, 27);
            idcliente.TabIndex = 1;
            idcliente.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(229, 56);
            label1.Name = "label1";
            label1.Size = new Size(772, 81);
            label1.TabIndex = 2;
            label1.Text = "Gerenciamento de Dívidas";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(229, 231);
            label2.Name = "label2";
            label2.Size = new Size(195, 41);
            label2.TabIndex = 3;
            label2.Text = "Id do cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(229, 291);
            label3.Name = "label3";
            label3.Size = new Size(232, 41);
            label3.TabIndex = 4;
            label3.Text = "Valor da Dívida:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(229, 356);
            label4.Name = "label4";
            label4.Size = new Size(189, 41);
            label4.TabIndex = 5;
            label4.Text = "Id da Dívida:";
            // 
            // valordivida
            // 
            valordivida.ForeColor = SystemColors.WindowText;
            valordivida.Location = new Point(477, 305);
            valordivida.MaximumSize = new Size(300, 100);
            valordivida.Name = "valordivida";
            valordivida.Size = new Size(200, 27);
            valordivida.TabIndex = 6;
            // 
            // iddivida
            // 
            iddivida.ForeColor = SystemColors.WindowText;
            iddivida.Location = new Point(477, 370);
            iddivida.MaximumSize = new Size(300, 100);
            iddivida.Name = "iddivida";
            iddivida.Size = new Size(200, 27);
            iddivida.TabIndex = 7;
            // 
            // btnCadastrarDivida
            // 
            btnCadastrarDivida.BackColor = Color.DarkBlue;
            btnCadastrarDivida.ForeColor = SystemColors.ButtonHighlight;
            btnCadastrarDivida.Location = new Point(751, 245);
            btnCadastrarDivida.Name = "btnCadastrarDivida";
            btnCadastrarDivida.Size = new Size(200, 35);
            btnCadastrarDivida.TabIndex = 8;
            btnCadastrarDivida.Text = "Cadastrar Dívida";
            btnCadastrarDivida.UseVisualStyleBackColor = false;
            // 
            // btnConsultarDividas
            // 
            btnConsultarDividas.BackColor = Color.DarkBlue;
            btnConsultarDividas.ForeColor = SystemColors.ButtonHighlight;
            btnConsultarDividas.Location = new Point(751, 305);
            btnConsultarDividas.Name = "btnConsultarDividas";
            btnConsultarDividas.Size = new Size(200, 35);
            btnConsultarDividas.TabIndex = 9;
            btnConsultarDividas.Text = "Consultar Dívidas";
            btnConsultarDividas.UseVisualStyleBackColor = false;
            // 
            // btnPagarDivida
            // 
            btnPagarDivida.BackColor = Color.DarkBlue;
            btnPagarDivida.ForeColor = SystemColors.ButtonHighlight;
            btnPagarDivida.Location = new Point(751, 366);
            btnPagarDivida.Name = "btnPagarDivida";
            btnPagarDivida.Size = new Size(200, 35);
            btnPagarDivida.TabIndex = 10;
            btnPagarDivida.Text = "Pagar Dívida";
            btnPagarDivida.UseVisualStyleBackColor = false;
            // 
            // gridDividas
            // 
            gridDividas.BackgroundColor = SystemColors.ControlLight;
            gridDividas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDividas.Columns.AddRange(new DataGridViewColumn[] { colId, colCliente, colValor, colData, colPaga });
            gridDividas.Location = new Point(274, 445);
            gridDividas.Name = "gridDividas";
            gridDividas.RowHeadersWidth = 51;
            gridDividas.Size = new Size(677, 193);
            gridDividas.TabIndex = 11;
            // 
            // colId
            // 
            colId.HeaderText = "ID da dívida";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.Width = 125;
            // 
            // colCliente
            // 
            colCliente.HeaderText = "ID do cliente";
            colCliente.MinimumWidth = 6;
            colCliente.Name = "colCliente";
            colCliente.Width = 125;
            // 
            // colValor
            // 
            colValor.HeaderText = "Valor";
            colValor.MinimumWidth = 6;
            colValor.Name = "colValor";
            colValor.Width = 125;
            // 
            // colData
            // 
            colData.HeaderText = "Data de criação";
            colData.MinimumWidth = 6;
            colData.Name = "colData";
            colData.Width = 125;
            // 
            // colPaga
            // 
            colPaga.HeaderText = "Paga";
            colPaga.MinimumWidth = 6;
            colPaga.Name = "colPaga";
            colPaga.Width = 125;
            // 
            // Form2dividas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1342, 735);
            Controls.Add(gridDividas);
            Controls.Add(btnPagarDivida);
            Controls.Add(btnConsultarDividas);
            Controls.Add(btnCadastrarDivida);
            Controls.Add(iddivida);
            Controls.Add(valordivida);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(idcliente);
            Name = "Form2dividas";
            Text = "Form2dividas";
            Load += Form2dividas_Load;
            ((System.ComponentModel.ISupportInitialize)gridDividas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idcliente;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox valordivida;
        private TextBox iddivida;
        private Button btnCadastrarDivida;
        private Button btnConsultarDividas;
        private Button btnPagarDivida;
        private DataGridView gridDividas;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colValor;
        private DataGridViewTextBoxColumn colData;
        private DataGridViewTextBoxColumn colPaga;
    }
}
