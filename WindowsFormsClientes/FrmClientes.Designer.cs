
namespace WindowsFormsClientes
{
    partial class FrmClientes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Mnu = new System.Windows.Forms.MenuStrip();
            this.MnuAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuConsultaList = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuConsultaTree = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mnu
            // 
            this.Mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAlta,
            this.MnuConsultaList,
            this.MnuConsultaTree,
            this.MnuSalir});
            this.Mnu.Location = new System.Drawing.Point(0, 0);
            this.Mnu.Name = "Mnu";
            this.Mnu.Size = new System.Drawing.Size(672, 24);
            this.Mnu.TabIndex = 0;
            this.Mnu.Text = "menuStrip1";
            // 
            // MnuAlta
            // 
            this.MnuAlta.Name = "MnuAlta";
            this.MnuAlta.Size = new System.Drawing.Size(40, 20);
            this.MnuAlta.Text = "Alta";
            this.MnuAlta.Click += new System.EventHandler(this.MnuAlta_Click);
            // 
            // MnuConsultaList
            // 
            this.MnuConsultaList.Name = "MnuConsultaList";
            this.MnuConsultaList.Size = new System.Drawing.Size(84, 20);
            this.MnuConsultaList.Text = "Consulta list";
            this.MnuConsultaList.Click += new System.EventHandler(this.MnuConsultaList_Click);
            // 
            // MnuConsultaTree
            // 
            this.MnuConsultaTree.Name = "MnuConsultaTree";
            this.MnuConsultaTree.Size = new System.Drawing.Size(89, 20);
            this.MnuConsultaTree.Text = "Consulta tree";
            this.MnuConsultaTree.Click += new System.EventHandler(this.MnuConsultaTree_Click);
            // 
            // MnuSalir
            // 
            this.MnuSalir.Name = "MnuSalir";
            this.MnuSalir.Size = new System.Drawing.Size(41, 20);
            this.MnuSalir.Text = "Salir";
            this.MnuSalir.Click += new System.EventHandler(this.MnuSalir_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 400);
            this.Controls.Add(this.Mnu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Mnu;
            this.Name = "FrmClientes";
            this.Text = "Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmClientes_FormClosing);
            this.Mnu.ResumeLayout(false);
            this.Mnu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Mnu;
        private System.Windows.Forms.ToolStripMenuItem MnuAlta;
        private System.Windows.Forms.ToolStripMenuItem MnuConsultaList;
        private System.Windows.Forms.ToolStripMenuItem MnuConsultaTree;
        private System.Windows.Forms.ToolStripMenuItem MnuSalir;
    }
}

