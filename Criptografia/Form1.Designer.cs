namespace Criptografia
{
	partial class frmCriptografia
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
			this.txtNormal = new System.Windows.Forms.TextBox();
			this.txtCriptografado = new System.Windows.Forms.TextBox();
			this.lblNormal = new System.Windows.Forms.Label();
			this.lblCriptografado = new System.Windows.Forms.Label();
			this.btnCriptografar = new System.Windows.Forms.Button();
			this.btnDecriptografar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtNormal
			// 
			this.txtNormal.Location = new System.Drawing.Point(15, 43);
			this.txtNormal.Name = "txtNormal";
			this.txtNormal.Size = new System.Drawing.Size(200, 20);
			this.txtNormal.TabIndex = 0;
			// 
			// txtCriptografado
			// 
			this.txtCriptografado.Enabled = false;
			this.txtCriptografado.Location = new System.Drawing.Point(232, 43);
			this.txtCriptografado.Name = "txtCriptografado";
			this.txtCriptografado.Size = new System.Drawing.Size(200, 20);
			this.txtCriptografado.TabIndex = 1;
			// 
			// lblNormal
			// 
			this.lblNormal.AutoSize = true;
			this.lblNormal.Location = new System.Drawing.Point(12, 27);
			this.lblNormal.Name = "lblNormal";
			this.lblNormal.Size = new System.Drawing.Size(70, 13);
			this.lblNormal.TabIndex = 2;
			this.lblNormal.Text = "Texto Normal";
			// 
			// lblCriptografado
			// 
			this.lblCriptografado.AutoSize = true;
			this.lblCriptografado.Location = new System.Drawing.Point(232, 26);
			this.lblCriptografado.Name = "lblCriptografado";
			this.lblCriptografado.Size = new System.Drawing.Size(100, 13);
			this.lblCriptografado.TabIndex = 3;
			this.lblCriptografado.Text = "Texto Criptografado";
			// 
			// btnCriptografar
			// 
			this.btnCriptografar.Location = new System.Drawing.Point(232, 84);
			this.btnCriptografar.Name = "btnCriptografar";
			this.btnCriptografar.Size = new System.Drawing.Size(100, 23);
			this.btnCriptografar.TabIndex = 4;
			this.btnCriptografar.Text = "Criptografar";
			this.btnCriptografar.UseVisualStyleBackColor = true;
			this.btnCriptografar.Click += new System.EventHandler(this.btnCriptografar_Click);
			// 
			// btnDecriptografar
			// 
			this.btnDecriptografar.Location = new System.Drawing.Point(332, 84);
			this.btnDecriptografar.Name = "btnDecriptografar";
			this.btnDecriptografar.Size = new System.Drawing.Size(100, 23);
			this.btnDecriptografar.TabIndex = 5;
			this.btnDecriptografar.Text = "Decriptografar";
			this.btnDecriptografar.UseVisualStyleBackColor = true;
			this.btnDecriptografar.Click += new System.EventHandler(this.btnDecriptografar_Click);
			// 
			// frmCriptografia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(447, 125);
			this.Controls.Add(this.btnDecriptografar);
			this.Controls.Add(this.btnCriptografar);
			this.Controls.Add(this.lblCriptografado);
			this.Controls.Add(this.lblNormal);
			this.Controls.Add(this.txtCriptografado);
			this.Controls.Add(this.txtNormal);
			this.Name = "frmCriptografia";
			this.Text = "Criptografia";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNormal;
		private System.Windows.Forms.TextBox txtCriptografado;
		private System.Windows.Forms.Label lblNormal;
		private System.Windows.Forms.Label lblCriptografado;
		private System.Windows.Forms.Button btnCriptografar;
		private System.Windows.Forms.Button btnDecriptografar;
	}
}

