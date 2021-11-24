
namespace WindowsFormsClientes
{
    partial class FrmAltas
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
            this.LblClientes = new System.Windows.Forms.Label();
            this.LstClientes = new System.Windows.Forms.ListBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.LblCiudad = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblComentario = new System.Windows.Forms.Label();
            this.LblVip = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtCiudad = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtComentario = new System.Windows.Forms.TextBox();
            this.ChkVip = new System.Windows.Forms.CheckBox();
            this.OpnFleDiaFoto = new System.Windows.Forms.OpenFileDialog();
            this.PctFoto = new System.Windows.Forms.PictureBox();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PctFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // LblClientes
            // 
            this.LblClientes.AutoSize = true;
            this.LblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClientes.Location = new System.Drawing.Point(12, 78);
            this.LblClientes.Name = "LblClientes";
            this.LblClientes.Size = new System.Drawing.Size(74, 20);
            this.LblClientes.TabIndex = 3;
            this.LblClientes.Text = "Clientes";
            // 
            // LstClientes
            // 
            this.LstClientes.FormattingEnabled = true;
            this.LstClientes.HorizontalScrollbar = true;
            this.LstClientes.Location = new System.Drawing.Point(16, 101);
            this.LstClientes.Name = "LstClientes";
            this.LstClientes.Size = new System.Drawing.Size(240, 251);
            this.LstClientes.TabIndex = 4;
            this.LstClientes.DoubleClick += new System.EventHandler(this.LstClientes_DoubleClick);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(288, 165);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(67, 16);
            this.LblNombre.TabIndex = 5;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellidos.Location = new System.Drawing.Point(288, 199);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(78, 16);
            this.LblApellidos.TabIndex = 6;
            this.LblApellidos.Text = "Apellidos:";
            // 
            // LblCiudad
            // 
            this.LblCiudad.AutoSize = true;
            this.LblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCiudad.Location = new System.Drawing.Point(288, 231);
            this.LblCiudad.Name = "LblCiudad";
            this.LblCiudad.Size = new System.Drawing.Size(61, 16);
            this.LblCiudad.TabIndex = 7;
            this.LblCiudad.Text = "Ciudad:";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(288, 264);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(56, 16);
            this.LblEmail.TabIndex = 8;
            this.LblEmail.Text = "E-mail:";
            // 
            // LblComentario
            // 
            this.LblComentario.AutoSize = true;
            this.LblComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComentario.Location = new System.Drawing.Point(288, 295);
            this.LblComentario.Name = "LblComentario";
            this.LblComentario.Size = new System.Drawing.Size(91, 16);
            this.LblComentario.TabIndex = 9;
            this.LblComentario.Text = "Comentario:";
            // 
            // LblVip
            // 
            this.LblVip.AutoSize = true;
            this.LblVip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVip.Location = new System.Drawing.Point(288, 358);
            this.LblVip.Name = "LblVip";
            this.LblVip.Size = new System.Drawing.Size(36, 16);
            this.LblVip.TabIndex = 10;
            this.LblVip.Text = "VIP:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(385, 165);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(275, 22);
            this.TxtNombre.TabIndex = 11;
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidos.Location = new System.Drawing.Point(385, 199);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(275, 22);
            this.TxtApellidos.TabIndex = 12;
            // 
            // TxtCiudad
            // 
            this.TxtCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCiudad.Location = new System.Drawing.Point(385, 231);
            this.TxtCiudad.Name = "TxtCiudad";
            this.TxtCiudad.Size = new System.Drawing.Size(275, 22);
            this.TxtCiudad.TabIndex = 13;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(385, 264);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(275, 22);
            this.TxtEmail.TabIndex = 14;
            // 
            // TxtComentario
            // 
            this.TxtComentario.AcceptsReturn = true;
            this.TxtComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtComentario.Location = new System.Drawing.Point(385, 299);
            this.TxtComentario.Multiline = true;
            this.TxtComentario.Name = "TxtComentario";
            this.TxtComentario.Size = new System.Drawing.Size(275, 53);
            this.TxtComentario.TabIndex = 15;
            // 
            // ChkVip
            // 
            this.ChkVip.AutoSize = true;
            this.ChkVip.Location = new System.Drawing.Point(385, 358);
            this.ChkVip.Name = "ChkVip";
            this.ChkVip.Size = new System.Drawing.Size(15, 14);
            this.ChkVip.TabIndex = 16;
            this.ChkVip.UseVisualStyleBackColor = true;
            // 
            // PctFoto
            // 
            this.PctFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctFoto.Location = new System.Drawing.Point(406, 8);
            this.PctFoto.Name = "PctFoto";
            this.PctFoto.Size = new System.Drawing.Size(229, 141);
            this.PctFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctFoto.TabIndex = 17;
            this.PctFoto.TabStop = false;
            this.PctFoto.Click += new System.EventHandler(this.PctFoto_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Image = global::WindowsFormsClientes.Properties.Resources.eliminar_32x32;
            this.BtnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBorrar.Location = new System.Drawing.Point(130, 12);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(53, 53);
            this.BtnBorrar.TabIndex = 2;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Image = global::WindowsFormsClientes.Properties.Resources.guardar_archivo_32x32;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGuardar.Location = new System.Drawing.Point(71, 12);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(53, 53);
            this.BtnGuardar.TabIndex = 1;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Image = global::WindowsFormsClientes.Properties.Resources.estrella_32x32;
            this.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNuevo.Location = new System.Drawing.Point(12, 12);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(53, 53);
            this.BtnNuevo.TabIndex = 0;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // FrmAltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(672, 378);
            this.Controls.Add(this.PctFoto);
            this.Controls.Add(this.ChkVip);
            this.Controls.Add(this.TxtComentario);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtCiudad);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblVip);
            this.Controls.Add(this.LblComentario);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblCiudad);
            this.Controls.Add(this.LblApellidos);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LstClientes);
            this.Controls.Add(this.LblClientes);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAltas";
            this.Text = "Alta de Clientes";
            this.Activated += new System.EventHandler(this.FrmAltas_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.PctFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Label LblClientes;
        private System.Windows.Forms.ListBox LstClientes;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.Label LblCiudad;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblComentario;
        private System.Windows.Forms.Label LblVip;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.TextBox TxtCiudad;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtComentario;
        private System.Windows.Forms.CheckBox ChkVip;
        private System.Windows.Forms.PictureBox PctFoto;
        private System.Windows.Forms.OpenFileDialog OpnFleDiaFoto;
    }
}