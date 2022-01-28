using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion
{
    class Barco
    {
        private string Matricula;
        private double LargoM;
        private int AñoF;

        public Barco(string Matricula, double LargoM, int AñoF)
        {
            this.Matricula = Matricula;
            this.LargoM = LargoM;
            this.AñoF = AñoF;
        }
        public string getMatricula()
        {

            return Matricula;
        }
        public void setMatricula(string Matricula)
        {
            this.Matricula = Matricula;
        }
        public double getLargoM()
        {

            return LargoM;
        }
        public void setLargoM(double LargoM)
        {
            this.LargoM = LargoM;
        }
        public int getAñoF()
        {

            return AñoF;
        }
        public void setAñoF(int AñoF)
        {
            this.AñoF = AñoF;
        }
        public void imprimirBarco()
        {
            {
                Console.Write("Ingrese la matricula del barco: ");
                Matricula = Console.ReadLine();

                Console.Write("Ingrese el largo en metros del barco: ");
                LargoM = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el año de fabricacion del barco: ");
                AñoF = int.Parse(Console.ReadLine());

            }
        }
    } 
    class TipoBarco
    {
        private int mástiles;
        private int potencia;
        private int camarotes;

        public TipoBarco(int mástiles, int potencia, int camarotes)
        {
            this.mástiles = mástiles;
            this.potencia = potencia;
            this.camarotes = camarotes;
        }
        public int getmástiles()
        {

            return mástiles;
        }
        public void setmástiles(int mástiles)
        {
            this.mástiles = mástiles;
        }
        public int getpotencia()
        {

            return potencia;
        }
        public void setpotencia(int potencia)
        {
            this.potencia = potencia;
        }
        public int getcamarotes()
        {

            return camarotes;
        }
        public void setcamarotes(int camarotes)
        {
            this.camarotes = camarotes;
        }
        public void imprimirTipoBarco()
        {
            {
                Console.Write("Ingrese la fecha inicial de alquiler: ");
                mástiles = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la fecha inal de alquiler: ");
                potencia = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la posición del amarre : ");
                camarotes = int.Parse(Console.ReadLine());


            }
        }
    }
    class consulta
    {
        LargoM * 0.2;

        public void imprimirConsulta()
        {
        }

    }
}
