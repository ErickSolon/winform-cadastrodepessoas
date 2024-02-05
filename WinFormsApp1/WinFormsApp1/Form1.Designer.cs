namespace WinFormsApp1
{
    partial class Form1
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
            TabelaDePessoas = new DataGridView();
            LabelNome = new Label();
            LabelSobrenome = new Label();
            LabelIdade = new Label();
            NomeInput = new TextBox();
            SobrenomeInput = new TextBox();
            IdadeInput = new TextBox();
            BotaoCadastroPessoa = new Button();
            DeletarCheck = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)TabelaDePessoas).BeginInit();
            SuspendLayout();
            // 
            // TabelaDePessoas
            // 
            TabelaDePessoas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabelaDePessoas.Location = new Point(12, 56);
            TabelaDePessoas.Name = "TabelaDePessoas";
            TabelaDePessoas.Size = new Size(451, 227);
            TabelaDePessoas.TabIndex = 0;
            TabelaDePessoas.CellClick += TabelaDePessoas_CellClick;
            // 
            // LabelNome
            // 
            LabelNome.AutoSize = true;
            LabelNome.Location = new Point(12, 9);
            LabelNome.Name = "LabelNome";
            LabelNome.Size = new Size(40, 15);
            LabelNome.TabIndex = 1;
            LabelNome.Text = "Nome";
            LabelNome.Click += label1_Click;
            // 
            // LabelSobrenome
            // 
            LabelSobrenome.AutoSize = true;
            LabelSobrenome.Location = new Point(118, 9);
            LabelSobrenome.Name = "LabelSobrenome";
            LabelSobrenome.Size = new Size(68, 15);
            LabelSobrenome.TabIndex = 2;
            LabelSobrenome.Text = "Sobrenome";
            // 
            // LabelIdade
            // 
            LabelIdade.AutoSize = true;
            LabelIdade.Location = new Point(224, 9);
            LabelIdade.Name = "LabelIdade";
            LabelIdade.Size = new Size(36, 15);
            LabelIdade.TabIndex = 3;
            LabelIdade.Text = "Idade";
            // 
            // NomeInput
            // 
            NomeInput.Location = new Point(12, 27);
            NomeInput.Name = "NomeInput";
            NomeInput.Size = new Size(100, 23);
            NomeInput.TabIndex = 4;
            // 
            // SobrenomeInput
            // 
            SobrenomeInput.Location = new Point(118, 27);
            SobrenomeInput.Name = "SobrenomeInput";
            SobrenomeInput.Size = new Size(100, 23);
            SobrenomeInput.TabIndex = 5;
            // 
            // IdadeInput
            // 
            IdadeInput.Location = new Point(224, 27);
            IdadeInput.Name = "IdadeInput";
            IdadeInput.Size = new Size(100, 23);
            IdadeInput.TabIndex = 6;
            // 
            // BotaoCadastroPessoa
            // 
            BotaoCadastroPessoa.Location = new Point(404, 26);
            BotaoCadastroPessoa.Name = "BotaoCadastroPessoa";
            BotaoCadastroPessoa.Size = new Size(59, 24);
            BotaoCadastroPessoa.TabIndex = 7;
            BotaoCadastroPessoa.Text = "Salvar";
            BotaoCadastroPessoa.UseVisualStyleBackColor = true;
            BotaoCadastroPessoa.Click += BotaoCadastroPessoa_Click;
            // 
            // DeletarCheck
            // 
            DeletarCheck.AutoSize = true;
            DeletarCheck.Location = new Point(330, 30);
            DeletarCheck.Name = "DeletarCheck";
            DeletarCheck.Size = new Size(68, 19);
            DeletarCheck.TabIndex = 8;
            DeletarCheck.Text = "Deletar?";
            DeletarCheck.UseVisualStyleBackColor = true;
            DeletarCheck.CheckedChanged += DeletarCheck_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(475, 295);
            Controls.Add(DeletarCheck);
            Controls.Add(BotaoCadastroPessoa);
            Controls.Add(IdadeInput);
            Controls.Add(SobrenomeInput);
            Controls.Add(NomeInput);
            Controls.Add(LabelIdade);
            Controls.Add(LabelSobrenome);
            Controls.Add(LabelNome);
            Controls.Add(TabelaDePessoas);
            MaximizeBox = false;
            Name = "Form1";
            Text = ".: Cadastro de Pessoas :.";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)TabelaDePessoas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TabelaDePessoas;
        private Label LabelNome;
        private Label LabelSobrenome;
        private Label LabelIdade;
        private TextBox NomeInput;
        private TextBox SobrenomeInput;
        private TextBox IdadeInput;
        private Button BotaoCadastroPessoa;
        private CheckBox DeletarCheck;
    }
}
