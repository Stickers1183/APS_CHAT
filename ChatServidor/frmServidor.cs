using System.Windows.Forms;
using System.Net;
using System;

namespace ChatServidor
{
    public partial class FormServer : Form
    {
        private delegate void AtualizaStatusCallback(string strMensagem);
        private ChatServidor mainServidor;
        private bool servidorRodando = false;

        public FormServer()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(590, 500);
        }

        private void btnAtender_Click(object sender, System.EventArgs e)
        {
            string enderecoIP = txtIP.Text;
            if (enderecoIP == "placeholderIP" || string.IsNullOrWhiteSpace(enderecoIP))
            {
                MessageBox.Show("Por favor, insira um endereço IP válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IPAddress ip;
            if (!IPAddress.TryParse(enderecoIP, out ip))
            {
                MessageBox.Show("Endereço IP inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                mainServidor = new ChatServidor(ip);

                // Remove e adiciona o handler para evitar duplicidade
                ChatServidor.StatusChanged -= new StatusChangedEventHandler(mainServidor_StatusChanged);
                ChatServidor.StatusChanged += new StatusChangedEventHandler(mainServidor_StatusChanged);

                mainServidor.IniciaAtendimento();

                servidorRodando = true;
                txtLog.AppendText("Servidor iniciado e monitorando conexões...\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de conexão : " + ex.Message);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (mainServidor != null && servidorRodando)
            {
                mainServidor.FinalizarServidor();
                servidorRodando = false;
                txtLog.AppendText("Servidor finalizado.\r\n");

                // Remove o handler ao finalizar para evitar mensagens duplicadas
                ChatServidor.StatusChanged -= new StatusChangedEventHandler(mainServidor_StatusChanged);
            }
            else
            {
                MessageBox.Show("O servidor não está em execução.");
            }
        }

        public void mainServidor_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            // Chama o método que atualiza o formulário
            this.Invoke(new AtualizaStatusCallback(this.AtualizaStatus), new object[] { e.EventMessage });
        }

        private void AtualizaStatus(string strMensagem)
        {
            // Atualiza o log com mensagens
            txtLog.AppendText(strMensagem + "\r\n");
        }
    }
}