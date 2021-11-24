
namespace WindowsFormsClientes
{
    partial class FrmConsultaTree
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaTree));
            this.TxtComentario = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtCiudad = new System.Windows.Forms.TextBox();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblComentario = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblCiudad = new System.Windows.Forms.Label();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TvwClientes = new System.Windows.Forms.TreeView();
            this.ImgListIconos = new System.Windows.Forms.ImageList(this.components);
            this.PctFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PctFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtComentario
            // 
            this.TxtComentario.AcceptsReturn = true;
            this.TxtComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtComentario.Location = new System.Drawing.Point(385, 292);
            this.TxtComentario.Multiline = true;
            this.TxtComentario.Name = "TxtComentario";
            this.TxtComentario.ReadOnly = true;
            this.TxtComentario.Size = new System.Drawing.Size(275, 53);
            this.TxtComentario.TabIndex = 29;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(385, 257);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.ReadOnly = true;
            this.TxtEmail.Size = new System.Drawing.Size(275, 22);
            this.TxtEmail.TabIndex = 28;
            // 
            // TxtCiudad
            // 
            this.TxtCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCiudad.Location = new System.Drawing.Point(385, 224);
            this.TxtCiudad.Name = "TxtCiudad";
            this.TxtCiudad.ReadOnly = true;
            this.TxtCiudad.Size = new System.Drawing.Size(275, 22);
            this.TxtCiudad.TabIndex = 27;
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidos.Location = new System.Drawing.Point(385, 192);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.ReadOnly = true;
            this.TxtApellidos.Size = new System.Drawing.Size(275, 22);
            this.TxtApellidos.TabIndex = 26;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(385, 158);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.ReadOnly = true;
            this.TxtNombre.Size = new System.Drawing.Size(275, 22);
            this.TxtNombre.TabIndex = 25;
            // 
            // LblComentario
            // 
            this.LblComentario.AutoSize = true;
            this.LblComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComentario.Location = new System.Drawing.Point(288, 288);
            this.LblComentario.Name = "LblComentario";
            this.LblComentario.Size = new System.Drawing.Size(91, 16);
            this.LblComentario.TabIndex = 23;
            this.LblComentario.Text = "Comentario:";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(288, 257);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(56, 16);
            this.LblEmail.TabIndex = 22;
            this.LblEmail.Text = "E-mail:";
            // 
            // LblCiudad
            // 
            this.LblCiudad.AutoSize = true;
            this.LblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCiudad.Location = new System.Drawing.Point(288, 224);
            this.LblCiudad.Name = "LblCiudad";
            this.LblCiudad.Size = new System.Drawing.Size(61, 16);
            this.LblCiudad.TabIndex = 21;
            this.LblCiudad.Text = "Ciudad:";
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellidos.Location = new System.Drawing.Point(288, 192);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(78, 16);
            this.LblApellidos.TabIndex = 20;
            this.LblApellidos.Text = "Apellidos:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(288, 158);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(67, 16);
            this.LblNombre.TabIndex = 19;
            this.LblNombre.Text = "Nombre:";
            // 
            // TvwClientes
            // 
            this.TvwClientes.Location = new System.Drawing.Point(12, 159);
            this.TvwClientes.Name = "TvwClientes";
            this.TvwClientes.Size = new System.Drawing.Size(270, 186);
            this.TvwClientes.TabIndex = 30;
            this.TvwClientes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvwClientes_AfterSelect);
            // 
            // ImgListIconos
            // 
            this.ImgListIconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgListIconos.ImageStream")));
            this.ImgListIconos.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgListIconos.Images.SetKeyName(0, "planeta1 32x32.png");
            this.ImgListIconos.Images.SetKeyName(1, "planeta2 32x32.png");
            this.ImgListIconos.Images.SetKeyName(2, "usuarios 32x32.png");
            this.ImgListIconos.Images.SetKeyName(3, "usuarios2 32x32.png");
            this.ImgListIconos.Images.SetKeyName(4, "estrella 32x32.png");
            this.ImgListIconos.Images.SetKeyName(5, "estrella2 32x32.png");
            // 
            // PctFoto
            // 
            this.PctFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PctFoto.Location = new System.Drawing.Point(12, 12);
            this.PctFoto.Name = "PctFoto";
            this.PctFoto.Size = new System.Drawing.Size(229, 141);
            this.PctFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctFoto.TabIndex = 18;
            this.PctFoto.TabStop = false;
            // 
            // FrmConsultaTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(672, 378);
            this.Controls.Add(this.TvwClientes);
            this.Controls.Add(this.TxtComentario);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtCiudad);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblComentario);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblCiudad);
            this.Controls.Add(this.LblApellidos);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.PctFoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaTree";
            this.Text = "Clientes por Ciudades";
            this.Activated += new System.EventHandler(this.FrmConsultaTree_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.PctFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctFoto;
        private System.Windows.Forms.TextBox TxtComentario;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtCiudad;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblComentario;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblCiudad;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TreeView TvwClientes;
        private System.Windows.Forms.ImageList ImgListIconos;
    }
}