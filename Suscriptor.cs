using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase.Entidades
{
    public class Suscriptor
    {
        private string Nombre;
        private string Apellido;
        private string Direccion;
        private string Email;
        private string Telefono;


        public Suscriptor(string nombre, string apellido, string direccion, string mail, string tel)
        {
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Email = mail;
            Telefono = tel;
        }

        public string nombre
        {
            get => Nombre;
            set => Nombre = value;
        }

        public string apellido
        {
            get => Apellido;
            set => Apellido = value;
        }
        public string direccion
        {
            get => Direccion;
            set => Direccion = value;
        }
        public string mail
        {
            get => Email;
            set => Email = value;
        }
        public string tel { 
            get => Telefono;
            set => Telefono = value;
        }
    }

}

