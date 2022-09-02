namespace UNIPRO_CUPOM
{
    partial class frmConfig
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvarBanco = new System.Windows.Forms.Button();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDatabase);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSalvarBanco);
            this.groupBox1.Controls.Add(this.txtPorta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHost);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Banco de Dados";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(6, 256);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(271, 23);
            this.txtDatabase.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Database";
            // 
            // btnSalvarBanco
            // 
            this.btnSalvarBanco.Location = new System.Drawing.Point(167, 297);
            this.btnSalvarBanco.Name = "btnSalvarBanco";
            this.btnSalvarBanco.Size = new System.Drawing.Size(110, 33);
            this.btnSalvarBanco.TabIndex = 8;
            this.btnSalvarBanco.Text = "Salvar";
            this.btnSalvarBanco.UseVisualStyleBackColor = true;
            this.btnSalvarBanco.Click += new System.EventHandler(this.btnSalvarBanco_Click);
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(6, 203);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(271, 23);
            this.txtPorta.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Porta";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(6, 150);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(271, 23);
            this.txtSenha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(7, 97);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(271, 23);
            this.txtUsuario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuário";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(6, 47);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(271, 23);
            this.txtHost.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 367);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfig";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UNIPRO - CUPOM | CONFIGURAÇÕES";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSalvarBanco;
        private TextBox txtPorta;
        private Label label4;
        private TextBox txtSenha;
        private Label label3;
        private TextBox txtUsuario;
        private Label label2;
        private TextBox txtHost;
        private Label label1;
        private TextBox txtDatabase;
        private Label label5;
    }
}