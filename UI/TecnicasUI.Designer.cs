namespace UI
{
    partial class TecnicasUI
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
            this.btn_tecnica_cancelar = new System.Windows.Forms.Button();
            this.btn_tecnica_salvar = new System.Windows.Forms.Button();
            this.txb_tecnica_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_tecnica_cancelar
            // 
            this.btn_tecnica_cancelar.Location = new System.Drawing.Point(117, 50);
            this.btn_tecnica_cancelar.Name = "btn_tecnica_cancelar";
            this.btn_tecnica_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_tecnica_cancelar.TabIndex = 7;
            this.btn_tecnica_cancelar.Text = "Cancelar";
            this.btn_tecnica_cancelar.UseVisualStyleBackColor = true;
            this.btn_tecnica_cancelar.Click += new System.EventHandler(this.btn_tecnica_cancelar_Click);
            // 
            // btn_tecnica_salvar
            // 
            this.btn_tecnica_salvar.Location = new System.Drawing.Point(198, 50);
            this.btn_tecnica_salvar.Name = "btn_tecnica_salvar";
            this.btn_tecnica_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_tecnica_salvar.TabIndex = 6;
            this.btn_tecnica_salvar.Text = "Salvar";
            this.btn_tecnica_salvar.UseVisualStyleBackColor = true;
            this.btn_tecnica_salvar.Click += new System.EventHandler(this.btn_tecnica_salvar_Click);
            // 
            // txb_tecnica_nome
            // 
            this.txb_tecnica_nome.Location = new System.Drawing.Point(16, 24);
            this.txb_tecnica_nome.Name = "txb_tecnica_nome";
            this.txb_tecnica_nome.Size = new System.Drawing.Size(257, 20);
            this.txb_tecnica_nome.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // TecnicasUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 81);
            this.ControlBox = false;
            this.Controls.Add(this.btn_tecnica_cancelar);
            this.Controls.Add(this.btn_tecnica_salvar);
            this.Controls.Add(this.txb_tecnica_nome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TecnicasUI";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Técnica";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_tecnica_cancelar;
        private System.Windows.Forms.Button btn_tecnica_salvar;
        private System.Windows.Forms.TextBox txb_tecnica_nome;
        private System.Windows.Forms.Label label1;
    }
}