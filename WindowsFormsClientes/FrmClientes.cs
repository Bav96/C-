using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClientes
{
    public partial class FrmClientes : Form
    {
        //Lista donde almaceno todos los clientes de la empresa.
        List<Cliente> FicheroClientes;

        public FrmClientes()
        {
            InitializeComponent();
            FicheroClientes = new List<Cliente>();

            FicheroClientes.Add(new Cliente("DANI", "PÉREZ", "MADRID", "d@g.com", "Coment1", false, null));
            FicheroClientes.Add(new Cliente("ISA", "GÓMEZ", "BARCELONA", "i@g.com", "Coment2", true, null));
            FicheroClientes.Add(new Cliente("JUAN", "MEDRANO", "MADRID", "j@g.com", "Coment3", true, null));
            FicheroClientes.Sort(Cliente.ComparaPorApellidosNombre);
        }

        private void MnuAlta_Click(object sender, EventArgs e)
        {
            FrmAltas formulario = null;

            foreach (Form frm in this.MdiChildren)
                if (frm.Name.Equals("FrmAltas"))
                {
                    formulario = (FrmAltas)frm;
                    break;
                }

            if (formulario == null)
            {
                formulario = new FrmAltas(FicheroClientes);
                formulario.MdiParent = this;
                formulario.Dock = DockStyle.Fill;
                formulario.Show();
            }
            else
                formulario.Activate();

            this.Text = formulario.Text;
        }

        private void MnuConsultaList_Click(object sender, EventArgs e)
        {
            FrmConsultaList formulario = null;

            foreach (Form frm in this.MdiChildren)
                if (frm.Name.Equals("FrmConsultaList"))
                {
                    formulario = (FrmConsultaList)frm;
                    break;
                }

            if (formulario == null)
            {
                formulario = new FrmConsultaList(FicheroClientes);
                formulario.MdiParent = this;
                formulario.Dock = DockStyle.Fill;
                formulario.Show();
            }
            else
                formulario.Activate();

            this.Text = formulario.Text;
        }

        private void MnuConsultaTree_Click(object sender, EventArgs e)
        {
            FrmConsultaTree formulario = null;

            foreach (Form frm in this.MdiChildren)
                if (frm.Name.Equals("FrmConsultaTree"))
                {
                    formulario = (FrmConsultaTree) frm;
                    break;
                }
            if (formulario == null)
            {
                formulario = new FrmConsultaTree(FicheroClientes);
                formulario.MdiParent = this;
                formulario.Dock = DockStyle.Fill;
                formulario.Show();
            }
            else
                formulario.Activate();
        }

        private void MnuSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea salir?", "Salir",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
                Environment.Exit(0);
                // no puedo usar this.Close(), porque entonces se lanza el evento FormClosing
                // del formulario, y vuelve a salir el MessageBox.
        }

        private void FrmClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea salir?", "Salir",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
                e.Cancel = true;
        }
    }
}
