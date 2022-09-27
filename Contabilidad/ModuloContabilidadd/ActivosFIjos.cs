using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ModuloContabilidadd
{
    public partial class ActivosFIjos : Form
    {
    
        public ActivosFIjos()
        {
            InitializeComponent();
        }
        CapaVista.ClassCRUD crud = new CapaVista.ClassCRUD();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                bool resultado = crud.InsertProducto(null,textBox1.Text, textBox2.Text, textBox3.Text, textBox6.Text, textBox5.Text, textBox4.Text);
               
            if (resultado)
            {
                dataGridView1.Rows.Add(new object[]{ null, textBox1.Text, textBox2.Text, textBox3.Text, textBox6.Text, textBox5.Text, textBox4.Text, "Modificar",
                    "Eliminar"});
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            bool resultado = crud.updateproduct(null, textBox1.Text, textBox2.Text, textBox3.Text, textBox6.Text, textBox5.Text, textBox4.Text);

            if (resultado)
            {
                dataGridView1.Rows.Add(new object[]{ null, textBox1.Text, textBox2.Text, textBox3.Text, textBox6.Text, textBox5.Text, textBox4.Text, "Modificar",
                    "Eliminar"});
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
     
    }
}
