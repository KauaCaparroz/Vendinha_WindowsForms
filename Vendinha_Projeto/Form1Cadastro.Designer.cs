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
            textNome = new TextBox();
            VENDINHA = new Label();
            textCPF = new TextBox();
            textDATADENASCIMENTO = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textEMAIL = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_cadastrar = new Button();
            dateTimePicker1 = new DateTimePicker();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            SuspendLayout();
            // 
            // textNome
            // 
            textNome.Font = new Font("Segoe UI", 15F);
            textNome.Location = new Point(345, 192);
            textNome.Name = "textNome";
            textNome.Size = new Size(370, 41);
            textNome.TabIndex = 0;
            textNome.TextChanged += textBox1_TextChanged;
            // 
            // VENDINHA
            // 
            VENDINHA.AutoSize = true;
            VENDINHA.Font = new Font("Gill Sans Ultra Bold", 34.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VENDINHA.Location = new Point(319, 28);
            VENDINHA.Name = "VENDINHA";
            VENDINHA.Size = new Size(419, 79);
            VENDINHA.TabIndex = 1;
            VENDINHA.Text = "VENDINHA";
            VENDINHA.Click += label1_Click;
            // 
            // textCPF
            // 
            textCPF.Font = new Font("Segoe UI", 15F);
            textCPF.Location = new Point(345, 274);
            textCPF.Name = "textCPF";
            textCPF.Size = new Size(370, 41);
            textCPF.TabIndex = 2;
            // 
            // textDATADENASCIMENTO
            // 
            textDATADENASCIMENTO.Font = new Font("Segoe UI", 15F);
            textDATADENASCIMENTO.Location = new Point(345, 361);
            textDATADENASCIMENTO.Name = "textDATADENASCIMENTO";
            textDATADENASCIMENTO.Size = new Size(370, 41);
            textDATADENASCIMENTO.TabIndex = 3;
            textDATADENASCIMENTO.TextChanged += textDATADENASCIMENTO_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(384, 123);
            label1.Name = "label1";
            label1.Size = new Size(290, 30);
            label1.TabIndex = 4;
            label1.Text = "Preencha suas informações:";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumAquamarine;
            label2.Location = new Point(345, 169);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 5;
            label2.Text = "Nome";
            label2.Click += label2_Click;
            // 
            // textEMAIL
            // 
            textEMAIL.Font = new Font("Segoe UI", 15F);
            textEMAIL.Location = new Point(345, 441);
            textEMAIL.Name = "textEMAIL";
            textEMAIL.Size = new Size(370, 41);
            textEMAIL.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumAquamarine;
            label3.Location = new Point(345, 251);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 9;
            label3.Text = "CPF";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MediumAquamarine;
            label4.Location = new Point(345, 338);
            label4.Name = "label4";
            label4.Size = new Size(145, 20);
            label4.TabIndex = 10;
            label4.Text = "Data de Nascimento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MediumAquamarine;
            label5.Location = new Point(345, 418);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 11;
            label5.Text = "Email(opcional)";
            label5.Click += label5_Click;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(422, 517);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(208, 40);
            btn_cadastrar.TabIndex = 12;
            btn_cadastrar.Text = "CADASTRAR";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(345, 371);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(370, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // Form1Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(1587, 749);
            Controls.Add(dateTimePicker1);
            Controls.Add(btn_cadastrar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textEMAIL);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textDATADENASCIMENTO);
            Controls.Add(textCPF);
            Controls.Add(VENDINHA);
            Controls.Add(textNome);
            Name = "Form1Cadastro";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNome;
        private Label VENDINHA;
        private TextBox textCPF;
        private TextBox textDATADENASCIMENTO;
        private Label label1;
        private Label label2;
        private TextBox textEMAIL;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_cadastrar;
        private DateTimePicker dateTimePicker1;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
    }
}
