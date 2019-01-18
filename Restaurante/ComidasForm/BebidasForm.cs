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
    public partial class BebidasForm : Form
    {
        public Bebidas Be;
        public BebidasForm()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

            Be = new Bebidas(Convert.ToInt32(this.UpDownDesa.Value), this.CBBeb.Text);

        }

        private void buttonDesc_Click(object sender, EventArgs e)
        {
            if (CBBeb.Text == "Café Flameado Irlandés")
            {
                this.pictureBoxBeb.Image = global::Restaurante.Properties.Resources.Café_Irlandés;
                MessageBox.Show("Whisky, Licor de Café, Americano, Express y Chantilly $50");
                

                return;
            }

            if (CBBeb.Text == "Café Flameado Francés")
            {
                this.pictureBoxBeb.Image = global::Restaurante.Properties.Resources.Frances;

                MessageBox.Show("Cognac, Licor de Café, Americano, Express y Chatilly $60");
                return;
            }

            if (CBBeb.Text == "Café Flameado Italiano")
            {

                this.pictureBoxBeb.Image = global::Restaurante.Properties.Resources.Italiano;

                MessageBox.Show("Licor de Avellana, Licor de Café, Americano Express y Chantilly $60");
                return;
            }

            if (CBBeb.Text == "Agua de Sabor")
            {

                this.pictureBoxBeb.Image = global::Restaurante.Properties.Resources.Agua;

                MessageBox.Show("Crema de Coco, Limón, Avena, Naranja $15");

                return;
            }

            if (CBBeb.Text == "Coca-Cola")
            {


                this.pictureBoxBeb.Image = global::Restaurante.Properties.Resources.Coca;

                MessageBox.Show("500 ml $20");
                return;
            }
            else
                return;




        }
    }
}
