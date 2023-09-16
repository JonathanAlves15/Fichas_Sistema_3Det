using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class DesvantagensUI : Form
    {
        TabControl tbc;

        public DesvantagensUI(TabControl tbc)
        {
            this.tbc = tbc;
            InitializeComponent();
        }

        private void btn_desvantagem_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_desvantagem_salvar_Click(object sender, EventArgs e)
        {
            if (txb_desvantagem_nome.Text.Trim() != "")
            {
                RichTextBox rtb = new RichTextBox();
                rtb.Dock = DockStyle.Top;

                Button btn = new Button();
                btn.Text = "Apagar";
                btn.Location = new Point(90, 105);
                btn.BackColor = Color.Transparent;

                btn.Click += (x, y) =>
                {
                    btn.Parent.Parent.Controls.Remove(btn.Parent);
                };

                tbc.TabPages.Add(txb_desvantagem_nome.Text.Trim());
                tbc.TabPages[tbc.TabPages.Count - 1].BackColor = Color.White;
                tbc.TabPages[tbc.TabPages.Count - 1].Controls.Add(rtb);
                tbc.TabPages[tbc.TabPages.Count - 1].Controls.Add(btn);
                this.Close();
            }
        }
    }
}
