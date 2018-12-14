namespace BuscadorCEP
{
    partial class buscadorCep
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
            this.lblDigitarCep = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtDigitarCep = new System.Windows.Forms.MaskedTextBox();
            this.pnlBusca = new System.Windows.Forms.Panel();
            this.pnlBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDigitarCep
            // 
            this.lblDigitarCep.AutoSize = true;
            this.lblDigitarCep.Location = new System.Drawing.Point(4, 114);
            this.lblDigitarCep.Name = "lblDigitarCep";
            this.lblDigitarCep.Size = new System.Drawing.Size(133, 13);
            this.lblDigitarCep.TabIndex = 1;
            this.lblDigitarCep.Text = "Digite o CEP do endereço:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(39, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(229, 37);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Buscador de CEP";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(215, 112);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 20);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(4, 167);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(64, 13);
            this.lblLogradouro.TabIndex = 5;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Enabled = false;
            this.txtLogradouro.Location = new System.Drawing.Point(74, 167);
            this.txtLogradouro.Multiline = true;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(220, 20);
            this.txtLogradouro.TabIndex = 0;
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(74, 193);
            this.txtBairro.Multiline = true;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(220, 20);
            this.txtBairro.TabIndex = 6;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(4, 193);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 7;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(74, 219);
            this.txtCidade.Multiline = true;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(220, 20);
            this.txtCidade.TabIndex = 8;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(4, 219);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(57, 13);
            this.lblMunicipio.TabIndex = 9;
            this.lblMunicipio.Text = "Município:";
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(74, 245);
            this.txtEstado.Multiline = true;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(220, 20);
            this.txtEstado.TabIndex = 10;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(4, 245);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "Estado:";
            // 
            // txtDigitarCep
            // 
            this.txtDigitarCep.Location = new System.Drawing.Point(143, 112);
            this.txtDigitarCep.Mask = "00000-000";
            this.txtDigitarCep.Name = "txtDigitarCep";
            this.txtDigitarCep.Size = new System.Drawing.Size(66, 20);
            this.txtDigitarCep.TabIndex = 12;
            this.txtDigitarCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlBusca
            // 
            this.pnlBusca.Controls.Add(this.lblTitulo);
            this.pnlBusca.Controls.Add(this.txtDigitarCep);
            this.pnlBusca.Controls.Add(this.lblDigitarCep);
            this.pnlBusca.Controls.Add(this.txtEstado);
            this.pnlBusca.Controls.Add(this.btnBuscar);
            this.pnlBusca.Controls.Add(this.lblEstado);
            this.pnlBusca.Controls.Add(this.lblLogradouro);
            this.pnlBusca.Controls.Add(this.txtCidade);
            this.pnlBusca.Controls.Add(this.txtLogradouro);
            this.pnlBusca.Controls.Add(this.lblMunicipio);
            this.pnlBusca.Controls.Add(this.lblBairro);
            this.pnlBusca.Controls.Add(this.txtBairro);
            this.pnlBusca.Location = new System.Drawing.Point(12, 12);
            this.pnlBusca.Name = "pnlBusca";
            this.pnlBusca.Size = new System.Drawing.Size(301, 277);
            this.pnlBusca.TabIndex = 13;
            // 
            // buscadorCep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 297);
            this.Controls.Add(this.pnlBusca);
            this.Name = "buscadorCep";
            this.Text = "Buscador de CEP";
            this.pnlBusca.ResumeLayout(false);
            this.pnlBusca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDigitarCep;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.MaskedTextBox txtDigitarCep;
        private System.Windows.Forms.Panel pnlBusca;
    }
}

