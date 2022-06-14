using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            if (ChecarCamposNaoPreenchidos())
            {
                var xpeService = new XPEService(txbEndereco.Text, txbLogin.Text, txbSenha.Text, ConvertImageToBase64(txbImagem.Text));
                xpeService.Enviar(rbSincrono.Checked, cbEmLote.Checked, (int)nmNumeroItensEnvio.Value, (int)nmUsuariosPorLote.Value);

                pbEnvio.PerformStep();
            }
        }

        private bool ChecarCamposNaoPreenchidos()
        {
            if (string.IsNullOrWhiteSpace(txbEndereco.Text))
            {
                MessageBox.Show("Preenche o Endereço da API do equipamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbLogin.Text))
            {
                MessageBox.Show("Preenche o Login de Acesso ao equipamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbSenha.Text))
            {
                MessageBox.Show("Preenche a Senha de Acesso ao equipamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbImagem.Text))
            {
                MessageBox.Show("Preenche a imagem para envio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void cbEmLote_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            nmUsuariosPorLote.ReadOnly = !checkBox.Checked;    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Wrap the creation of the OpenFileDialog instance in a using statement,
            // rather than manually calling the Dispose method to ensure proper disposal
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG"; 

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txbImagem.Text = dlg.FileName;
                }
            }
        }

        private string ConvertImageToBase64(string path)
        {
            using (Image image = Image.FromFile(path))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();

                    // Convert byte[] to Base64 String
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        }
    }
}
