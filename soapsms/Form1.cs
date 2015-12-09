using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace soapsms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ENVIAR_Click(object sender, EventArgs e)
        {
            string res;
            string fone = textBoxFone.Text;
            string msg = textBoxMsg.Text;
            string nmcliente = "";
            this.UseWaitCursor = true;
            progressBar.Value = 0;
            progressBar.Visible = true;
            this.Refresh();

            if (fone.Trim() != "" && msg.Trim() != "")
            {
                //ajustando interface
                progressLabel.Text = "conectando-se ao servidor";
                progressLabel.Visible = true;
                progressBar.Value += 25;
                this.Refresh();
                //Consumindo soap
                SivSoap.sivsoap servidor = new SivSoap.sivsoap();
                progressLabel.Text = "conexão estabelecida, enviando mensagem";
                progressBar.Value += 25;
                this.Refresh();
                res = servidor.sendsms(fone, msg, nmcliente);
                //processando resposta
                progressLabel.Text = "processando resposta do servidor";
                this.Refresh();
                servidor = null;
                progressBar.Value += 50;
            }
            else
                res = "Preencha os campos de telefone e mensagem";
            progressLabel.Text = "exibindo resposta do servidor";
            this.Refresh();
            MessageBox.Show(res, "RESPOSTA DO SERVIDOR");
            //reajustando interface
            progressLabel.Visible = false;
            progressBar.Visible = false;
            this.UseWaitCursor = false;
            this.Refresh();
        }
    }
}
