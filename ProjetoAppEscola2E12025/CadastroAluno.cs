using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAppEscola2E12025
{
    public partial class CadastroAluno : Form
    {
        public CadastroAluno()
        {
            InitializeComponent();
        }
        //Variáveis globais
        ConexaoAluno bd = new ConexaoAluno();
        string tabela = "tblAlunos";
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                string inserir;
                string unidade = rdbBarroca.Checked ? "B" : "F";
                int serie = rdbSerie1.Checked ? 1 : rdbSerie2.Checked ? 2 : 3;
                string turma = cmbTurma.Text;
                int idade;
                if (int.TryParse(txtIdade.Text, out idade) && !string.IsNullOrEmpty(txtNome.Text))
                {
                    inserir = string.Format($"INSERT INTO {tabela} VALUES(NULL, '{txtNome.Text}', '{idade}', '{unidade}', '{serie}', '{turma}')");
                    bd.ExecutarComandos(inserir);
                    ExibirDados();
                    LimpaCampos();
                    MessageBox.Show("Dado inserido com sucesso!");
                }
                else
                {
                    MessageBox.Show("Informação inválida!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ExibirDados();
        }
        public void ExibirDados()
        {
            try
            {
                string dados = $"SELECT * FROM {tabela} ORDER BY nome";
                DataTable dt = bd.ExecutarConsulta(dados);
                dtgAluno.DataSource = dt.AsDataView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void LimpaCampos()
        {
            lblId.Text = "";
            txtNome.Clear();
            txtIdade.Clear();
            rdbBarroca.Checked = false;
            rdbFloresta.Checked = false;
            rdbSerie1.Checked = false;
            rdbSerie2.Checked = false;
            rdbSerie3.Checked = false;
            cmbTurma.Text = "";
            txtNome.Focus();
        }

        private void dtgAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblId.Text = dtgAluno.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNome.Text = dtgAluno.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtIdade.Text = dtgAluno.Rows[e.RowIndex].Cells[2].Value.ToString();
                string unidade = dtgAluno.Rows[e.RowIndex].Cells[3].Value.ToString();
                string serie = dtgAluno.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbTurma.Text = dtgAluno.Rows[e.RowIndex].Cells[5].Value.ToString();

                rdbBarroca.Checked = unidade == "B" ? true : false;
                rdbFloresta.Checked = unidade == "F" ? true : false;

                rdbSerie1.Checked = serie == "1" ? true : false;
                rdbSerie2.Checked = serie == "2" ? true : false;
                rdbSerie3.Checked = serie == "3" ? true : false;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                string atualizar;
                string unidade = rdbBarroca.Checked ? "B" : "F";
                int serie = rdbSerie1.Checked ? 1 : rdbSerie2.Checked ? 2 : 3;
                string turma = cmbTurma.Text;
                int idade;
                if (int.TryParse(txtIdade.Text, out idade) && !string.IsNullOrEmpty(txtNome.Text))
                {
                    atualizar = string.Format($"UPDATE {tabela} SET nome = '{txtNome.Text}', idade = '{idade}', unidade = '{unidade}', serie = '{serie}', turma = '{turma}' WHERE id = '{lblId.Text}'");
                    bd.ExecutarComandos(atualizar);
                    ExibirDados();
                    LimpaCampos();
                    MessageBox.Show("Dado atualizado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Informação inválida!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string excluir;

                if (!string.IsNullOrEmpty(lblId.Text))
                {
                    excluir = $"DELETE FROM {tabela} WHERE id = '{lblId.Text}'";
                    bd.ExecutarComandos(excluir);
                    ExibirDados();
                    LimpaCampos();
                    MessageBox.Show("Dado deletado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Informação inválida!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dtgAluno_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            e.ToolTipText = "Clique aqui para alterar ou excluir";
        }

        private void CadastroAluno_Load(object sender, EventArgs e)
        {
            ExibirDados();
        }
    }
}
