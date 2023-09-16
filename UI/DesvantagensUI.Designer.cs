namespace UI
{
    partial class DesvantagensUI
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
            this.btn_desvantagem_cancelar = new System.Windows.Forms.Button();
            this.btn_desvantagem_salvar = new System.Windows.Forms.Button();
            this.txb_desvantagem_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_desvantagem_cancelar
            // 
            this.btn_desvantagem_cancelar.Location = new System.Drawing.Point(116, 51);
            this.btn_desvantagem_cancelar.Name = "btn_desvantagem_cancelar";
            this.btn_desvantagem_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_desvantagem_cancelar.TabIndex = 7;
            this.btn_desvantagem_cancelar.Text = "Cancelar";
            this.btn_desvantagem_cancelar.UseVisualStyleBackColor = true;
            this.btn_desvantagem_cancelar.Click += new System.EventHandler(this.btn_desvantagem_cancelar_Click);
            // 
            // btn_desvantagem_salvar
            // 
            this.btn_desvantagem_salvar.Location = new System.Drawing.Point(197, 51);
            this.btn_desvantagem_salvar.Name = "btn_desvantagem_salvar";
            this.btn_desvantagem_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_desvantagem_salvar.TabIndex = 6;
            this.btn_desvantagem_salvar.Text = "Salvar";
            this.btn_desvantagem_salvar.UseVisualStyleBackColor = true;
            this.btn_desvantagem_salvar.Click += new System.EventHandler(this.btn_desvantagem_salvar_Click);
            // 
            // txb_desvantagem_nome
            // 
            this.txb_desvantagem_nome.Location = new System.Drawing.Point(15, 25);
            this.txb_desvantagem_nome.Name = "txb_desvantagem_nome";
            this.txb_desvantagem_nome.Size = new System.Drawing.Size(257, 20);
            this.txb_desvantagem_nome.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // DesvantagensUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 81);
            this.ControlBox = false;
            this.Controls.Add(this.btn_desvantagem_cancelar);
            this.Controls.Add(this.btn_desvantagem_salvar);
            this.Controls.Add(this.txb_desvantagem_nome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DesvantagensUI";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Desvantagem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_desvantagem_cancelar;
        private System.Windows.Forms.Button btn_desvantagem_salvar;
        private System.Windows.Forms.TextBox txb_desvantagem_nome;
        private System.Windows.Forms.Label label1;
    }
}