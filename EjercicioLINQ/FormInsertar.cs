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
    public partial class FormInsertar : Form
    {
        public BindingList<Estudiantes> _Estudiantes { get; set; }
        public DataGridView _datagrid { get; set; }

        public FormInsertar(BindingList<Estudiantes> estudiantes, DataGridView datagrid)
        {
            _Estudiantes = estudiantes;
            _datagrid = datagrid;
            InitializeComponent();
        }

        private void buttonFormInsertar_Click(object sender, EventArgs e)
        {
            int edad = Convert.ToInt32(textBoxEdad.Text);
            string nombre = textBoxNombre.Text;
            string apellido = textBoxApellido.Text;

            _Estudiantes.Add(new Estudiantes(edad, nombre, apellido));
            _datagrid.DataSource = _Estudiantes;

            this.textBoxEdad.Clear();
            this.textBoxNombre.Clear();
            this.textBoxApellido.Clear();

        }

        private void buttonFormCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
