namespace UI
{
    partial class VantagensUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.txb_habilidade_nome = new System.Windows.Forms.TextBox();
            this.btn_habilidades_salvar = new System.Windows.Forms.Button();
            this.btn_habilidades_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txb_habilidade_nome
            // 
            this.txb_habilidade_nome.Location = new System.Drawing.Point(15, 25);
            this.txb_habilidade_nome.Name = "txb_habilidade_nome";
            this.txb_habilidade_nome.Size = new System.Drawing.Size(257, 20);
            this.txb_habilidade_nome.TabIndex = 1;
            // 
            // btn_habilidades_salvar
            // 
            this.btn_habilidades_salvar.Location = new System.Drawing.Point(197, 51);
            this.btn_habilidades_salvar.Name = "btn_habilidades_salvar";
            this.btn_habilidades_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_habilidades_salvar.TabIndex = 2;
            this.btn_habilidades_salvar.Text = "Salvar";
            this.btn_habilidades_salvar.UseVisualStyleBackColor = true;
            this.btn_habilidades_salvar.Click += new System.EventHandler(this.btn_habilidades_salvar_Click);
            // 
            // btn_habilidades_cancelar
            // 
            this.btn_habilidades_cancelar.Location = new System.Drawing.Point(116, 51);
            this.btn_habilidades_cancelar.Name = "btn_habilidades_cancelar";
            this.btn_habilidades_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_habilidades_cancelar.TabIndex = 3;
            this.btn_habilidades_cancelar.Text = "Cancelar";
            this.btn_habilidades_cancelar.UseVisualStyleBackColor = true;
            this.btn_habilidades_cancelar.Click += new System.EventHandler(this.btn_habilidades_cancelar_Click);
            // 
            // VantagensUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 81);
            this.ControlBox = false;
            this.Controls.Add(this.btn_habilidades_cancelar);
            this.Controls.Add(this.btn_habilidades_salvar);
            this.Controls.Add(this.txb_habilidade_nome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VantagensUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Vantagem";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_habilidade_nome;
        private System.Windows.Forms.Button btn_habilidades_salvar;
        private System.Windows.Forms.Button btn_habilidades_cancelar;
    }
}