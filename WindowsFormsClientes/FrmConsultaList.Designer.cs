
namespace WindowsFormsClientes
{
    partial class FrmConsultaList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaList));
            this.CboCiudad = new System.Windows.Forms.ComboBox();
            this.LblCiudad = new System.Windows.Forms.Label();
            this.CboVista = new System.Windows.Forms.ComboBox();
            this.LblVista = new System.Windows.Forms.Label();
            this.LvwClientes = new System.Windows.Forms.ListView();
            this.ImgLstPeques = new System.Windows.Forms.ImageList(this.components);
            this.ImgLstGrandes = new System.Windows.Forms.ImageList(this.components);
            this.PctFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PctFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // CboCiudad
            // 
            this.CboCiudad.FormattingEnabled = true;
            this.CboCiudad.Location = new System.Drawing.Point(165, 59);
            this.CboCiudad.Name = "CboCiudad";
            this.CboCiudad.Size = new System.Drawing.Size(226, 21);
            this.CboCiudad.TabIndex = 2;
            this.CboCiudad.DropDown += new System.EventHandler(this.CboCiudad_DropDown);
            this.CboCiudad.SelectedIndexChanged += new System.EventHandler(this.CboCiudad_SelectedIndexChanged);
            // 
            // LblCiudad
            // 
            this.LblCiudad.AutoSize = true;
            this.LblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCiudad.Location = new System.Drawing.Point(162, 30);
            this.LblCiudad.Name = "LblCiudad";
            this.LblCiudad.Size = new System.Drawing.Size(61, 16);
            this.LblCiudad.TabIndex = 8;
            this.LblCiudad.Text = "Ciudad:";
            // 
            // CboVista
            // 
            this.CboVista.FormattingEnabled = true;
            this.CboVista.Items.AddRange(new object[] {
            "Detalles",
            "Iconos grandes",
            "Iconos pequeños",
            "Lista",
            "Mosaico"});
            this.CboVista.Location = new System.Drawing.Point(419, 59);
            this.CboVista.Name = "CboVista";
            this.CboVista.Size = new System.Drawing.Size(182, 21);
            this.CboVista.TabIndex = 9;
            this.CboVista.SelectedIndexChanged += new System.EventHandler(this.CboVista_SelectedIndexChanged);
            // 
            // LblVista
            // 
            this.LblVista.AutoSize = true;
            this.LblVista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVista.Location = new System.Drawing.Point(416, 30);
            this.LblVista.Name = "LblVista";
            this.LblVista.Size = new System.Drawing.Size(47, 16);
            this.LblVista.TabIndex = 10;
            this.LblVista.Text = "Vista:";
            // 
            // LvwClientes
            // 
            this.LvwClientes.HideSelection = false;
            this.LvwClientes.Location = new System.Drawing.Point(12, 118);
            this.LvwClientes.Name = "LvwClientes";
            this.LvwClientes.Size = new System.Drawing.Size(648, 232);
            this.LvwClientes.TabIndex = 11;
            this.LvwClientes.UseCompatibleStateImageBehavior = false;
            this.LvwClientes.View = System.Windows.Forms.View.Details;
            // 
            // ImgLstPeques
            // 
            this.ImgLstPeques.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgLstPeques.ImageStream")));
            this.ImgLstPeques.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgLstPeques.Images.SetKeyName(0, "usuarios");
            this.ImgLstPeques.Images.SetKeyName(1, "estrella");
            // 
            // ImgLstGrandes
            // 
            this.ImgLstGrandes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgLstGrandes.ImageStream")));
            this.ImgLstGrandes.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgLstGrandes.Images.SetKeyName(0, "usuarios");
            this.ImgLstGrandes.Images.SetKeyName(1, "estrella");
            // 
            // PctFoto
            // 
            this.PctFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PctFoto.Image = global::WindowsFormsClientes.Properties.Resources.ciclista;
            this.PctFoto.Location = new System.Drawing.Point(12, 12);
            this.PctFoto.Name = "PctFoto";
            this.PctFoto.Size = new System.Drawing.Size(100, 100);
            this.PctFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctFoto.TabIndex = 1;
            this.PctFoto.TabStop = false;
            // 
            // FrmConsultaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(672, 378);
            this.Controls.Add(this.LvwClientes);
            this.Controls.Add(this.LblVista);
            this.Controls.Add(this.CboVista);
            this.Controls.Add(this.LblCiudad);
            this.Controls.Add(this.CboCiudad);
            this.Controls.Add(this.PctFoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaList";
            this.Text = "Consulta clientes";
            this.Activated += new System.EventHandler(this.FrmConsultaList_Activated);
            this.Load += new System.EventHandler(this.FrmConsultaList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PctFoto;
        private System.Windows.Forms.ComboBox CboCiudad;
        private System.Windows.Forms.Label LblCiudad;
        private System.Windows.Forms.ComboBox CboVista;
        private System.Windows.Forms.Label LblVista;
        private System.Windows.Forms.ListView LvwClientes;
        private System.Windows.Forms.ImageList ImgLstPeques;
        private System.Windows.Forms.ImageList ImgLstGrandes;
    }
}