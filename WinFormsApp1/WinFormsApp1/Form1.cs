using System.Windows.Forms;
using WinFormsApp1.Models;
using WinFormsApp1.Repositories;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int IdPessoa;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BotaoCadastroPessoa_Click(object sender, EventArgs e)
        {
            if (BotaoCadastroPessoa.Text == "Deletar")
            {
                var pessoaRepo = new PessoaRepository();
                pessoaRepo.Delete(IdPessoa);
                LimparCampos();
                BuscarTodasAsPessoas(pessoaRepo);
                DeletarCheck.Checked = false;
                DeletarCheck.CheckState = CheckState.Unchecked;
            }

            if (BotaoCadastroPessoa.Text == "Salvar")
            {
                var pessoa = new Pessoas()
                {
                    Nome = NomeInput.Text == "" ? "N/A" : NomeInput.Text,
                    Sobrenome = SobrenomeInput.Text == "" ? "N/A" : SobrenomeInput.Text,
                    Idade = IdadeInput.Text == "" ? 0 : Int32.Parse(IdadeInput.Text),
                };

                var pessoaRepo = new PessoaRepository();
                pessoaRepo.Add(pessoa);
                LimparCampos();
                BuscarTodasAsPessoas(pessoaRepo);
            }

            if (BotaoCadastroPessoa.Text == "Editar")
            {
                int IdPessoasCell = this.IdPessoa;
                var pessoa = new Pessoas()
                {
                    IdPessoas = IdPessoasCell,
                    Nome = NomeInput.Text == "" ? "N/A" : NomeInput.Text,
                    Sobrenome = SobrenomeInput.Text == "" ? "N/A" : SobrenomeInput.Text,
                    Idade = IdadeInput.Text == "" ? 0 : Int32.Parse(IdadeInput.Text),
                };

                var pessoaRepo = new PessoaRepository();
                pessoaRepo.Update(IdPessoasCell, pessoa);
                LimparCampos();
                BuscarTodasAsPessoas(pessoaRepo);
            }
        }

        private void LimparCampos()
        {
            NomeInput.Text = string.Empty;
            SobrenomeInput.Text = string.Empty;
            IdadeInput.Text = string.Empty;
        }

        private void BuscarTodasAsPessoas(PessoaRepository pessoaRepository)
        {
            if (NomeInput.Text == "")
            {
                BotaoCadastroPessoa.Text = "Salvar";
                DeletarCheck.Checked = false;
                DeletarCheck.CheckState = CheckState.Unchecked;
            }

            var pessoas = pessoaRepository.Select();
            TabelaDePessoas.DataSource = pessoas.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BotaoCadastroPessoa.Text = "Salvar";
            var pessoasRepo = new PessoaRepository();
            BuscarTodasAsPessoas(pessoasRepo);
        }

        private void TabelaDePessoas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            this.IdPessoa = Int32.Parse(dataGridView.CurrentRow.Cells["idpessoas"].Value.ToString());
            NomeInput.Text = dataGridView.CurrentRow.Cells["nome"].Value.ToString();
            SobrenomeInput.Text = dataGridView.CurrentRow.Cells["sobrenome"].Value.ToString();
            IdadeInput.Text = dataGridView.CurrentRow.Cells["idade"].Value.ToString();

            BotaoCadastroPessoa.Text = "Editar";
        }

        private void DeletarCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (DeletarCheck.Checked == true)
            {
                BotaoCadastroPessoa.Text = "Deletar";
            } else
            {
                BotaoCadastroPessoa.Text = "Editar";
            }
        }
    }
}
