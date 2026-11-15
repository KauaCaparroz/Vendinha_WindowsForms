namespace Vendinha_Projeto
{
    partial class Form1Cadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1Cadastro));
            textNome = new TextBox();
            textCPF = new TextBox();
            textDATADENASCIMENTO = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textEMAIL = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_cadastrar = new Button();
            dtpNascimento = new DateTimePicker();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            imageList1 = new ImageList(components);
            pictureBox2 = new PictureBox();
            label6 = new Label();
            btnGerenciarDividas = new Button();
            btnConsultarClientes = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textNome
            // 
            textNome.BackColor = Color.White;
            textNome.BorderStyle = BorderStyle.None;
            textNome.Font = new Font("Segoe UI", 15F);
            textNome.Location = new Point(820, 443);
            textNome.Name = "textNome";
            textNome.Size = new Size(370, 34);
            textNome.TabIndex = 0;
            textNome.TextChanged += textBox1_TextChanged;
            // 
            // textCPF
            // 
            textCPF.BorderStyle = BorderStyle.None;
            textCPF.Font = new Font("Segoe UI", 15F);
            textCPF.Location = new Point(820, 503);
            textCPF.Name = "textCPF";
            textCPF.Size = new Size(370, 34);
            textCPF.TabIndex = 2;
            textCPF.TextChanged += textCPF_TextChanged;
            // 
            // textDATADENASCIMENTO
            // 
            textDATADENASCIMENTO.BackColor = SystemColors.InactiveCaption;
            textDATADENASCIMENTO.Font = new Font("Segoe UI", 15F);
            textDATADENASCIMENTO.Location = new Point(820, 563);
            textDATADENASCIMENTO.Name = "textDATADENASCIMENTO";
            textDATADENASCIMENTO.Size = new Size(370, 41);
            textDATADENASCIMENTO.TabIndex = 3;
            textDATADENASCIMENTO.TextChanged += textDATADENASCIMENTO_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Lucida Bright", 13F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(820, 358);
            label1.Name = "label1";
            label1.Size = new Size(328, 27);
            label1.TabIndex = 4;
            label1.Text = "Preencha suas informações:";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RoyalBlue;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(820, 420);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 5;
            label2.Text = "Nome";
            label2.Click += label2_Click;
            // 
            // textEMAIL
            // 
            textEMAIL.BorderStyle = BorderStyle.None;
            textEMAIL.Font = new Font("Segoe UI", 15F);
            textEMAIL.Location = new Point(820, 630);
            textEMAIL.Name = "textEMAIL";
            textEMAIL.Size = new Size(370, 34);
            textEMAIL.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RoyalBlue;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(820, 480);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 9;
            label3.Text = "CPF";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.RoyalBlue;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(820, 540);
            label4.Name = "label4";
            label4.Size = new Size(145, 20);
            label4.TabIndex = 10;
            label4.Text = "Data de Nascimento";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.RoyalBlue;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(820, 607);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 11;
            label5.Text = "Email(opcional)";
            label5.Click += label5_Click;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_cadastrar.ForeColor = Color.MidnightBlue;
            btn_cadastrar.Location = new Point(890, 709);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(210, 59);
            btn_cadastrar.TabIndex = 12;
            btn_cadastrar.Text = "CADASTRAR";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += button1_Click;
            // 
            // dtpNascimento
            // 
            dtpNascimento.CalendarForeColor = SystemColors.ActiveCaptionText;
            dtpNascimento.CalendarMonthBackground = SystemColors.ControlLightLight;
            dtpNascimento.Location = new Point(820, 573);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(370, 27);
            dtpNascimento.TabIndex = 13;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(549, 41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(859, 210);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Lucida Bright", 13F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(855, 309);
            label6.Name = "label6";
            label6.Size = new Size(245, 27);
            label6.TabIndex = 16;
            label6.Text = "CADASTRO CLIENTE";
            label6.Click += label6_Click;
            // 
            // btnGerenciarDividas
            // 
            btnGerenciarDividas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGerenciarDividas.ForeColor = Color.MidnightBlue;
            btnGerenciarDividas.Location = new Point(820, 801);
            btnGerenciarDividas.Name = "btnGerenciarDividas";
            btnGerenciarDividas.Size = new Size(370, 59);
            btnGerenciarDividas.TabIndex = 17;
            btnGerenciarDividas.Text = "GERENCIAR DÍVIDAS";
            btnGerenciarDividas.UseVisualStyleBackColor = true;
            // 
            // btnConsultarClientes
            // 
            btnConsultarClientes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConsultarClientes.ForeColor = Color.MidnightBlue;
            btnConsultarClientes.Location = new Point(820, 876);
            btnConsultarClientes.Name = "btnConsultarClientes";
            btnConsultarClientes.Size = new Size(370, 59);
            btnConsultarClientes.TabIndex = 18;
            btnConsultarClientes.Text = "Consultar Clientes";
            btnConsultarClientes.UseVisualStyleBackColor = true;
            btnConsultarClientes.Click += btnConsultarClientes_Click;
            // 
            // Form1Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1873, 947);
            Controls.Add(btnConsultarClientes);
            Controls.Add(btnGerenciarDividas);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(dtpNascimento);
            Controls.Add(btn_cadastrar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textEMAIL);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textDATADENASCIMENTO);
            Controls.Add(textCPF);
            Controls.Add(textNome);
            Name = "Form1Cadastro";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNome;
        private TextBox textCPF;
        private TextBox textDATADENASCIMENTO;
        private Label label1;
        private Label label2;
        private TextBox textEMAIL;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_cadastrar;
        private DateTimePicker dtpNascimento;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private ImageList imageList1;
        private PictureBox pictureBox2;
        private Label label6;
        private Button btnGerenciarDividas;
        private Button btnConsultarClientes;
    }
}
