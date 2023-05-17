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
    public partial class Form3 : Form
    {
        private ControllerBiblioteca cnn = new ControllerBiblioteca();
        public Form3()
        {
            InitializeComponent();
            radioButton1.CheckedChanged += radioButton_CheckedChanged;
            radioButton2.CheckedChanged += radioButton_CheckedChanged;
            radioButton3.CheckedChanged += radioButton_CheckedChanged;

            string[] categorias = {"Seleccione la Categoria", "Ciencia Ficción",
                "Drama", "Terror", "Aventura", "Fantasía",
                "Motivacional", "Tecnologia", "Ciencias Sociales"};
            inputCategoria.Items.AddRange(categorias);
            inputCategoria.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable resultados;
            if (radioButton1.Checked)
            {
                if(inputNombre.Text.Length > 2)
                {
                    string nombre = inputNombre.Text;
                    string columna = "t1.nombre";
                    if (cnn.BuscarLibroPorNombre(nombre.Trim(), columna, out resultados))
                    {
                        dataGrid.DataSource = resultados;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un Nombre Valido.");
                }

            }
            else if (radioButton2.Checked)
            {
                if(inputNombre.Text.Length > 3)
                {
                    string nombre = inputNombre.Text;
                    string columna = "t1.autor";
                    if (cnn.BuscarLibroPorNombre(nombre.Trim(), columna, out resultados))
                    {
                        dataGrid.DataSource = resultados;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un Autor Valido.");
                }

            }
            else if (radioButton3.Checked)
            {
                if(inputCategoria.SelectedIndex != 0)
                {
                    string nombre = inputCategoria.Text;
                    string columna = "t2.categoria";
                    if (cnn.BuscarLibroPorNombre(nombre.Trim(), columna, out resultados))
                    {
                        dataGrid.DataSource = resultados;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una Categoria.");
                }

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            ////
            DataTable dtCatalogo = cnn.ObtenerCatalogoBiblioteca();
            if (dtCatalogo == null)
            {
                MessageBox.Show("NO ESTAN LLEGANDO DATOS, INTENTEN MAS TARDE");
            }
            else
            {
                dataGrid.DataSource = dtCatalogo;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label2.Text = "Ingrese Nombre del Libro";
                inputCategoria.Visible = false;
                inputNombre.Visible = true;
            }
            else if (radioButton2.Checked)
            {
                label2.Text = "Ingrese Autor del Libro";
                inputCategoria.Visible = false;
                inputNombre.Visible = true;
            }
            else if(radioButton3.Checked)
            {
                label2.Text = "Seleccione la Categoria";
                inputNombre.Visible = false;
                inputCategoria.Visible= true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable dtCatalogo = cnn.ObtenerCatalogoBiblioteca();
            if (dtCatalogo == null)
            {
                MessageBox.Show("NO ESTAN LLEGANDO DATOS, INTENTEN MAS TARDE");
            }
            else
            {
                dataGrid.DataSource = dtCatalogo;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string codigo = senderGrid.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
                string titulo = senderGrid.Rows[e.RowIndex].Cells["titulo"].Value.ToString();
                string autor = senderGrid.Rows[e.RowIndex].Cells["autor"].Value.ToString();
                string categoria = senderGrid.Rows[e.RowIndex].Cells["categoria"].Value.ToString();

                MessageBox.Show($"Codigo: {codigo}\nTitulo: {titulo}\nAutor: {autor}\nCategoria: {categoria}");
            }
        }
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }
    }
}
