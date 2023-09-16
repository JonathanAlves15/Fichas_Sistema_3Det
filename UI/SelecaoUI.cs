using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTL;
using BLL;

namespace UI
{
    public partial class SelecaoUI : Form
    {
        public SelecaoUI()
        {
            InitializeComponent();
        }

        private void SelecaoUI_Load(object sender, EventArgs e)
        {
            TesteDeConexaoBLL teste = new TesteDeConexaoBLL();
            teste.TesteDeConexao(Environment.CurrentDirectory);

            FichasBLL bll = new FichasBLL();
            DataTable fichas = bll.SelectFicha(0);

            for (int i = 0; i < fichas.Rows.Count; i++)
            {
                ltb_selecao_fichas.Items.Add(fichas.Rows[i][0] + " : " + fichas.Rows[i][1]);
            }
        }

        private void ptb_selecao_add_Click(object sender, EventArgs e)
        {
            FichaUI FichaForm = new FichaUI(0, ltb_selecao_fichas);
            FichaForm.Show();
        }

        private void ltb_selecao_fichas_DoubleClick(object sender, EventArgs e)
        {
            ListBox ltb = sender as ListBox;

            if (ltb.Text != "")
            {
                int id = Convert.ToInt32(ltb.Text.Split(':')[0].Trim());

                FichaUI FichaForm = new FichaUI(id, ltb_selecao_fichas);

                FichaForm.Show();
            }
        }

        private void ptb_selecao_update_Click(object sender, EventArgs e)
        {
            recarregar();
        }

        private void ptb_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptb_selecao_apagar_Click(object sender, EventArgs e)
        {
            if (ltb_selecao_fichas.SelectedItem != null)
            {
                if (MessageBox.Show("Deletar a ficha?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    FichasBLL bll = new FichasBLL();

                    if (!bll.DeletarFicha(Convert.ToInt32(ltb_selecao_fichas.SelectedItem.ToString().Split(':')[0].Trim())))
                        MessageBox.Show("Não foi possível deletar a ficha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        recarregar();
                    }
                }
            }
        }

        public void recarregar() 
        {
            ltb_selecao_fichas.Items.Clear();
            FichasBLL bll = new FichasBLL();
            DataTable fichas = bll.SelectFicha(0);

            for (int i = 0; i < fichas.Rows.Count; i++)
            {
                ltb_selecao_fichas.Items.Add(fichas.Rows[i][0] + " : " + fichas.Rows[i][1]);
            }
        }
    }
}
