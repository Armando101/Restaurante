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
    public partial class CarnesFor : Form
    {
        public Carnes Carne=null;

        public CarnesFor()
        {
            InitializeComponent();

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Carne = new Carnes(Convert.ToInt32(this.UpDownDesa.Value), this.CBCar.Text);
            //Asigana a la estructura carnes Lo que elijió el usuario, posteriormente se asigna a la list en el 
            //Formulario principal
        }   //Sirve para agregar elementos al pedido del usuario

        private void buttonDesc_Click(object sender, EventArgs e)   //Proporciona al usuario una breve descripcción del alimento 
        {

            if (CBCar.Text == "Bife de Salmón a las Brasas")
            {

                this.pictureBoxCar.Image = global::Restaurante.Properties.Resources.BifeSalmon;

                MessageBox.Show("300 gr / Acompañado con Julina de Verduras $130");

                return;
            }

            if (CBCar.Text == "Ojo de Bife")
            {
                this.pictureBoxCar.Image = global::Restaurante.Properties.Resources.Ojodebfife;
                MessageBox.Show("Acompañado de Elote a la Mantequilla\n Papas finas, Hierbas 3 Persona $450");

                return;
            }
            if (CBCar.Text == "Milanesa de Pollo")
            {

                this.pictureBoxCar.Image = global::Restaurante.Properties.Resources.MilaPollo;
                MessageBox.Show("Acompañada de Papas Fritas $93");

                return;
            }
            if (CBCar.Text == "Milanesa de Lomo")
            {

                this.pictureBoxCar.Image = global::Restaurante.Properties.Resources.MilaLomo;
                MessageBox.Show("Preparada con Filete de Res $100");

                return;
            }
            if (CBCar.Text == "Camarones al Ajillo")
            {

                this.pictureBoxCar.Image = global::Restaurante.Properties.Resources.Camarones;
                MessageBox.Show("Sazonados al Guajillo con Aceite de Olivo y Ajo $135");

                return;
            }
            if (CBCar.Text == "Parrillada Argentina")
            {

                this.pictureBoxCar.Image = global::Restaurante.Properties.Resources.Parrillada;
                MessageBox.Show("3 Personas. Chorizo, Longaniza, Chistorra, Mollejas, Pollo y Arrachera\n$400");

                return;
            }
            else
                return;   //Exception

        }
    }
}
