using System;
using System.Windows.Forms;

namespace Criptografia
{
	public partial class frmCriptografia : Form
	{
		public frmCriptografia()
		{
			InitializeComponent();
		}

		private void btnCriptografar_Click(object sender, EventArgs e)
		{
			string texto = txtNormal.Text;
			string key = "minha";// "Criptografia";
			Criptografia crip = new Criptografia(CryptProvider.DES)
			{
				Key = key
			};
			txtCriptografado.Text = crip.Encrypt(texto);
		}

		private void btnDecriptografar_Click(object sender, EventArgs e)
		{
			string texto = txtCriptografado.Text;
			//Está chave tem que ser a mesma que a do texto Encriptado.
			string key = "minha";// "Criptografia";
			Criptografia crip = new Criptografia(CryptProvider.DES)
			{
				Key = key
			};
			MessageBox.Show(crip.Decrypt(texto), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
