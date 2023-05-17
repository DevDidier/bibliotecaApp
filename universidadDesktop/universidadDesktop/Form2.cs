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
    public partial class Form2 : Form
    {
        private ControllerBiblioteca cnn = new ControllerBiblioteca();

        public Form2()
        {
            InitializeComponent();
            inputPaginas.KeyPress += new KeyPressEventHandler(inputPaginas_KeyPress);
            inputCategoria.DropDownStyle = ComboBoxStyle.DropDownList;

            string[] categorias = {"Seleccione la Categoria", "Ciencia Ficción",
                "Drama", "Terror", "Aventura", "Fantasía",
                "Motivacional", "Tecnologia", "Ciencias Sociales"};
            inputCategoria.Items.AddRange(categorias);
            inputCategoria.SelectedIndex = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void inputPaginas_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputPaginas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = inputNombre.Text;
            string autor = inputAutor.Text;
            int categoria = inputCategoria.SelectedIndex;
            int paginas;

            if (inputPaginas.Text == "")
            {
                msmError.Text = "";
                msmError.Text = "Ingrese el Numero de Paginas";
                msmError.Visible = true;
            }
            else
            {
                paginas = int.Parse(inputPaginas.Text);

                if(paginas > 10)
                {
                    if(nombre.Length > 5)
                    {
                        if(autor.Length > 5)
                        {
                            if(categoria != 0)
                            {
                                nombre.ToUpper();
                                autor.ToUpper();
                                bool respuesta = cnn.InsertarLibro(nombre.Trim(), autor.Trim(), paginas, categoria);
                                btnIngresar.Enabled = false;

                                if (respuesta)
                                {
                                    inputAutor.Text = "";
                                    inputCategoria.SelectedIndex = 0;
                                    inputNombre.Text = "";
                                    inputPaginas.Text = "";

                                    btnIngresar.Enabled = true;

                                    msmError.Visible = false;
                                    msmSuccess.Text = "";
                                    msmSuccess.Text = "Seleccione la Categoria";
                                    msmSuccess.Visible = true;
                                }
                                else
                                {
                                    btnIngresar.Enabled = true;

                                    msmSuccess.Visible = false;
                                    msmError.Text = "";
                                    msmError.Text = "No se Pudo Ingresar Error en DATABASE";
                                    msmError.Visible = true;
                                }
                            }
                            else
                            {
                                msmSuccess.Visible = false;
                                msmError.Text = "";
                                msmError.Text = "Seleccione la Categoria";
                                msmError.Visible = true;
                            }  
                        }
                        else
                        {
                            msmSuccess.Visible = false;
                            msmError.Text = "";
                            msmError.Text = "Ingrese el Nombre del Autor";
                            msmError.Visible = true;
                        }
                    }
                    else
                    {
                        msmSuccess.Visible = false;
                        msmError.Text = "";
                        msmError.Text = "Ingrese el Nombre del Libro";
                        msmError.Visible = true;
                    }
                }
                else
                {
                    msmSuccess.Visible = false;
                    msmError.Text = "";
                    msmError.Text = "Ingrese un Numero de Paginas Real";
                    msmError.Visible = true;
                }
            }
        }
    }
}
