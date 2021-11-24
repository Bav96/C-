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
    public enum Icono
    {
        City,
        CitySelected,
        User,
        UserSelected,
        Vip,
        VipSelected
    }

    public partial class FrmConsultaTree : Form
    {
        List<Cliente> FicheroClientes;
        
        public FrmConsultaTree( List<Cliente> fichCli)
        {
            InitializeComponent();
            FicheroClientes = fichCli;

            TvwClientes.ImageList = ImgListIconos;
        }

        private void ActualizarTvwClientes()
        {
            bool ciudadEncontrada;
            int i;
            TreeNode nodo;

            TvwClientes.BeginUpdate();
            TvwClientes.Nodes.Clear();

            // Añado las ciudades de la lista de clientes al TreeView.
            foreach (Cliente cli in FicheroClientes)
            {
                ciudadEncontrada = false;
                for (i = 0; i < TvwClientes.Nodes.Count && !ciudadEncontrada; i++)
                    if (TvwClientes.Nodes[i].Text.Equals(cli.Ciudad))
                        ciudadEncontrada = true;

                if (!ciudadEncontrada)
                {
                    nodo = new TreeNode(cli.Ciudad,(int)Icono.City,(int)Icono.CitySelected);
                    TvwClientes.Nodes.Add(nodo);
                }
            }

            // Añado los clientes de la lista de clientes al nodo del TreeView correspondiente
            // a su ciudad.
            foreach (Cliente cli in FicheroClientes)
            {
                ciudadEncontrada = false;
                for (i = 0; i < TvwClientes.Nodes.Count && !ciudadEncontrada; i++)
                    if (TvwClientes.Nodes[i].Text.Equals(cli.Ciudad))
                    {
                        ciudadEncontrada = true;
                        if (cli.Vip)
                            nodo = new TreeNode(cli.Apellidos + "," + cli.Nombre,
                                                (int)Icono.Vip, (int)Icono.VipSelected);
                        else
                            nodo = new TreeNode(cli.Apellidos + "," + cli.Nombre,
                                                (int)Icono.User, (int)Icono.UserSelected);
                        TvwClientes.Nodes[i].Nodes.Add(nodo);
                    }
            }

            TvwClientes.EndUpdate();
        }

        private void LimpiarCampos()
        {
            //Con el siguiente bucle limpio todos los "TextBox" del formulario
            foreach (Control control in this.Controls)
                if (control.GetType().Equals(typeof(TextBox)))
                    ((TextBox)control).Clear();

            PctFoto.Image = null;
        }

        private void FrmConsultaTree_Activated(object sender, EventArgs e)
        {
            ActualizarTvwClientes();
            LimpiarCampos();
        }

        private void TvwClientes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (TvwClientes.SelectedNode.Level == 1)
            {
                //Separo los apellidos y el nombre del texto de la etiqueta del nodo del arbol
                //en un vector de Strings
                String nombreCli = TvwClientes.SelectedNode.Text;
                String [] apeNombre = nombreCli.Split(',');
                
                //Busco en la lista de clientes a uno que coincida en nombre y appelidos, parando
                //de buscar cuando encuentro la primera coincidencia.
                foreach (Cliente cli in FicheroClientes)
                    if (cli.Nombre == apeNombre[1] && cli.Apellidos == apeNombre[0])
                    {
                        TxtNombre.Text = cli.Nombre;
                        TxtApellidos.Text = cli.Apellidos;
                        TxtCiudad.Text = cli.Ciudad;
                        TxtEmail.Text = cli.Email;
                        TxtComentario.Text = cli.Comentario;
                                                
                        if (String.IsNullOrEmpty(cli.RutaFoto))
                            PctFoto.Image = null;
                        else
                            PctFoto.Image = new Bitmap(cli.RutaFoto);

                        break;
                    }
            }
        }
    }
}
