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
        BindingList<Estudiantes> estudiantes = new BindingList<Estudiantes>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            estudiantes.Add(new Estudiantes(11, "Laura", "Rodríguez"));
            estudiantes.Add(new Estudiantes(9, "Francisco", "Jiménez"));

            dataGridView1.DataSource = estudiantes;
        }

        private void botonInsertar_Click(object sender, EventArgs e)
        {
            FormInsertar formInsertar = new FormInsertar(estudiantes, dataGridView1);
            formInsertar.ShowDialog();
        }

        private void botonFiltrar_Click(object sender, EventArgs e)
        {
            int año = Convert.ToInt32(textBox1.Text);

            foreach (var item in estudiantes)
            {
                var filtro = estudiantes.Where(x => x.Edad < año).ToList();

                dataGridView1.DataSource = filtro;
            }
            
        }
    }
}
