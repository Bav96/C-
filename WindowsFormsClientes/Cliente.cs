using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsClientes
{
    public class Cliente
    {
        private string _nombre;
        private string _apellidos;
        private string _ciudad;
        private string _email;
        private string _comentario;
        private bool _vip;
        private string _rutaFoto;

        public Cliente( string nombre, string apellidos, string ciudad, string email,
                        string comentario, bool vip, string rutaFoto)
        {
            _nombre = nombre;
            _apellidos = apellidos;
            _ciudad = ciudad;
            _email = email;
            _comentario = comentario;
            _vip = vip;
            _rutaFoto = rutaFoto;
        }

        //Getters y Setters
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
        public string Ciudad { get => _ciudad; set => _ciudad = value; }
        public string Email { get => _email; set => _email = value; }
        public string Comentario { get => _comentario; set => _comentario = value; }
        public bool Vip { get => _vip; set => _vip = value; }
        
        //otra sintaxix de los getters y los setters. Evito que se le asigne "null" a
        //la ruta de la foto
        public string RutaFoto
        {
            get { return _rutaFoto; }
            set {
                if (value != null) _rutaFoto = value;
                else _rutaFoto = "";
            } 
        }

        // Devuelve un nº negativo si c1<c2, cero si c1=c2, y un nº positivo si c1>c2
        public static int ComparaPorApellidosNombre (Cliente c1, Cliente c2)
        {
            int comparacion = String.Compare(c1.Apellidos, c2.Apellidos);

            if (comparacion == 0)
                comparacion = String.Compare(c1.Nombre, c2.Nombre);

            return comparacion;
        }
    }
}
