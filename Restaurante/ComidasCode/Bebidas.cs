using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    public class Bebidas: Comida
    {
        public Bebidas(int N, string Nombre)
            :base(N, Nombre)
        {
            Categoria = "Bebida";
            if (Nombre == "Café Flameado Irlandés")
            {
                this.Costo = 50;
                return;
            }

            if (Nombre == "Café Flameado Francés")
            {
                this.Costo = 60;
                return;
            }

            if (Nombre == "Café Flameado Italiano")
            {
                this.Costo = 60;
                return;
            }

            if (Nombre == "Agua de Sabor")
            {
                this.Costo = 15;
                return;
            }

            if (Nombre == "Coca-Cola")
            {
                this.Costo = 20;
                return;
            }
            else
                nombre = "";    //Cahar Exepción

        }
    }
}
