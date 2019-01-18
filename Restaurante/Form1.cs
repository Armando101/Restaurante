using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurante.ComidasForm;

namespace Restaurante
{
    public partial class FormPrinc : Form
    {
        List<Comida> Lis = new List<Comida>();
        
        public FormPrinc()
        {
            InitializeComponent();
        }

        private void labelDesayuno_Click(object sender, EventArgs e)
        {
            Desayunos D = new Desayunos();
            D.ShowDialog();                     //Creamos el formlario para desayunos

            Agregaralista(D.Des);         //Lo agrgamos a la lista del pedido

        }   //Abre la ventana de desayuno
        
        private void buttonTerm_Click(object sender, EventArgs e)
        {
            string s = "";
            double tot = 0;
            Ticket T = new Ticket();
            if (Lis.Count == 0)
            {
                MessageBox.Show("No ha tomado su orden");
                return;
            }
            for (int i = 0; i <Lis.Count; i++)
            {
                s = s + Lis[i].Categoria + "   " + Lis[i].Numero.ToString() + "   " + Lis[i].nombre + "   $" + (Lis[i].Costo * Lis[i].Numero).ToString() + "\n";
                tot = tot + Lis[i].Costo * Lis[i].Numero;
            }

            s = s + "\n" + "Total.....$" + tot.ToString() + "\n\n\t En unos minutos estará lista su orden";

            T.Imprime(s, false);

            Lis.Clear();        //Aquí vacia la lista para dejara preparada para el siguiente cliente
        }   //Toma la orden final

        private void labelQyS_Click(object sender, EventArgs e)
        {
            Quejas_y_Sugerencias QyS = new Quejas_y_Sugerencias();
            QyS.ShowDialog();
            MessageBox.Show("Gracias por su comentario");
        }   //Abre la ventana de Quejas y Sugrencias

            //Permite ver la orden antes de Pedir la orden final
        private void label1_Click(object sender, EventArgs e)       //Este método e idéntico al meto método de tomar orden excepto por que en este caso no vacía la lista
        {
            string s = "";
            double tot = 0;
            Ticket T = new Ticket();
            if (Lis.Count == 0)
            {
                MessageBox.Show("No ha tomado su orden");
                return;
            }
            for (int i = 0; i < Lis.Count; i++)
            {
                s = s + Lis[i].Categoria + "   " + Lis[i].Numero.ToString() + "   " + Lis[i].nombre + "   $" + (Lis[i].Costo * Lis[i].Numero).ToString() + "\n";
                tot = tot + Lis[i].Costo * Lis[i].Numero;
            }

            s = s + "\n" + "Total.....$" + tot.ToString();

            T.Imprime(s, true);
        }

        private void labelCarne_Click(object sender, EventArgs e)
        {
            CarnesFor Car = new CarnesFor();
            Car.ShowDialog();

            Agregaralista(Car.Carne);   
            
        }   //Permite abrir la ventana de carnes

        private void Agregaralista(Comida C)
        {
            if (C == null)  //Se Considera el caso en el que el usuaro haya abieto una vemtana y la haya cerrado sin agregar nada
                return;
            else
                Lis.Add(C);
        }   //Este método permite agregar a la lista la comida sí y sólo sí el usuario selecciono algo al abrir la ventana

        private void labelEnsa_Click(object sender, EventArgs e)
        {
            EnsaladasForm EnF = new EnsaladasForm();
            EnF.ShowDialog();

            Agregaralista(EnF.En);
        }

        private void labelPostres_Click(object sender, EventArgs e)
        {
            Postres P = new Postres();
            P.ShowDialog();

            Agregaralista(P.Po);
        }

        private void labelBebidas_Click(object sender, EventArgs e)
        {
            BebidasForm B = new BebidasForm();
            B.ShowDialog();

            Agregaralista(B.Be);
        }
    }
}
