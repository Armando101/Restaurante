using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante.ComidasForm
{
    public partial class Postres : Form
    {
        public PostresCod Po;
        public Postres()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

            Po = new PostresCod(Convert.ToInt32(this.UpDownDesa.Value), this.CBPost.Text);

        }

        private void buttonDesc_Click(object sender, EventArgs e)
        {

            if (CBPost.Text == "Volcán de Chocolate")
            {
            
                this.pictureBoxpost.Image = global::Restaurante.Properties.Resources.Volcan;
                MessageBox.Show("Relleno de Chocolate, Acompañado con helado de vainilla $50");

                return;
            }
            if (CBPost.Text == "Alfafor")
            {

                this.pictureBoxpost.Image = global::Restaurante.Properties.Resources.Alfafor;
                MessageBox.Show("Pasta Hojaldre Cubierta de Dulce de Leche, Nuez y Azúcar Glass $45");

                return;
            }
            if (CBPost.Text == "Strudel de Manzana")
            {

                this.pictureBoxpost.Image = global::Restaurante.Properties.Resources.Strudel;
                MessageBox.Show("Pasta Hojaldre, Relleno de Manzana y Acompañado de helado $70");

                return;
            }
            if (CBPost.Text == "Flan Napolitano")
            {

                this.pictureBoxpost.Image = global::Restaurante.Properties.Resources.Flan;
                MessageBox.Show("Tradicional con Dulce de Leche $65");

                return;
            }
            if (CBPost.Text == "Helados")
            {

                this.pictureBoxpost.Image = global::Restaurante.Properties.Resources.Helados;
                MessageBox.Show("Vainilla, Chocolate, Fresa, Limón $30");

                return;
            }
            if (CBPost.Text == "Platanos Flambee")
            {

                this.pictureBoxpost.Image = global::Restaurante.Properties.Resources.PlatanosFlam;
                MessageBox.Show("Flameados con Licor de Platano y Brandy, Acompañado con Heldo de Vainilla  $70");

                return;
            }
            else
                return;

        }
    }
}
