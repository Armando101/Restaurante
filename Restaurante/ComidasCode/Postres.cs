using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    public class PostresCod: Comida
    {
        public PostresCod(int N, string Nombre)
            :base(N, Nombre)
        {
            Categoria = "Postre";
            if (Nombre == "Volcán de Chocolate")
            {
                this.Costo = 50;
                return;
            }
            if (Nombre == "Alfafor")
            {
                this.Costo = 45;
                return;
            }
            if (Nombre == "Strudel de Manzana")
            {
                this.Costo = 70;
                return;
            }
            if (Nombre == "Flan Napolitano")
            {
                this.Costo = 65;
                return;
            }
            if (Nombre == "Helados")
            {
                this.Costo = 30;
                return;
            }
            if (Nombre == "Platanos Flambee")
            {
                this.Costo = 70;
                return;
            }
            else
                return;
        }
    }
}
