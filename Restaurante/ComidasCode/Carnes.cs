using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    public partial class Carnes : Comida
    {
        public Carnes(int N, string Nombre)
            :base(N, Nombre)
        {
            Categoria = "Carne";    

            if (Nombre == "Bife de Salmón a las Brasas")
            {
                this.Costo = 130;
                return;
            }
            if (Nombre == "Ojo de Bife")
            {
                this.Costo = 450;
                return;
            }
            if (Nombre == "Milanesa de Pollo")
            {
                this.Costo = 93;
                return;
            }
            if (Nombre == "Milanesa de Lomo")
            {
                this.Costo = 100;
                return;
            }
            if (Nombre == "Camarones al Ajillo")
            {
                this.Costo = 135;
                return;
            }
            if (Nombre == "Parrillada Argentina")
            {
                this.Costo = 400;
                return;
            }
            else
                nombre = "";    //Cahar Exepción


        }


    }
}
