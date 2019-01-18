using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    //Clase abstracta
    public class Comida
    {
        public int Numero;      //Número de platillos
        public string nombre;   //Nombre del platillo
        public string Categoria;
        public string Descrip;
        public double Costo;

        public Comida(int N, string S)
        {
            this.Numero = N;
            this.nombre = S;
        }

        //Encapsulamiento

        protected static string nomEmp = "FI´s Family";     //Nombre del restaurante

    }
}
