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
    public partial class FrmConsultaList : Form
    {
        List<Cliente> FicheroClientes;
        public FrmConsultaList(List<Cliente> fichCli)
        {
            InitializeComponent();
            FicheroClientes = fichCli;
        }

        private void LimpiarCampos()
        {
            LvwClientes.Items.Clear();
            CboCiudad.SelectedIndex = -1;
            CboVista.SelectedIndex = 0;
            // La anterior sentencia desencadena el evento "SelectedIndexChanged" del CboVista
            // con lo que se ejecuta el manejador de dicho evento, camnbiando la vista del
            // LstView a "View.Details"
        }

        private void FrmConsultaList_Load(object sender, EventArgs e)
        {
            // La cabecera de la ListView se podia haber configurado en el diseño, gráficamente,
            // pero he decido hacerlo por código al cargar el formulario en memoria.

            //Limpio la cabecera de la ListView, por si acaso ya tiene campos.
            LvwClientes.Columns.Clear();

            //Añados los campos a la cabecera de la ListView
            LvwClientes.Columns.Add("Nombre", 100, HorizontalAlignment.Left);
            LvwClientes.Columns.Add("Apellidos", 150, HorizontalAlignment.Left);
            LvwClientes.Columns.Add("E-mail", 150, HorizontalAlignment.Left);
            LvwClientes.Columns.Add("Comentario", 200, HorizontalAlignment.Left);

            //Añado las listas de imagenes a la ListView
            LvwClientes.SmallImageList = ImgLstPeques;
            LvwClientes.LargeImageList = ImgLstGrandes;
        }

        private void FrmConsultaList_Activated(object sender, EventArgs e)
        {
            this.LimpiarCampos();
        }

        private void CboCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboCiudad.SelectedIndex >= 0)
            {
                String ciudad = (String) CboCiudad.SelectedItem;

                LvwClientes.Items.Clear();
                foreach (Cliente cli in FicheroClientes)
                    if (cli.Ciudad.Equals(ciudad))
                    {
                        String icono;
                        if (cli.Vip) icono = "estrella";
                        else icono = "usuarios";

                        ListViewItem fila = new ListViewItem(cli.Nombre, icono);
                        fila.SubItems.Add(cli.Apellidos);
                        fila.SubItems.Add(cli.Email);
                        fila.SubItems.Add(cli.Comentario);
                        
                        LvwClientes.Items.Add(fila);
                    }
            }
        }

        private void CboCiudad_DropDown(object sender, EventArgs e)
        {
            foreach (Cliente cli in FicheroClientes)
                if (!CboCiudad.Items.Contains(cli.Ciudad))
                    CboCiudad.Items.Add(cli.Ciudad);
        }

        private void CboVista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboVista.SelectedIndex >=0)
            {
                String vista = (String) CboVista.SelectedItem;
                switch (vista)
                {
                    case "Detalles":
                        LvwClientes.View = View.Details;
                        break;
                    case "Iconos grandes":
                        LvwClientes.View = View.LargeIcon;
                        break;
                    case "Iconos pequeños":
                        LvwClientes.View = View.SmallIcon;
                        break;
                    case "Lista":
                        LvwClientes.View = View.List;
                        break;
                    case "Mosaico":
                        LvwClientes.View = View.Tile;
                        break;
                    default:
                        LvwClientes.View = View.Details;
                        break;
                }
            }
        }

    }
}
