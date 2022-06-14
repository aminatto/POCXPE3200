using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteXPE3200;

namespace TesteXPE3200Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txbEndereco.Text = @"http://10.48.6.113";
            txbLogin.Text = "admin";
            txbSenha.Text = "Seventh2019";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var xpeService = new XPEService(txbEndereco.Text, txbLogin.Text, txbSenha.Text);
            if (rbSincrono.Checked)
            {
                if (cbEmLote.Checked)
                {
                    xpeService.AddUsers((int)nmNumeroItensEnvio.Value);
                }
                else
                {
                    xpeService.AddUsersOneAtTime((int)nmNumeroItensEnvio.Value);
                }
            }
            else
            {
                if (cbEmLote.Checked)
                {
                    Task.Run(async () => await xpeService.AddUsersAsync((int)nmNumeroItensEnvio.Value));
                }
                else
                {
                    Task.Run(async () => await xpeService.AddUsersOneAtTimeAsync((int)nmNumeroItensEnvio.Value));
                }
            }
            Console.ReadLine();
        }
    }
}
