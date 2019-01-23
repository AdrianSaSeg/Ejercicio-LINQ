using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioLINQ
{
    public partial class Form1 : Form
    {
        BindingList<Estudiantes> lista_estudiantes = new BindingList<Estudiantes>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lista_estudiantes.Add(new Estudiantes(11, "Laura", "Rodríguez"));
            lista_estudiantes.Add(new Estudiantes(9, "Francisco", "Jiménez"));

            dataGridView1.DataSource = lista_estudiantes;

            //establecemos como opciones del combobox las propiedades de nuestra lista 
            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                comboBox1.Items.Add(item.Name);
            }
        }

        private void botonInsertar_Click(object sender, EventArgs e)
        {
            FormInsertar formInsertar = new FormInsertar(lista_estudiantes, dataGridView1);
            formInsertar.ShowDialog();
        }

        private void botonFiltrar_Click(object sender, EventArgs e)
        {
            int año = Convert.ToInt32(textBox1.Text);

            foreach (var item in lista_estudiantes)
            {
                var filtro = lista_estudiantes.Where(x => x.Edad < año).ToList();

                dataGridView1.DataSource = filtro;
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
