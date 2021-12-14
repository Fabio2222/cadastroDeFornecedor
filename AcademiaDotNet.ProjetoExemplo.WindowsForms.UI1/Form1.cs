using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaDotNet.ProjetoExemplo.WindowsForms.UI1
{
    public partial class FFormularioInicial : Form
    {
        public FFormularioInicial()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            var fornecedor = new Fornecedor();

            
                                   
            List<Fornecedor> listafornecedores = new List<Fornecedor>();
            listafornecedores.Add(RetornarFornecedor(fornecedor));

            dgvFornecedores.DataSource = listafornecedores;
        }

        private Fornecedor RetornarFornecedor(Fornecedor fornecedor)
        {
            if (txtNomeFornecedor.Text != string.Empty)
            {
                fornecedor.NomeDoFornecedor = txtNomeFornecedor.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o nome do fornecedor!");
                
            }

            if (txtEndereco.Text != string.Empty)
            {
                fornecedor.Endereco = txtEndereco.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o endereço!");
                
            }

            if (txtNomeContato.Text != string.Empty)
            {
                fornecedor.NomeContato = txtNomeContato.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o nome de contato!");
                
            }

            if (txtTelefone.Text != string.Empty)
            {
                fornecedor.Telefone = txtTelefone.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o telefone!");
                
            }

            return fornecedor;
        }
    }
}
