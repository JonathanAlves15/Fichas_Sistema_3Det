namespace UI
{
    partial class SelecaoUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelecaoUI));
            this.pnl_selecao = new System.Windows.Forms.Panel();
            this.ptb_selecao_apagar = new System.Windows.Forms.PictureBox();
            this.ptb_sair = new System.Windows.Forms.PictureBox();
            this.ptb_selecao_update = new System.Windows.Forms.PictureBox();
            this.ltb_selecao_fichas = new System.Windows.Forms.ListBox();
            this.ptb_selecao_add = new System.Windows.Forms.PictureBox();
            this.pnl_selecao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_selecao_apagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_sair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_selecao_update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_selecao_add)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_selecao
            // 
            this.pnl_selecao.Controls.Add(this.ptb_selecao_apagar);
            this.pnl_selecao.Controls.Add(this.ptb_sair);
            this.pnl_selecao.Controls.Add(this.ptb_selecao_update);
            this.pnl_selecao.Controls.Add(this.ltb_selecao_fichas);
            this.pnl_selecao.Controls.Add(this.ptb_selecao_add);
            this.pnl_selecao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_selecao.Location = new System.Drawing.Point(0, 0);
            this.pnl_selecao.Name = "pnl_selecao";
            this.pnl_selecao.Size = new System.Drawing.Size(324, 263);
            this.pnl_selecao.TabIndex = 0;
            // 
            // ptb_selecao_apagar
            // 
            this.ptb_selecao_apagar.AccessibleDescription = "Apagar Ficha";
            this.ptb_selecao_apagar.AccessibleName = "Apagar Ficha";
            this.ptb_selecao_apagar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ptb_selecao_apagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_selecao_apagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_selecao_apagar.Image = ((System.Drawing.Image)(resources.GetObject("ptb_selecao_apagar.Image")));
            this.ptb_selecao_apagar.Location = new System.Drawing.Point(273, 104);
            this.ptb_selecao_apagar.Name = "ptb_selecao_apagar";
            this.ptb_selecao_apagar.Padding = new System.Windows.Forms.Padding(2);
            this.ptb_selecao_apagar.Size = new System.Drawing.Size(40, 40);
            this.ptb_selecao_apagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_selecao_apagar.TabIndex = 4;
            this.ptb_selecao_apagar.TabStop = false;
            this.ptb_selecao_apagar.Click += new System.EventHandler(this.ptb_selecao_apagar_Click);
            // 
            // ptb_sair
            // 
            this.ptb_sair.AccessibleDescription = "Sair";
            this.ptb_sair.AccessibleName = "Sair";
            this.ptb_sair.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ptb_sair.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_sair.Image = ((System.Drawing.Image)(resources.GetObject("ptb_sair.Image")));
            this.ptb_sair.Location = new System.Drawing.Point(273, 209);
            this.ptb_sair.Name = "ptb_sair";
            this.ptb_sair.Padding = new System.Windows.Forms.Padding(5);
            this.ptb_sair.Size = new System.Drawing.Size(40, 40);
            this.ptb_sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_sair.TabIndex = 3;
            this.ptb_sair.TabStop = false;
            this.ptb_sair.Click += new System.EventHandler(this.ptb_sair_Click);
            // 
            // ptb_selecao_update
            // 
            this.ptb_selecao_update.AccessibleDescription = "Recarregar";
            this.ptb_selecao_update.AccessibleName = "Recarregar";
            this.ptb_selecao_update.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ptb_selecao_update.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_selecao_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_selecao_update.Image = ((System.Drawing.Image)(resources.GetObject("ptb_selecao_update.Image")));
            this.ptb_selecao_update.Location = new System.Drawing.Point(273, 58);
            this.ptb_selecao_update.Name = "ptb_selecao_update";
            this.ptb_selecao_update.Padding = new System.Windows.Forms.Padding(5);
            this.ptb_selecao_update.Size = new System.Drawing.Size(40, 40);
            this.ptb_selecao_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_selecao_update.TabIndex = 2;
            this.ptb_selecao_update.TabStop = false;
            this.ptb_selecao_update.Click += new System.EventHandler(this.ptb_selecao_update_Click);
            // 
            // ltb_selecao_fichas
            // 
            this.ltb_selecao_fichas.FormattingEnabled = true;
            this.ltb_selecao_fichas.Location = new System.Drawing.Point(12, 12);
            this.ltb_selecao_fichas.Name = "ltb_selecao_fichas";
            this.ltb_selecao_fichas.Size = new System.Drawing.Size(255, 238);
            this.ltb_selecao_fichas.TabIndex = 1;
            this.ltb_selecao_fichas.DoubleClick += new System.EventHandler(this.ltb_selecao_fichas_DoubleClick);
            // 
            // ptb_selecao_add
            // 
            this.ptb_selecao_add.AccessibleDescription = "Criar Ficha";
            this.ptb_selecao_add.AccessibleName = "Criar Ficha";
            this.ptb_selecao_add.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ptb_selecao_add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_selecao_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_selecao_add.Image = ((System.Drawing.Image)(resources.GetObject("ptb_selecao_add.Image")));
            this.ptb_selecao_add.Location = new System.Drawing.Point(273, 12);
            this.ptb_selecao_add.Name = "ptb_selecao_add";
            this.ptb_selecao_add.Padding = new System.Windows.Forms.Padding(5);
            this.ptb_selecao_add.Size = new System.Drawing.Size(40, 40);
            this.ptb_selecao_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_selecao_add.TabIndex = 0;
            this.ptb_selecao_add.TabStop = false;
            this.ptb_selecao_add.Click += new System.EventHandler(this.ptb_selecao_add_Click);
            // 
            // SelecaoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 263);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_selecao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SelecaoUI";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleção de Personagem";
            this.Load += new System.EventHandler(this.SelecaoUI_Load);
            this.pnl_selecao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_selecao_apagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_sair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_selecao_update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_selecao_add)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_selecao;
        private System.Windows.Forms.PictureBox ptb_selecao_add;
        private System.Windows.Forms.ListBox ltb_selecao_fichas;
        private System.Windows.Forms.PictureBox ptb_selecao_update;
        private System.Windows.Forms.PictureBox ptb_selecao_apagar;
        private System.Windows.Forms.PictureBox ptb_sair;


    }
}

