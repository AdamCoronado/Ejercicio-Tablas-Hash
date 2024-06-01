using Biblioteca_de_Clases;
using EstructuraDeClases.Listas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_Tablas_Hash
{
    public partial class FormParticipantes : Form
    {
        public TablaHash TablaHash = new TablaHash();
        public int clave;
        public FormParticipantes()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Boolean encontrado = false;
            if (txtbBNombre.Text == "" || txtbxBuscar.Text == "")
                MessageBox.Show("Se debe de ingresar el NOMBRE Y APELLIDO del atleta para realizar la busqueda!!!");
            else
            {
                clave = convertir(txtbxBuscar.Text);
                NodoLista temp;
                temp = (NodoLista)TablaHash.Buscar(clave);
                while (temp != null && encontrado != true)
                {
                    Participante x = (Participante)temp.Dato;
                    if (x.apellido == txtbxBuscar.Text && x.nombre == txtbBNombre.Text)
                    {
                        txtbxNombre.Text = x.nombre;
                        txtbxApellido.Text = x.apellido;
                        txtbxEdad.Text = Convert.ToString(x.edad);
                        txtbxFechaNac.Text = x.fechaNacimiento;
                        listCategoria.Text = x.categoria;
                        if (x.sexo == "Femenino")
                            rbtnFemenino.Checked = true;
                        else
                            rbtnMasculino.Checked = true;
                        encontrado = true;
                    }
                    temp = temp.Enlace;
                }
                if (encontrado == false)
                    MessageBox.Show("No se ha encontrado al Atleta, por favor revisa los datos.");
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                btnRestablecer.Enabled = true;
                btnNuevoRegistro.Enabled = false;
            }
        }

        public int convertir(string apellido)
        {
            int x = 0;
            char caracter;
            for (int i = 0; i < apellido.Length; i++)
            {
                caracter = apellido[i];
                x = x + (int)caracter;
            }
            return x;
        }

        public void validarCampos()
        {
            if (txtbxNombre.Text == "")
            {
                MessageBox.Show("Por favor ingresa el NOMBRE del participante.");
                txtbxNombre.Focus();
            }
            else
            {
                if (txtbxApellido.Text == "")
                {
                    MessageBox.Show("Por favor ingresa el APELLIDO del participante.");
                    txtbxApellido.Focus();
                }
                else
                {
                    if (txtbxEdad.Text == "")
                    {
                        MessageBox.Show("Por favor ingresa la EDAD del participante.");
                        txtbxEdad.Focus();
                    }
                    else
                    {
                        if (txtbxFechaNac.Text == "")
                        {
                            MessageBox.Show("Por favor ingresa la FECHA DE NACIMIENTO del participante.");
                            txtbxFechaNac.Focus();
                        }
                        else
                        {
                            if (listCategoria.Text == "")
                            {
                                MessageBox.Show("Por favor ingresa la CATEGORIA del participante.");
                                listCategoria.Focus();
                            }
                            else
                            {
                                if (rbtnMasculino.Checked == false && rbtnFemenino.Checked == false)
                                {
                                    MessageBox.Show("Por favor selecciona el SEXO del participante.");
                                    rbtnMasculino.Focus();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            validarCampos();
            clave = convertir(txtbxApellido.Text);
            string sexo = "";
            if (rbtnFemenino.Checked == true)
            {
                sexo = "Femenino";
            }
            else
            {
                sexo = "Masculino";
            }
            TablaHash.Insertar(new Participante(txtbxNombre.Text, txtbxApellido.Text, Convert.ToInt32(txtbxEdad.Text), sexo, txtbxFechaNac.Text, listCategoria.Text), clave);
            MessageBox.Show("El PARTICIPANTE ha sido agregado exitosamente");
            resetearCampos();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnRestablecer.Enabled = false;
        }

        public void resetearCampos()
        {
            txtbxNombre.Text = string.Empty;
            txtbxApellido.Text = string.Empty;
            txtbxEdad.Text = string.Empty;
            txtbxFechaNac.Text = string.Empty;
            listCategoria.Text = string.Empty;
            rbtnFemenino.Checked = false;
            rbtnMasculino.Checked = false;
            txtbxBuscar.Text = string.Empty;
            txtbBNombre.Text = string.Empty;
        }

        private void rbtnMasculino_CheckedChanged(object sender, EventArgs e)
        {
            rbtnFemenino.Checked = false;
        }

        private void rbtnFemenino_CheckedChanged(object sender, EventArgs e)
        {
            rbtnMasculino.Checked = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int clave = convertir(txtbxBuscar.Text);
            Lista ListaModificada = new Lista();
            NodoLista actual = (NodoLista)TablaHash.Buscar(clave);
            string sexo = "";
            if (rbtnFemenino.Checked == true)
            {
                sexo = "Femenino";
            }
            else
            {
                sexo = "Masculino";
            }
            Participante modificado = new Participante(txtbxNombre.Text, txtbxApellido.Text, Convert.ToInt32(txtbxEdad.Text), sexo, txtbxFechaNac.Text, listCategoria.Text);
            NodoLista NodoModificado = new NodoLista(modificado);
            int claveNueva = convertir(txtbxApellido.Text);
            if (claveNueva == clave)
            {
                while (actual != null)
                {
                    Participante x = (Participante)actual.Dato;
                    if (x.apellido == txtbxBuscar.Text && x.nombre == txtbBNombre.Text)
                    {
                        NodoModificado.Enlace = actual.Enlace;
                        actual = NodoModificado;
                    }
                    ListaModificada.InsertarCabezaLista(actual.Dato);
                    actual = actual.Enlace;
                }
                TablaHash.ListaHash[TablaHash.HashMod(clave)] = ListaModificada;
            }
            else
            {
                while (actual != null)
                {
                    Participante x = (Participante)actual.Dato;
                    if (x.apellido == txtbxBuscar.Text && x.nombre == txtbBNombre.Text)
                    {
                        actual = actual.Enlace;
                    }
                    if (actual != null)
                        ListaModificada.InsertarCabezaLista(actual.Dato);
                    if (actual == null)
                        break;
                    actual = actual.Enlace;
                }
                TablaHash.ListaHash[TablaHash.HashMod(clave)] = ListaModificada;
                TablaHash.Insertar(modificado, claveNueva);
            }
            resetearCampos();
            MessageBox.Show("Los datos del PARTICIPANTE han sido MODIFICADO");
            btnNuevoRegistro.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int clave = convertir(txtbxBuscar.Text);
            Lista ListaModificada = new Lista();
            NodoLista actual = (NodoLista)TablaHash.Buscar(clave);
            while (actual != null)
            {
                Participante x = (Participante)actual.Dato;
                if (x.apellido == txtbxBuscar.Text && x.nombre == txtbBNombre.Text)
                {
                    actual = actual.Enlace;
                }
                if (actual != null)
                    ListaModificada.InsertarCabezaLista(actual.Dato);
                if (actual == null)
                    break;
                actual = actual.Enlace;
            }
            TablaHash.ListaHash[TablaHash.HashMod(clave)] = ListaModificada;
            resetearCampos();
            MessageBox.Show("Los datos del PARTICIPANTE han sido ELIMINADO");
            btnNuevoRegistro.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            resetearCampos();
            btnNuevoRegistro.Enabled = true;
            btnEliminar.Enabled=false;
            btnModificar.Enabled=false;
        }
    }
}
