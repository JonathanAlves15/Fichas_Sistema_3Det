using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BLL;
using DTL;

namespace UI
{
    public partial class FichaUI : Form
    {
        private int id;
        ListBox ltb;
        string operacao = "insert";

        public FichaUI(int id, ListBox ltb)
        {
            this.id = id;

            if (id != 0)
                operacao = "update";

            this.ltb = ltb;

            InitializeComponent();
        }

        private void FichaUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            updateList();
        }

        public void updateList()
        {
            ltb.Items.Clear();

            FichasBLL bll = new FichasBLL();

            DataTable fichas = bll.SelectFicha(0);

            for (int i = 0; i < fichas.Rows.Count; i++)
                ltb.Items.Add(fichas.Rows[i][0] + " : " + fichas.Rows[i][1]);
        }

        private void btn_ficha_salvar_Click(object sender, EventArgs e)
        {
            FichasBLL fichasBll = new FichasBLL();

            Ficha ficha                 = new Ficha();
            Vantagens[] vantagens       = null;
            Desvantagens[] desvantagens = null;
            Tecnicas[] tecnicas         = null;

            if (this.operacao == "update")
                ficha.Id = this.id;

            ficha.Nome          = txb_nome.Text;
            ficha.Descricao     = rtb_descricao.Text;
            ficha.Arquetipo     = txb_arquetipo.Text;
            ficha.Pericias      = rtb_pericias.Text;
            ficha.Foto          = ptb_foto.ImageLocation;
            ficha.Exp           = Convert.ToInt32(nud_exp.Value);
            ficha.Pontos        = Convert.ToInt32(nud_pontos.Value);
            ficha.Poder         = Convert.ToInt32(nud_poder.Value);
            ficha.Habilidade    = Convert.ToInt32(nud_habilidade.Value);
            ficha.Resistencia   = Convert.ToInt32(nud_resistencia.Value);
            ficha.Pv            = Convert.ToInt32(nud_pv.Value);
            ficha.MaxPv         = Convert.ToInt32(nud_pv_max.Value);
            ficha.Pa            = Convert.ToInt32(nud_pa.Value);
            ficha.MaxPa         = Convert.ToInt32(nud_pa_max.Value);
            ficha.Pm            = Convert.ToInt32(nud_pm.Value);
            ficha.MaxPm         = Convert.ToInt32(nud_pm_max.Value);
            ficha.Inventario    = rtb_inventario.Text;

            if(tbc_vantagens.TabCount > 0) 
            {
                vantagens = new Vantagens[tbc_vantagens.TabCount];

                for (int i = 0; i < tbc_vantagens.TabCount; i++)
                {
                    Vantagens vantagem = new Vantagens();

                    vantagem.Id_ficha = fichasBll.NextId();
                    vantagem.Nome = tbc_vantagens.TabPages[i].Text;
                    vantagem.Descricao = tbc_vantagens.TabPages[i].Controls.Cast<Control>().FirstOrDefault(x => x is RichTextBox).Text;

                    vantagens[i] = vantagem;
                }
            }

            if(tbc_desvantagens.TabCount > 0) 
            {
                desvantagens = new Desvantagens[tbc_desvantagens.TabCount];

                for (int i = 0; i < tbc_desvantagens.TabCount; i++)
                {
                    Desvantagens desvantagem = new Desvantagens();

                    desvantagem.Id_ficha = fichasBll.NextId();
                    desvantagem.Nome = tbc_desvantagens.TabPages[i].Text;
                    desvantagem.Descricao = tbc_desvantagens.TabPages[i].Controls.Cast<Control>().FirstOrDefault(x => x is RichTextBox).Text;

                    desvantagens[i] = desvantagem;
                }
            }
            
            if(tbc_tecnicas.TabCount > 0) 
            {
                tecnicas = new Tecnicas[tbc_tecnicas.TabCount];

                for (int i = 0; i < tbc_tecnicas.TabCount; i++)
                {
                    Tecnicas tecnica = new Tecnicas();

                    tecnica.Id_ficha = fichasBll.NextId();
                    tecnica.Nome = tbc_tecnicas.TabPages[i].Text;
                    tecnica.Descricao = tbc_tecnicas.TabPages[i].Controls.Cast<Control>().FirstOrDefault(x => x is RichTextBox).Text;

                    tecnicas[i] = tecnica;
                }
            }

            if (this.operacao == "insert")
            {
                if (!fichasBll.InsertFicha(ficha, vantagens, desvantagens, tecnicas))
                    MessageBox.Show("O nome do personagem não pode ser vazio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    MessageBox.Show("Sua ficha de personagem foi salva.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }

            else
            {
                System.Threading.Thread.Sleep(1000);

                if (!fichasBll.UpdateFicha(ficha, vantagens, desvantagens, tecnicas))
                    MessageBox.Show("O nome do personagem não pode ser vazio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    MessageBox.Show("Sua ficha de personagem foi atualizada.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void btn_ficha_cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cancelar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_add_vantagem_Click(object sender, EventArgs e)
        {
            VantagensUI habiForm = new VantagensUI(tbc_vantagens);
            habiForm.ShowDialog();
        }

        private void btn_add_desvantagem_Click(object sender, EventArgs e)
        {
            DesvantagensUI habiForm = new DesvantagensUI(tbc_desvantagens);
            habiForm.ShowDialog();
        }

        private void btn_add_tecnica_Click(object sender, EventArgs e)
        {
            TecnicasUI habiForm = new TecnicasUI(tbc_tecnicas);
            habiForm.ShowDialog();
        }

        private void FichaUI_Load(object sender, EventArgs e)
        {
            if (this.operacao == "update")
            {
                FichasBLL bll = new FichasBLL();

                Ficha ficha                 = bll.CarregarFicha(this.id);
                Vantagens[] vantagens       = bll.CarregarVantagem(this.id);
                Desvantagens[] desvantagens = bll.CarregarDesvantagem(this.id);
                Tecnicas[] tecnicas         = bll.CarregarTecnica(this.id);

                txb_nome.Text           = ficha.Nome;
                txb_arquetipo.Text      = ficha.Arquetipo;

                rtb_descricao.Text      = ficha.Descricao;
                rtb_inventario.Text     = ficha.Inventario;
                rtb_pericias.Text       = ficha.Pericias;

                ptb_foto.ImageLocation  = ficha.Foto;

                nud_exp.Value           = ficha.Exp;
                nud_pontos.Value        = ficha.Pontos;
                nud_poder.Value         = ficha.Poder;
                nud_habilidade.Value    = ficha.Habilidade;
                nud_resistencia.Value   = ficha.Resistencia;
                nud_pv.Value            = ficha.Pv;
                nud_pv_max.Value        = ficha.MaxPv;
                nud_pa.Value            = ficha.Pa;
                nud_pa_max.Value        = ficha.MaxPa;
                nud_pm.Value            = ficha.Pm;
                nud_pm_max.Value        = ficha.MaxPm;

                if(vantagens != null)
                    foreach (Vantagens vantagem in vantagens)
                        AddTabPage(vantagem.Descricao, vantagem.Nome, tbc_vantagens);

                if (desvantagens != null)
                    foreach (Desvantagens desvantagem in desvantagens)
                        AddTabPage(desvantagem.Descricao, desvantagem.Nome, tbc_desvantagens);

                if (tecnicas != null)
                    foreach (Tecnicas tecnica in tecnicas)
                        AddTabPage(tecnica.Descricao, tecnica.Nome, tbc_tecnicas);
            }
        }

        private void ptb_foto_Click(object sender, EventArgs e)
        {
            if(ofd_fichas.ShowDialog() == DialogResult.OK)
                ptb_foto.ImageLocation = ofd_fichas.FileName;
        }

        private void AddTabPage(string rtbDescricao, string pageNome, TabControl tbc)
        {
            RichTextBox rtb = new RichTextBox();
            rtb.Dock = DockStyle.Top;
            rtb.Text = rtbDescricao;

            Button btn = new Button();
            btn.Text = "Apagar";
            btn.Location = new Point(90, 105);
            btn.BackColor = Color.Transparent;

            btn.Click += (x, y) =>
            {
                btn.Parent.Parent.Controls.Remove(btn.Parent);
            };

            tbc.TabPages.Add(pageNome.Trim());
            tbc.TabPages[tbc.TabPages.Count - 1].BackColor = Color.White;
            tbc.TabPages[tbc.TabPages.Count - 1].Controls.Add(rtb);
            tbc.TabPages[tbc.TabPages.Count - 1].Controls.Add(btn);
        }
    }
}
