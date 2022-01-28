using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion
{
    class Cliente
    {
        private string Nombre;
        private string Apellido;
        private int Cedula;

        Cliente(string Nombre, string Apellido, int Cedula)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Cedula = Cedula;
        }
        public string getNombre()
        {

            return Nombre;
        }
        public void setNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }
        public string getApellido()
        {

            return Apellido;
        }
        public void setApellido(string Apellido)
        {
            this.Apellido = Apellido;
        }
        public int getCedula()
        {

            return Cedula;
        }
        public void setCedula(int Cedula)
        {
            this.Cedula = Cedula;
        }
        public void imprimirCliente()
        {
            {
                Console.Write("Ingrese el nombre del cliente: ");
                Nombre = Console.ReadLine();

                Console.Write("Ingrese el apellido del cliente: ");
                Apellido = Console.ReadLine();

                Console.Write("Ingrese la Cedula del cliente: ");
                Cedula = int.Parse(Console.ReadLine());

            }
        }

    }
}
