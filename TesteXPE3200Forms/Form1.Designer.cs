
namespace TesteXPE3200Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbSincrono = new System.Windows.Forms.RadioButton();
            this.rbAssincrono = new System.Windows.Forms.RadioButton();
            this.gbDispositivo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.gbLote = new System.Windows.Forms.GroupBox();
            this.cbEmLote = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nmDelayEnvio = new System.Windows.Forms.NumericUpDown();
            this.nmNumeroItensEnvio = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nmUsuariosPorLote = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.gbDispositivo.SuspendLayout();
            this.gbLote.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDelayEnvio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmNumeroItensEnvio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUsuariosPorLote)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(675, 423);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(113, 39);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(92, 22);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(696, 27);
            this.txbEndereco.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Endereço:";
            // 
            // rbSincrono
            // 
            this.rbSincrono.AutoSize = true;
            this.rbSincrono.Checked = true;
            this.rbSincrono.Location = new System.Drawing.Point(9, 430);
            this.rbSincrono.Name = "rbSincrono";
            this.rbSincrono.Size = new System.Drawing.Size(88, 24);
            this.rbSincrono.TabIndex = 3;
            this.rbSincrono.TabStop = true;
            this.rbSincrono.Text = "Síncrono";
            this.rbSincrono.UseVisualStyleBackColor = true;
            // 
            // rbAssincrono
            // 
            this.rbAssincrono.AutoSize = true;
            this.rbAssincrono.Location = new System.Drawing.Point(103, 430);
            this.rbAssincrono.Name = "rbAssincrono";
            this.rbAssincrono.Size = new System.Drawing.Size(102, 24);
            this.rbAssincrono.TabIndex = 4;
            this.rbAssincrono.Text = "Assíncrono";
            this.rbAssincrono.UseVisualStyleBackColor = true;
            // 
            // gbDispositivo
            // 
            this.gbDispositivo.Controls.Add(this.label3);
            this.gbDispositivo.Controls.Add(this.txbSenha);
            this.gbDispositivo.Controls.Add(this.label2);
            this.gbDispositivo.Controls.Add(this.txbLogin);
            this.gbDispositivo.Location = new System.Drawing.Point(12, 64);
            this.gbDispositivo.Name = "gbDispositivo";
            this.gbDispositivo.Size = new System.Drawing.Size(776, 110);
            this.gbDispositivo.TabIndex = 7;
            this.gbDispositivo.TabStop = false;
            this.gbDispositivo.Text = "Disposítivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Senha:";
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(80, 63);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(293, 27);
            this.txbSenha.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Login:";
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(80, 26);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(293, 27);
            this.txbLogin.TabIndex = 7;
            // 
            // gbLote
            // 
            this.gbLote.Controls.Add(this.nmUsuariosPorLote);
            this.gbLote.Controls.Add(this.label4);
            this.gbLote.Controls.Add(this.cbEmLote);
            this.gbLote.Location = new System.Drawing.Point(12, 304);
            this.gbLote.Name = "gbLote";
            this.gbLote.Size = new System.Drawing.Size(776, 113);
            this.gbLote.TabIndex = 11;
            this.gbLote.TabStop = false;
            this.gbLote.Text = "Lote";
            // 
            // cbEmLote
            // 
            this.cbEmLote.AutoSize = true;
            this.cbEmLote.Location = new System.Drawing.Point(10, 26);
            this.cbEmLote.Name = "cbEmLote";
            this.cbEmLote.Size = new System.Drawing.Size(184, 24);
            this.cbEmLote.TabIndex = 11;
            this.cbEmLote.Text = "Habilitar envio em lote";
            this.cbEmLote.UseVisualStyleBackColor = true;
            this.cbEmLote.CheckedChanged += new System.EventHandler(this.cbEmLote_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nmDelayEnvio);
            this.groupBox1.Controls.Add(this.nmNumeroItensEnvio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 118);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuários";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(623, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "segundos";
            // 
            // nmDelayEnvio
            // 
            this.nmDelayEnvio.Location = new System.Drawing.Point(467, 28);
            this.nmDelayEnvio.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmDelayEnvio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmDelayEnvio.Name = "nmDelayEnvio";
            this.nmDelayEnvio.Size = new System.Drawing.Size(150, 27);
            this.nmDelayEnvio.TabIndex = 24;
            this.nmDelayEnvio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmNumeroItensEnvio
            // 
            this.nmNumeroItensEnvio.Location = new System.Drawing.Point(167, 26);
            this.nmNumeroItensEnvio.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nmNumeroItensEnvio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmNumeroItensEnvio.Name = "nmNumeroItensEnvio";
            this.nmNumeroItensEnvio.Size = new System.Drawing.Size(150, 27);
            this.nmNumeroItensEnvio.TabIndex = 23;
            this.nmNumeroItensEnvio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Delay envio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Número de usuários";
            // 
            // nmUsuariosPorLote
            // 
            this.nmUsuariosPorLote.Location = new System.Drawing.Point(138, 65);
            this.nmUsuariosPorLote.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmUsuariosPorLote.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmUsuariosPorLote.Name = "nmUsuariosPorLote";
            this.nmUsuariosPorLote.ReadOnly = true;
            this.nmUsuariosPorLote.Size = new System.Drawing.Size(150, 27);
            this.nmUsuariosPorLote.TabIndex = 25;
            this.nmUsuariosPorLote.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Usuários por lote";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbLote);
            this.Controls.Add(this.gbDispositivo);
            this.Controls.Add(this.rbAssincrono);
            this.Controls.Add(this.rbSincrono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.btnEnviar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 530);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 530);
            this.Name = "Form1";
            this.Text = "XPE 3200";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbDispositivo.ResumeLayout(false);
            this.gbDispositivo.PerformLayout();
            this.gbLote.ResumeLayout(false);
            this.gbLote.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDelayEnvio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmNumeroItensEnvio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUsuariosPorLote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbSincrono;
        private System.Windows.Forms.RadioButton rbAssincrono;
        private System.Windows.Forms.GroupBox gbDispositivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.GroupBox gbLote;
        private System.Windows.Forms.CheckBox cbEmLote;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmDelayEnvio;
        private System.Windows.Forms.NumericUpDown nmNumeroItensEnvio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmUsuariosPorLote;
        private System.Windows.Forms.Label label4;
    }
}

