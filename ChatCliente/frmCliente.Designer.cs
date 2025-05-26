using System;

namespace ChatCliente
{
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

         
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.txtServidorIP = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.groupBoxLog = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 70;
            this.panelHeader.Controls.Add(this.labelTitulo);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Text = "S.O.S Rio Tietê";
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.AutoSize = false;
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // label1 (Servidor IP)
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "🌐 Servidor IP:";
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            // 
            // txtServidorIP
            // 
            this.txtServidorIP.Location = new System.Drawing.Point(250, 87);
            this.txtServidorIP.Name = "txtServidorIP";
            this.txtServidorIP.Size = new System.Drawing.Size(180, 29);
            this.txtServidorIP.TabIndex = 0;
            this.txtServidorIP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtServidorIP.BackColor = System.Drawing.Color.FromArgb(232, 245, 233);
            this.txtServidorIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // label2 (Usuário)
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "👤 Usuário:";
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(250, 127);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(180, 29);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(232, 245, 233);
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(470, 107);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(220, 35); // largura aumentada
            this.btnConectar.TabIndex = 5;
            this.btnConectar.Text = "🔗 Conectar";
            this.btnConectar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnConectar.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnConectar.ForeColor = System.Drawing.Color.White;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnConectar.FlatAppearance.BorderSize = 0;
            this.btnConectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // groupBoxLog
            // 
            this.groupBoxLog.Text = "Mensagens do Chat";
            this.groupBoxLog.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxLog.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.groupBoxLog.Location = new System.Drawing.Point(40, 170);
            this.groupBoxLog.Size = new System.Drawing.Size(650, 250);
            this.groupBoxLog.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxLog.TabStop = false;
            this.groupBoxLog.Controls.Add(this.txtLog);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(15, 30);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(610, 190);
            this.txtLog.TabIndex = 4;
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(245, 255, 245);
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtLog.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.txtLog.ReadOnly = true;
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(40, 430);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(500, 29);
            this.txtMensagem.TabIndex = 6;
            this.txtMensagem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMensagem.BackColor = System.Drawing.Color.White;
            this.txtMensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMensagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMensagem_KeyPress);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(560, 428);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(130, 35);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.Text = "📤 Enviar";
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(224, 255, 224);
            this.ClientSize = new System.Drawing.Size(730, 500);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServidorIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.groupBoxLog);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.btnEnviar);
            this.Name = "frmCliente";
            this.Text = "S.O.S Rio Tietê - Cliente";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox txtServidorIP;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.GroupBox groupBoxLog;

        private bool conectado = false;
    }
}

