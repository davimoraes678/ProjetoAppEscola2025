namespace ProjetoAppEscola2E12025
{
    partial class CadastroAluno
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.cmbTurma = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbFloresta = new System.Windows.Forms.RadioButton();
            this.rdbBarroca = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbSerie3 = new System.Windows.Forms.RadioButton();
            this.rdbSerie2 = new System.Windows.Forms.RadioButton();
            this.rdbSerie1 = new System.Windows.Forms.RadioButton();
            this.lblId = new System.Windows.Forms.Label();
            this.dtgAluno = new System.Windows.Forms.DataGridView();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Idade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Série";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(528, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Turma";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(92, 140);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(406, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(531, 140);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(119, 20);
            this.txtIdade.TabIndex = 7;
            // 
            // cmbTurma
            // 
            this.cmbTurma.FormattingEnabled = true;
            this.cmbTurma.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cmbTurma.Location = new System.Drawing.Point(531, 204);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(121, 21);
            this.cmbTurma.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbFloresta);
            this.panel1.Controls.Add(this.rdbBarroca);
            this.panel1.Location = new System.Drawing.Point(92, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 41);
            this.panel1.TabIndex = 9;
            // 
            // rdbFloresta
            // 
            this.rdbFloresta.AutoSize = true;
            this.rdbFloresta.Location = new System.Drawing.Point(76, 14);
            this.rdbFloresta.Name = "rdbFloresta";
            this.rdbFloresta.Size = new System.Drawing.Size(62, 17);
            this.rdbFloresta.TabIndex = 1;
            this.rdbFloresta.TabStop = true;
            this.rdbFloresta.Text = "Floresta";
            this.rdbFloresta.UseVisualStyleBackColor = true;
            // 
            // rdbBarroca
            // 
            this.rdbBarroca.AutoSize = true;
            this.rdbBarroca.Location = new System.Drawing.Point(8, 14);
            this.rdbBarroca.Name = "rdbBarroca";
            this.rdbBarroca.Size = new System.Drawing.Size(62, 17);
            this.rdbBarroca.TabIndex = 0;
            this.rdbBarroca.TabStop = true;
            this.rdbBarroca.Text = "Barroca";
            this.rdbBarroca.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdbSerie3);
            this.panel2.Controls.Add(this.rdbSerie2);
            this.panel2.Controls.Add(this.rdbSerie1);
            this.panel2.Location = new System.Drawing.Point(310, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 41);
            this.panel2.TabIndex = 10;
            // 
            // rdbSerie3
            // 
            this.rdbSerie3.AutoSize = true;
            this.rdbSerie3.Location = new System.Drawing.Point(138, 12);
            this.rdbSerie3.Name = "rdbSerie3";
            this.rdbSerie3.Size = new System.Drawing.Size(35, 17);
            this.rdbSerie3.TabIndex = 13;
            this.rdbSerie3.TabStop = true;
            this.rdbSerie3.Text = "3ª";
            this.rdbSerie3.UseVisualStyleBackColor = true;
            // 
            // rdbSerie2
            // 
            this.rdbSerie2.AutoSize = true;
            this.rdbSerie2.Location = new System.Drawing.Point(77, 12);
            this.rdbSerie2.Name = "rdbSerie2";
            this.rdbSerie2.Size = new System.Drawing.Size(35, 17);
            this.rdbSerie2.TabIndex = 12;
            this.rdbSerie2.TabStop = true;
            this.rdbSerie2.Text = "2ª";
            this.rdbSerie2.UseVisualStyleBackColor = true;
            // 
            // rdbSerie1
            // 
            this.rdbSerie1.AutoSize = true;
            this.rdbSerie1.Location = new System.Drawing.Point(10, 14);
            this.rdbSerie1.Name = "rdbSerie1";
            this.rdbSerie1.Size = new System.Drawing.Size(35, 17);
            this.rdbSerie1.TabIndex = 11;
            this.rdbSerie1.TabStop = true;
            this.rdbSerie1.Text = "1ª";
            this.rdbSerie1.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(109, 58);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(33, 13);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "Vazia";
            // 
            // dtgAluno
            // 
            this.dtgAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAluno.Location = new System.Drawing.Point(92, 235);
            this.dtgAluno.Name = "dtgAluno";
            this.dtgAluno.Size = new System.Drawing.Size(560, 117);
            this.dtgAluno.TabIndex = 12;
            this.dtgAluno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAluno_CellClick);
            this.dtgAluno.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.dtgAluno_CellToolTipTextNeeded);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(92, 384);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnCadastro.TabIndex = 13;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(205, 384);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(330, 384);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(448, 384);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 16;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(575, 384);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // CadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.dtgAluno);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbTurma);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroAluno";
            this.Text = "Cadastro de Aluno";
            this.Load += new System.EventHandler(this.CadastroAluno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.ComboBox cmbTurma;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbFloresta;
        private System.Windows.Forms.RadioButton rdbBarroca;
        private System.Windows.Forms.RadioButton rdbSerie3;
        private System.Windows.Forms.RadioButton rdbSerie2;
        private System.Windows.Forms.RadioButton rdbSerie1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dtgAluno;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
    }
}

