namespace UI
{
    partial class FichaUI
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
            this.txb_nome = new System.Windows.Forms.TextBox();
            this.ptb_foto = new System.Windows.Forms.PictureBox();
            this.tbc_desvantagens = new System.Windows.Forms.TabControl();
            this.tbc_tecnicas = new System.Windows.Forms.TabControl();
            this.rtb_inventario = new System.Windows.Forms.RichTextBox();
            this.btn_ficha_salvar = new System.Windows.Forms.Button();
            this.btn_ficha_cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nud_pv_max = new System.Windows.Forms.NumericUpDown();
            this.nud_pa_max = new System.Windows.Forms.NumericUpDown();
            this.nud_pm_max = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nud_pa = new System.Windows.Forms.NumericUpDown();
            this.nud_pm = new System.Windows.Forms.NumericUpDown();
            this.nud_pv = new System.Windows.Forms.NumericUpDown();
            this.lbl_pv = new System.Windows.Forms.Label();
            this.lbl_pm = new System.Windows.Forms.Label();
            this.lbl_pa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtb_descricao = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.nud_habilidade = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.nud_resistencia = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nud_poder = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.nud_exp = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.nud_pontos = new System.Windows.Forms.NumericUpDown();
            this.tbc_vantagens = new System.Windows.Forms.TabControl();
            this.btn_add_vantagem = new System.Windows.Forms.Button();
            this.btn_add_desvantagem = new System.Windows.Forms.Button();
            this.btn_add_tecnica = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_arquetipo = new System.Windows.Forms.TextBox();
            this.rtb_pericias = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ofd_fichas = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_foto)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pv_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pa_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pm_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pv)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_habilidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_resistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_poder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_exp)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pontos)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_nome
            // 
            this.txb_nome.Location = new System.Drawing.Point(143, 28);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(264, 20);
            this.txb_nome.TabIndex = 1;
            // 
            // ptb_foto
            // 
            this.ptb_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_foto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_foto.Location = new System.Drawing.Point(12, 12);
            this.ptb_foto.Name = "ptb_foto";
            this.ptb_foto.Size = new System.Drawing.Size(125, 116);
            this.ptb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_foto.TabIndex = 2;
            this.ptb_foto.TabStop = false;
            this.ptb_foto.Click += new System.EventHandler(this.ptb_foto_Click);
            // 
            // tbc_desvantagens
            // 
            this.tbc_desvantagens.Location = new System.Drawing.Point(309, 320);
            this.tbc_desvantagens.Name = "tbc_desvantagens";
            this.tbc_desvantagens.SelectedIndex = 0;
            this.tbc_desvantagens.Size = new System.Drawing.Size(260, 161);
            this.tbc_desvantagens.TabIndex = 4;
            // 
            // tbc_tecnicas
            // 
            this.tbc_tecnicas.Location = new System.Drawing.Point(604, 320);
            this.tbc_tecnicas.Name = "tbc_tecnicas";
            this.tbc_tecnicas.SelectedIndex = 0;
            this.tbc_tecnicas.Size = new System.Drawing.Size(260, 157);
            this.tbc_tecnicas.TabIndex = 5;
            // 
            // rtb_inventario
            // 
            this.rtb_inventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_inventario.Location = new System.Drawing.Point(12, 513);
            this.rtb_inventario.Name = "rtb_inventario";
            this.rtb_inventario.Size = new System.Drawing.Size(852, 73);
            this.rtb_inventario.TabIndex = 6;
            this.rtb_inventario.Text = "";
            // 
            // btn_ficha_salvar
            // 
            this.btn_ficha_salvar.Location = new System.Drawing.Point(12, 593);
            this.btn_ficha_salvar.Name = "btn_ficha_salvar";
            this.btn_ficha_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_ficha_salvar.TabIndex = 7;
            this.btn_ficha_salvar.Text = "Salvar";
            this.btn_ficha_salvar.UseVisualStyleBackColor = true;
            this.btn_ficha_salvar.Click += new System.EventHandler(this.btn_ficha_salvar_Click);
            // 
            // btn_ficha_cancelar
            // 
            this.btn_ficha_cancelar.Location = new System.Drawing.Point(93, 593);
            this.btn_ficha_cancelar.Name = "btn_ficha_cancelar";
            this.btn_ficha_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_ficha_cancelar.TabIndex = 8;
            this.btn_ficha_cancelar.Text = "Cancelar";
            this.btn_ficha_cancelar.UseVisualStyleBackColor = true;
            this.btn_ficha_cancelar.Click += new System.EventHandler(this.btn_ficha_cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Vantagens";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Desvantagens";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(705, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Técnicas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nud_pv_max);
            this.groupBox1.Controls.Add(this.nud_pa_max);
            this.groupBox1.Controls.Add(this.nud_pm_max);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.nud_pa);
            this.groupBox1.Controls.Add(this.nud_pm);
            this.groupBox1.Controls.Add(this.nud_pv);
            this.groupBox1.Controls.Add(this.lbl_pv);
            this.groupBox1.Controls.Add(this.lbl_pm);
            this.groupBox1.Controls.Add(this.lbl_pa);
            this.groupBox1.Location = new System.Drawing.Point(419, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 116);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recursos";
            // 
            // nud_pv_max
            // 
            this.nud_pv_max.Location = new System.Drawing.Point(102, 24);
            this.nud_pv_max.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_pv_max.Name = "nud_pv_max";
            this.nud_pv_max.Size = new System.Drawing.Size(41, 20);
            this.nud_pv_max.TabIndex = 14;
            this.nud_pv_max.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_pa_max
            // 
            this.nud_pa_max.Location = new System.Drawing.Point(102, 49);
            this.nud_pa_max.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_pa_max.Name = "nud_pa_max";
            this.nud_pa_max.Size = new System.Drawing.Size(41, 20);
            this.nud_pa_max.TabIndex = 13;
            this.nud_pa_max.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_pm_max
            // 
            this.nud_pm_max.Location = new System.Drawing.Point(102, 75);
            this.nud_pm_max.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_pm_max.Name = "nud_pm_max";
            this.nud_pm_max.Size = new System.Drawing.Size(41, 20);
            this.nud_pm_max.TabIndex = 12;
            this.nud_pm_max.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(84, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "/";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "/";
            // 
            // nud_pa
            // 
            this.nud_pa.Location = new System.Drawing.Point(36, 49);
            this.nud_pa.Name = "nud_pa";
            this.nud_pa.Size = new System.Drawing.Size(41, 20);
            this.nud_pa.TabIndex = 8;
            // 
            // nud_pm
            // 
            this.nud_pm.Location = new System.Drawing.Point(36, 75);
            this.nud_pm.Name = "nud_pm";
            this.nud_pm.Size = new System.Drawing.Size(41, 20);
            this.nud_pm.TabIndex = 7;
            // 
            // nud_pv
            // 
            this.nud_pv.Location = new System.Drawing.Point(36, 24);
            this.nud_pv.Name = "nud_pv";
            this.nud_pv.Size = new System.Drawing.Size(41, 20);
            this.nud_pv.TabIndex = 6;
            // 
            // lbl_pv
            // 
            this.lbl_pv.AutoSize = true;
            this.lbl_pv.Location = new System.Drawing.Point(6, 26);
            this.lbl_pv.Name = "lbl_pv";
            this.lbl_pv.Size = new System.Drawing.Size(24, 13);
            this.lbl_pv.TabIndex = 2;
            this.lbl_pv.Text = "PV:";
            // 
            // lbl_pm
            // 
            this.lbl_pm.AutoSize = true;
            this.lbl_pm.Location = new System.Drawing.Point(6, 77);
            this.lbl_pm.Name = "lbl_pm";
            this.lbl_pm.Size = new System.Drawing.Size(26, 13);
            this.lbl_pm.TabIndex = 1;
            this.lbl_pm.Text = "PM:";
            // 
            // lbl_pa
            // 
            this.lbl_pa.AutoSize = true;
            this.lbl_pa.Location = new System.Drawing.Point(6, 51);
            this.lbl_pa.Name = "lbl_pa";
            this.lbl_pa.Size = new System.Drawing.Size(24, 13);
            this.lbl_pa.TabIndex = 0;
            this.lbl_pa.Text = "PA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nome:";
            // 
            // rtb_descricao
            // 
            this.rtb_descricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_descricao.Location = new System.Drawing.Point(12, 152);
            this.rtb_descricao.Name = "rtb_descricao";
            this.rtb_descricao.Size = new System.Drawing.Size(701, 106);
            this.rtb_descricao.TabIndex = 14;
            this.rtb_descricao.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Descrição:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 497);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Inventário";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.nud_habilidade);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.nud_resistencia);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.nud_poder);
            this.groupBox2.Location = new System.Drawing.Point(583, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 116);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Características";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Resistência:";
            // 
            // nud_habilidade
            // 
            this.nud_habilidade.Location = new System.Drawing.Point(77, 49);
            this.nud_habilidade.Name = "nud_habilidade";
            this.nud_habilidade.Size = new System.Drawing.Size(41, 20);
            this.nud_habilidade.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Poder:";
            // 
            // nud_resistencia
            // 
            this.nud_resistencia.Location = new System.Drawing.Point(77, 75);
            this.nud_resistencia.Name = "nud_resistencia";
            this.nud_resistencia.Size = new System.Drawing.Size(41, 20);
            this.nud_resistencia.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Habilidade:";
            // 
            // nud_poder
            // 
            this.nud_poder.Location = new System.Drawing.Point(77, 24);
            this.nud_poder.Name = "nud_poder";
            this.nud_poder.Size = new System.Drawing.Size(41, 20);
            this.nud_poder.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Exp:";
            // 
            // nud_exp
            // 
            this.nud_exp.Location = new System.Drawing.Point(55, 24);
            this.nud_exp.Name = "nud_exp";
            this.nud_exp.Size = new System.Drawing.Size(41, 20);
            this.nud_exp.TabIndex = 21;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.nud_pontos);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.nud_exp);
            this.groupBox3.Location = new System.Drawing.Point(719, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(141, 116);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extra";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Pontos:";
            // 
            // nud_pontos
            // 
            this.nud_pontos.Location = new System.Drawing.Point(55, 75);
            this.nud_pontos.Name = "nud_pontos";
            this.nud_pontos.Size = new System.Drawing.Size(41, 20);
            this.nud_pontos.TabIndex = 21;
            // 
            // tbc_vantagens
            // 
            this.tbc_vantagens.Location = new System.Drawing.Point(12, 320);
            this.tbc_vantagens.Name = "tbc_vantagens";
            this.tbc_vantagens.SelectedIndex = 0;
            this.tbc_vantagens.Size = new System.Drawing.Size(260, 165);
            this.tbc_vantagens.TabIndex = 3;
            // 
            // btn_add_vantagem
            // 
            this.btn_add_vantagem.Location = new System.Drawing.Point(213, 271);
            this.btn_add_vantagem.Name = "btn_add_vantagem";
            this.btn_add_vantagem.Size = new System.Drawing.Size(55, 23);
            this.btn_add_vantagem.TabIndex = 23;
            this.btn_add_vantagem.Text = "Criar";
            this.btn_add_vantagem.UseVisualStyleBackColor = true;
            this.btn_add_vantagem.Click += new System.EventHandler(this.btn_add_vantagem_Click);
            // 
            // btn_add_desvantagem
            // 
            this.btn_add_desvantagem.Location = new System.Drawing.Point(514, 271);
            this.btn_add_desvantagem.Name = "btn_add_desvantagem";
            this.btn_add_desvantagem.Size = new System.Drawing.Size(55, 23);
            this.btn_add_desvantagem.TabIndex = 24;
            this.btn_add_desvantagem.Text = "Criar";
            this.btn_add_desvantagem.UseVisualStyleBackColor = true;
            this.btn_add_desvantagem.Click += new System.EventHandler(this.btn_add_desvantagem_Click);
            // 
            // btn_add_tecnica
            // 
            this.btn_add_tecnica.Location = new System.Drawing.Point(805, 271);
            this.btn_add_tecnica.Name = "btn_add_tecnica";
            this.btn_add_tecnica.Size = new System.Drawing.Size(55, 23);
            this.btn_add_tecnica.TabIndex = 25;
            this.btn_add_tecnica.Text = "Criar";
            this.btn_add_tecnica.UseVisualStyleBackColor = true;
            this.btn_add_tecnica.Click += new System.EventHandler(this.btn_add_tecnica_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Arquétipo:";
            // 
            // txb_arquetipo
            // 
            this.txb_arquetipo.Location = new System.Drawing.Point(143, 108);
            this.txb_arquetipo.Name = "txb_arquetipo";
            this.txb_arquetipo.Size = new System.Drawing.Size(264, 20);
            this.txb_arquetipo.TabIndex = 26;
            // 
            // rtb_pericias
            // 
            this.rtb_pericias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_pericias.Location = new System.Drawing.Point(719, 152);
            this.rtb_pericias.Name = "rtb_pericias";
            this.rtb_pericias.Size = new System.Drawing.Size(141, 106);
            this.rtb_pericias.TabIndex = 28;
            this.rtb_pericias.Text = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(716, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Perícias:";
            // 
            // FichaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 631);
            this.ControlBox = false;
            this.Controls.Add(this.label16);
            this.Controls.Add(this.rtb_pericias);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_arquetipo);
            this.Controls.Add(this.btn_add_tecnica);
            this.Controls.Add(this.btn_add_desvantagem);
            this.Controls.Add(this.btn_add_vantagem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtb_descricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ficha_cancelar);
            this.Controls.Add(this.btn_ficha_salvar);
            this.Controls.Add(this.rtb_inventario);
            this.Controls.Add(this.tbc_tecnicas);
            this.Controls.Add(this.tbc_desvantagens);
            this.Controls.Add(this.tbc_vantagens);
            this.Controls.Add(this.ptb_foto);
            this.Controls.Add(this.txb_nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FichaUI";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ficha";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FichaUI_FormClosing);
            this.Load += new System.EventHandler(this.FichaUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_foto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pv_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pa_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pm_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_habilidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_resistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_poder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_exp)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pontos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.PictureBox ptb_foto;
        private System.Windows.Forms.TabControl tbc_desvantagens;
        private System.Windows.Forms.TabControl tbc_tecnicas;
        private System.Windows.Forms.RichTextBox rtb_inventario;
        private System.Windows.Forms.Button btn_ficha_salvar;
        private System.Windows.Forms.Button btn_ficha_cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtb_descricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nud_pv_max;
        private System.Windows.Forms.NumericUpDown nud_pa_max;
        private System.Windows.Forms.NumericUpDown nud_pm_max;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nud_pa;
        private System.Windows.Forms.NumericUpDown nud_pm;
        private System.Windows.Forms.Label lbl_pv;
        private System.Windows.Forms.Label lbl_pm;
        private System.Windows.Forms.Label lbl_pa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nud_habilidade;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nud_resistencia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nud_poder;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nud_exp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nud_pontos;
        private System.Windows.Forms.TabControl tbc_vantagens;
        private System.Windows.Forms.NumericUpDown nud_pv;
        private System.Windows.Forms.Button btn_add_vantagem;
        private System.Windows.Forms.Button btn_add_desvantagem;
        private System.Windows.Forms.Button btn_add_tecnica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_arquetipo;
        private System.Windows.Forms.RichTextBox rtb_pericias;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.OpenFileDialog ofd_fichas;
    }
}