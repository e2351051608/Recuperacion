using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion
{
    class Alquiler
    {
        private string FechaI;
        private string FechaF;
        private string PosicionA;

        public Alquiler(string FechaI, string FechaF, string PosicionA)
        {
            this.FechaI = FechaI;
            this.FechaF = FechaF;
            this.PosicionA = PosicionA;
        }
        public string getFechaI()
        {

            return FechaI;
        }
        public void setFechaI(string FechaI)
        {
            this.FechaI = FechaI;
        }
        public string getFechaF()
        {

            return FechaF;
        }
        public void setFechaF(string FechaF)
        {
            this.FechaF = FechaF;
        }
        public string getPosicionA()
        {

            return PosicionA;
        }
        public void setPosicionA(string PosicionA)
        {
            this.PosicionA = PosicionA;
        }
        public void imprimirAlquiler()
        {
            {
                Console.Write("Ingrese la fecha inicial de alquiler: ");
                FechaI = Console.ReadLine();

                Console.Write("Ingrese la fecha inal de alquiler: ");
                FechaF = Console.ReadLine();

                Console.Write("Ingrese la posición del amarre : ");
                PosicionA = Console.ReadLine();


            }
        }
    }
}
