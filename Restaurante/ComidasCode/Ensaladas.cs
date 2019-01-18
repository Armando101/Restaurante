using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    public class Ensaladas: Comida
    {

        public Ensaladas (int N, string Nombre)
            :base(N,Nombre)
        {
            Categoria = "Ensalada";     //La categoria la asignamos aquí, no en la clase comida

            if (Nombre == "Ensalada FI´s Family")
            {
                this.Costo = 87;
                return;
            }
            if (Nombre == "Julio César")
            {
                this.Costo = 88;
                return;
            }
            if (Nombre == "Argentina")
            {
                this.Costo = 74;
                return;
            }
            if (Nombre == "Mixta")
            {
                this.Costo = 82;
                return;
            }
            if (Nombre == "Dine")
            {
                this.Costo = 84;
                return;
            }
            if (Nombre == "César")
            {
                this.Costo = 89;
                return;
            }
            if (Nombre == "César")
            {
                this.Costo = 89;
                return;
            }
            if (Nombre == "De la Granja")
            {
                this.Costo = 89;
                return;
            }
            else
                return;     //Cachar excepción





        }
        

    }
}
