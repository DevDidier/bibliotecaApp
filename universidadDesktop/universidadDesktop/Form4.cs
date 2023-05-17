using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace universidadDesktop
{
    public partial class Form4 : Form
    {
        private AutoCompleteStringCollection autoCompleteData;
        private ControllerBiblioteca cnn = new ControllerBiblioteca();
        private List<Tuple<int, string>> estudiantes;
        public Form4()
        {
            InitializeComponent();

            autoCompleteData = new AutoCompleteStringCollection();


            var catalogo = cnn.listadoLibros();
            autoCompleteData = new AutoCompleteStringCollection();
            string nombreLibro;
            foreach (var libro in catalogo)
            {
                nombreLibro = libro.Item2;

                autoCompleteData.Add(nombreLibro.Trim());

                nombreLibro = null;
            }
            inputLibro.AutoCompleteCustomSource = autoCompleteData;
            inputLibro.AutoCompleteMode = AutoCompleteMode.Suggest;
            inputLibro.AutoCompleteSource = AutoCompleteSource.CustomSource;

            var estudiantes = cnn.consultaEstudiantes();
            autoCompleteData = new AutoCompleteStringCollection();
            string nomEstudiante;
            int cedula;
            foreach (var person in estudiantes)
            {
                nomEstudiante = person.Item2;
                cedula = person.Item1;

                autoCompleteData.Add(cedula+"-"+nomEstudiante);

                nomEstudiante = null;
                cedula = 0;
            }
            inputCedula.AutoCompleteCustomSource = autoCompleteData;
            inputCedula.AutoCompleteMode = AutoCompleteMode.Suggest;
            inputCedula.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(inputCedula.Text != "" || inputCedula.Text.Length > 5)
            {

                string[] personas = inputCedula.Text.Split(new string[] { "-" }, StringSplitOptions.None);
                string cedulaStr = personas[0];
                int cedula;

                if (int.TryParse(cedulaStr, out cedula))
                {
                    bool personaEncontrada = false;
                    foreach (var estudiante in estudiantes)
                    {
                        if (estudiante.Item1 == cedula)
                        {
                            personaEncontrada = true;
                            break;
                        }
                    }
                    if (personaEncontrada)
                    {
                        
                    }
                    else
                    {
                        MessageBox.Show("La persona no existe en la base de datos.");
                    }
                }
                else
                {
                    MessageBox.Show("La cédula no es un número válido.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese una Cedula Valida");
            }


        }
    }
}
