using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaDeAluno
{
    public partial class frmCategoriaPorIdade : Form
    {
        public frmCategoriaPorIdade()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtAnoUltimoAniversario_Enter(object sender, EventArgs e)
        {
            
            if ((txtAnoNascimento.Text.Trim().Length <4) || (txtAnoNascimento.Text.Trim().Length > 4))
            {
                MessageBox.Show("É preciso informar o ANO DE NASCIMENTO com 4 digitos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnoNascimento.Focus();
            }
            
        }

        private void TxtAnoUltimoAniversario_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(txtAnoUltimoAniversario.Text) <= Convert.ToInt32(txtAnoNascimento.Text))
            {
                MessageBox.Show("O ANO DO ULTI ANIVERSARIO deve ser superior ao do ANO DE NASCIMENTO", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text == String.Empty) || (txtAnoNascimento.Text == String.Empty) || (txtAnoUltimoAniversario.Text == String.Empty))
            {
                MessageBox.Show("Todos os campos solicitados dvem ser preenchidos.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int idade = (Convert.ToInt32(txtAnoUltimoAniversario.Text)) - (Convert.ToInt32(txtAnoNascimento.Text));
                if (idade > 17)
                {
                    txtCategoria.Text = "Adulto";
                }
                else if ((idade >= 14) && (idade <17))
                {
                    txtCategoria.Text = "Juvenil B";
                }
                else if ((idade >= 11) && (idade < 14))
                {
                    txtCategoria.Text = "Juvenil A";
                }
                else if ((idade >= 8) && (idade < 11))
                {
                    txtCategoria.Text = "Infantil B";
                }
                else if ((idade >= 5) && (idade < 8))
                { 
                    txtCategoria.Text = "Infantil A";
                }
            }
        }

        private void FrmCategoriaPorIdade_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("NÃO USE ESSE EXÊRCICIO.", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
