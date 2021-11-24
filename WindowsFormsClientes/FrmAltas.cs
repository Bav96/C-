using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClientes
{
    public partial class FrmAltas : Form
    {
        List<Cliente> FicheroClientes;

        public FrmAltas(List<Cliente> fichCli)
        {
            InitializeComponent();
            FicheroClientes = fichCli;
        }

        private void LimpiarCampos()
        {
            //Con el siguiente bucle limpio todos los "TextBox" del formulario
            foreach (Control control in this.Controls)
                if (control.GetType().Equals(typeof(TextBox)))
                    ((TextBox)control).Clear();

            ChkVip.Checked = false;
            PctFoto.Image = null;
            OpnFleDiaFoto.FileName = "";
        }

        private void ActualizarLstClientes()
        {
            LstClientes.Items.Clear();
            foreach (Cliente cli in FicheroClientes)
                LstClientes.Items.Add(cli.Apellidos + "," + cli.Nombre);
        }

        private bool AlgunCampoObligatorioVacio()
        {
            bool algunoVacio = false;
            int i = 0;

            // Otra manera de recorrer los controles del formulario sin usar el bucle "foreach",
            // el cual te obliga a ejecutar "break" para salir del bucle cuando se cumpla una condicion.
            while (!algunoVacio && i< this.Controls.Count)
            {
                if (this.Controls[i].GetType().Equals(typeof(TextBox)) && this.Controls[i].Text == "")
                    algunoVacio = true;
                i++;
            }

            // La PctFoto y el ChkVip son opcionales (no oblogatorio rellenarlos)
            return algunoVacio;
        }
                
        private bool YaExisteCliente()
        {
            bool yaExiste = false;

            foreach (Cliente cli in FicheroClientes)
            {
                if (cli.Nombre.Equals(TxtNombre.Text) && cli.Apellidos.Equals(TxtApellidos.Text))
                {
                    yaExiste = true;
                    break;
                }
            }
            return yaExiste;
        }

        private bool EsEmail (String cad)
        {
            //Uso una expreión regular para validar el formato de la dirección de email.
            Regex expReg = new Regex("^\\w+([-.]\\w+)*@\\w+([-.]\\w+)*\\.[a-zA-Z]{2,6}$");
            return (expReg.IsMatch(cad));
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
        }

        private void FrmAltas_Activated(object sender, EventArgs e)
        {
            this.LimpiarCampos();
            this.ActualizarLstClientes();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (AlgunCampoObligatorioVacio())
                MessageBox.Show("Faltan campos obligatorios por rellenar.", "Error", MessageBoxButtons.OK,  MessageBoxIcon.Error);
            else if (YaExisteCliente())
                MessageBox.Show("Ya existe ese cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (! EsEmail(TxtEmail.Text))
                MessageBox.Show("Email con formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                TxtNombre.Text = TxtNombre.Text.ToUpper();
                TxtApellidos.Text = TxtApellidos.Text.ToUpper();
                TxtCiudad.Text = TxtCiudad.Text.ToUpper();

                Cliente cli = new Cliente(TxtNombre.Text, TxtApellidos.Text,
                                          TxtCiudad.Text, TxtEmail.Text, TxtComentario.Text,
                                          ChkVip.Checked, OpnFleDiaFoto.FileName);
                FicheroClientes.Add(cli);
                FicheroClientes.Sort(Cliente.ComparaPorApellidosNombre);
                ActualizarLstClientes();
            }

        }


        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (LstClientes.SelectedIndex >=0)
            {
                String nombreCli = (String) LstClientes.Items[LstClientes.SelectedIndex];
                String apell = nombreCli.Substring(0, nombreCli.LastIndexOf(','));
                String nombre = nombreCli.Substring(nombreCli.LastIndexOf(',') + 1);

                foreach (Cliente cli in FicheroClientes)
                    if (cli.Nombre == nombre && cli.Apellidos == apell)
                    {
                        FicheroClientes.Remove(cli);
                        ActualizarLstClientes();
                        break;
                    }
            }
        }

        private void PctFoto_Click(object sender, EventArgs e)
        {
            if (OpnFleDiaFoto.ShowDialog().Equals(DialogResult.OK))
                PctFoto.Image = new Bitmap(OpnFleDiaFoto.FileName);
        }

        private void LstClientes_DoubleClick(object sender, EventArgs e)
        {
            if (LstClientes.SelectedIndex >= 0)
            {
                String nombreCli = (String)LstClientes.Items[LstClientes.SelectedIndex];
                String apell = nombreCli.Substring(0, nombreCli.LastIndexOf(','));
                String nombre = nombreCli.Substring(nombreCli.LastIndexOf(',') + 1);

                foreach (Cliente cli in FicheroClientes)
                    if (cli.Nombre == nombre && cli.Apellidos == apell)
                    {
                        TxtNombre.Text = cli.Nombre;
                        TxtApellidos.Text = cli.Apellidos;
                        TxtCiudad.Text = cli.Ciudad;
                        TxtEmail.Text = cli.Email;
                        TxtComentario.Text = cli.Comentario;
                        ChkVip.Checked = cli.Vip;

                        OpnFleDiaFoto.FileName = cli.RutaFoto;
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
