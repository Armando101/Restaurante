using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace Restaurante
{
    public partial class Desayunos : Form
    {
        public Desayuno Des;
        
        public Desayunos()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

          Des = new Desayuno(Convert.ToInt32(this.UpDownDesa.Value), this.CBDes.Text);
 
        }

        private void buttonDesc_Click(object sender, EventArgs e)
        {
            
            if (CBDes.Text == "Botes de Bannana")
            {
          
                this.pictureBoxDes.Image = global::Restaurante.Properties.Resources.Botes_de_banana;
                MessageBox.Show("Pltano, Piña y coco $20");

                return;
            }
            if (CBDes.Text == "Burritos")
            {

                this.pictureBoxDes.Image = global::Restaurante.Properties.Resources.Burritos;
                MessageBox.Show("Dos burritos rellenos de frijoles, queso, guisado a escojer  $30");

                return;
            }
            if (CBDes.Text == "Pan de Calabaza")
            {

                this.pictureBoxDes.Image = global::Restaurante.Properties.Resources.Pan_de_calabaza;
                MessageBox.Show("Puré de ciruela, jengibre moildo y canela  $25");

                return;
            }
            if (CBDes.Text == "Panqué de Elote")
            {

                this.pictureBoxDes.Image = global::Restaurante.Properties.Resources.Panque_de_elote;
                MessageBox.Show("Elote, arándanos  $15");

                return;
            }
            if (CBDes.Text == "Chilaquiles")
            {

                this.pictureBoxDes.Image = global::Restaurante.Properties.Resources.Chilaquiles;
                MessageBox.Show("Chilaquiles verdes o rojos con frijoles, crema y queso  $22");

                return;
            }
            else
                return;
        }
    }
}
