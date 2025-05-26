using System;

namespace ChatServidor
{
    partial class FormServer
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnAtender = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.groupBoxLog = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(46, 204, 113); // Verde forte
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "🌐 Endereço IP:";
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(60, 125);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(300, 29);
            this.txtIP.TabIndex = 2;
            this.txtIP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtIP.BackColor = System.Drawing.Color.FromArgb(232, 245, 233);
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIP.ForeColor = System.Drawing.Color.Gray;
            this.txtIP.Text = placeholderIP;
            this.txtIP.Enter += new System.EventHandler(this.txtIP_Enter);
            this.txtIP.Leave += new System.EventHandler(this.txtIP_Leave);
            // 
            // btnAtender
            // 
            this.btnAtender.Location = new System.Drawing.Point(380, 123); // alinhado com a direita do groupBoxLog
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(150, 35);
            this.btnAtender.TabIndex = 3;
            this.btnAtender.Text = "▶ Iniciar Atendimento";
            this.btnAtender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAtender.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnAtender.ForeColor = System.Drawing.Color.White;
            this.btnAtender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtender.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnAtender.FlatAppearance.BorderSize = 0;
            this.btnAtender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // btnFinalizar 
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(540, 123);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(150, 35);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "⏹ Finalizar Servidor";
            this.btnFinalizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(231, 76, 60); // Vermelho suave
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // groupBoxLog
            // 
            this.groupBoxLog.Text = "Mensagens do Chat";
            this.groupBoxLog.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxLog.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.groupBoxLog.Location = new System.Drawing.Point(50, 190); // margem esquerda de 50
            this.groupBoxLog.Size = new System.Drawing.Size(620, 230);     // largura 620
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
            this.txtLog.Size = new System.Drawing.Size(590, 180);
            this.txtLog.TabIndex = 0;
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(245, 255, 245);
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtLog.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.txtLog.ReadOnly = true;
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(224, 255, 224); // Verde claro
            this.ClientSize = new System.Drawing.Size(730, 480);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxLog);
            this.Name = "FormServer";
            this.Text = "Chat Servidor";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.GroupBox groupBoxLog;
        private string placeholderIP = "Digite o IP do servidor";

        private void txtIP_Enter(object sender, EventArgs e)
        {
            if (txtIP.Text == placeholderIP)
            {
                txtIP.Text = "";
                txtIP.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            }
        }

        private void txtIP_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIP.Text))
            {
                txtIP.Text = placeholderIP;
                txtIP.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}