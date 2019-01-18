using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    public partial class Desayuno: Comida
    {
        public Desayuno(int N, string Nombre)
            :base(N,Nombre)
        {

            Categoria = "Desayuno";     //La categoria la asignamos aquí, no en la clase comida

            if (Nombre == "Botes de Bannana")
            {
                this.Costo = 20;
                return;
            }
            if (Nombre == "Burritos")
            {
                this.Costo = 30;
                return;
            }
            if (Nombre == "Pan de Calabaza")
            {
                this.Costo = 25;
                return;
            }
            if (Nombre == "Panqué de Elote")
            {
                this.Costo = 15;
                return;
            }
            else
            {
                this.Costo = 22;
                return;
            }
        }

        
    }
}
