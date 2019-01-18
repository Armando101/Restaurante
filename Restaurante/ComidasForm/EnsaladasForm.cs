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
    public partial class EnsaladasForm : Form
    {
        public Ensaladas En;


        public EnsaladasForm()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

            En = new Ensaladas(Convert.ToInt32(this.UpDownEns.Value), this.CBEns.Text);

        }

        private void buttonDesc_Click(object sender, EventArgs e)
        {
            if (CBEns.Text == "Ensalada FI´s Family")
            {
            
                this.pictureBoxEns.Image = global::Restaurante.Properties.Resources.FIsFamily;
                MessageBox.Show("Lechugas Mixtas, Espinacas, Berros\nChampiñones, Germen de Alfalfa, Germen de Soya\nNuez y Tocino  $87");

                return;
            }

            if (CBEns.Text == "Julio César")
            {

                this.pictureBoxEns.Image = global::Restaurante.Properties.Resources.JulioC;
                MessageBox.Show("Lechugas Mixtas, Uvas Verdes, Queso de Cabra\nNuez y Adereso de Chabacano  $88");

                return;
            }

            if (CBEns.Text == "Argentina")
            {

                this.pictureBoxEns.Image = global::Restaurante.Properties.Resources.Argentina;
                MessageBox.Show("Lechuga, Jitomate, Cebolla Morada, Zanahoria\nAdereso Argentino  $74");

                return;
            }
            if (CBEns.Text == "Mixta")
            {

                this.pictureBoxEns.Image = global::Restaurante.Properties.Resources.Mixta;
                MessageBox.Show("Lechugas Frescas, Huevo, Alcachofa, Zanahoria\nPalmitos, Jitomate y Aceitunas Negras $82");

                return;
            }
            if (CBEns.Text == "Dine")
            {

                this.pictureBoxEns.Image = global::Restaurante.Properties.Resources.Dine;
                MessageBox.Show("Lechuga, Espinacas, Queso de Cabra, Higos Secos, Nuez Picada\nAderezo Especial $84");

                return;
            }
            if (CBEns.Text == "César")
            {

                this.pictureBoxEns.Image = global::Restaurante.Properties.Resources.César;
                MessageBox.Show("Lechugas Frescas, Orégao Bañadda con Adereso Parmesano  $89");

                return;
            }
            if (CBEns.Text == "De la Granja")
            {

                this.pictureBoxEns.Image = global::Restaurante.Properties.Resources.DelaGranj;
                MessageBox.Show("Lechugas Frescas, Pollo, Pera, Nuez Picada, Queso azul\nTonillo y Aderezo de Miel con Mostaza  $89");

                return;
            }
            else
                return;


        }

    }
}
