using Ejercicio2_Gimnasio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WF_Ejercicio3_Gimnasio
{
    public partial class Form2 : Form
    {
        Form1 form1;
        //List<Cliente> clientes = new List<Cliente>() { new Cliente(1, "Pepe", "Perez", DateTime.Now, "Madrid", 12345678) };
        List<Cliente> clientes = new List<Cliente>();
        string[] ciudades = new string[] { "Madrid", "Barcelona", "Sevilla", "Valencia", "Bilbao" };


        public Form2(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void limpiarCampos()
        {
            tbCodigo.Enabled = true;
            tbCodigo.Clear();
            tbNombre.Clear();
            tbApellidos.Clear();
            dtpFecha.Value = DateTime.Now;
            cbCiudad.SelectedIndex = 0;
            tbTelefono.Clear();
        }

        private void habilitarBotones()
        {
            btnAnadir.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = true;
            btnCargar.Enabled = true;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.form1.Show();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            cbCiudad.DataSource = ciudades;
            bindingSource1.DataSource = clientes;
            dataGridView1.DataSource = bindingSource1;
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            string codigo = tbCodigo.Text;
            string nombre = tbNombre.Text;
            string apellidos = tbApellidos.Text;
            DateTime fecha = dtpFecha.Value;
            string ciudad = cbCiudad.Text;
            string telefono = tbTelefono.Text;

            if (!string.IsNullOrEmpty(codigo) && !string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellidos) && !string.IsNullOrEmpty(ciudad) && !string.IsNullOrEmpty(telefono))
            {

                foreach (var cliente in clientes)
                {
                    if (cliente.CodigoCliente == int.Parse(codigo))
                    {
                        MessageBox.Show("El cliente ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                clientes.Add(new Cliente(int.Parse(codigo), nombre, apellidos, fecha, ciudad, int.Parse(telefono)));
                bindingSource1.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Por favor, rellena todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            limpiarCampos();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSource1.Current != null)
                {
                    Cliente cliente = (Cliente)bindingSource1.Current;

                    if (!string.IsNullOrEmpty(tbCodigo.Text) && !string.IsNullOrEmpty(tbNombre.Text) && !string.IsNullOrEmpty(tbApellidos.Text) && !string.IsNullOrEmpty(cbCiudad.Text) && !string.IsNullOrEmpty(tbTelefono.Text))
                    {
                        DialogResult dialogResult = MessageBox.Show($"¿Estás seguro de que deseas eliminar al cliente {cliente.Nombre} {cliente.Apellidos}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (dialogResult == DialogResult.Yes)
                        {
                            clientes.Remove(cliente);

                            bindingSource1.Remove(cliente);

                            bindingSource1.ResetBindings(false);
                        }

                        limpiarCampos();
                        habilitarBotones();
                    }
                    else
                    {
                        tbCodigo.Enabled = false;
                        tbCodigo.Text = cliente.CodigoCliente.ToString();
                        tbNombre.Text = cliente.Nombre;
                        tbApellidos.Text = cliente.Apellidos;
                        dtpFecha.Value = cliente.FechaNacimiento;
                        cbCiudad.Text = cliente.Ciudad;
                        tbTelefono.Text = cliente.Telefono.ToString();

                        btnAnadir.Enabled = false;
                        btnModificar.Enabled = false;
                        btnGuardar.Enabled = false;
                        btnCargar.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("No hay ningún cliente seleccionado para eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar eliminar el cliente: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSource1.Current != null)
                {
                    Cliente cliente = (Cliente)bindingSource1.Current;

                    if (!string.IsNullOrEmpty(tbCodigo.Text) && !string.IsNullOrEmpty(tbNombre.Text) && !string.IsNullOrEmpty(tbApellidos.Text) && !string.IsNullOrEmpty(cbCiudad.Text) && !string.IsNullOrEmpty(tbTelefono.Text))
                    {
                        if (tbNombre.Text != cliente.Nombre || tbApellidos.Text != cliente.Apellidos || cbCiudad.Text != cliente.Ciudad || tbTelefono.Text != cliente.Telefono.ToString())
                        {
                            cliente.CodigoCliente = int.Parse(tbCodigo.Text);
                            cliente.Nombre = tbNombre.Text;
                            cliente.Apellidos = tbApellidos.Text;
                            cliente.FechaNacimiento = dtpFecha.Value;
                            cliente.Ciudad = cbCiudad.Text;
                            cliente.Telefono = int.Parse(tbTelefono.Text);

                            bindingSource1.ResetBindings(false);

                            limpiarCampos();
                            habilitarBotones();
                        }
                        else
                        {
                            limpiarCampos();
                            habilitarBotones();
                        }
                    }
                    else
                    {
                        tbCodigo.Enabled = false;
                        tbCodigo.Text = cliente.CodigoCliente.ToString();
                        tbNombre.Text = cliente.Nombre;
                        tbApellidos.Text = cliente.Apellidos;
                        dtpFecha.Value = cliente.FechaNacimiento;
                        cbCiudad.Text = cliente.Ciudad;
                        tbTelefono.Text = cliente.Telefono.ToString();

                        btnAnadir.Enabled = false;
                        btnEliminar.Enabled = false;
                        btnGuardar.Enabled = false;
                        btnCargar.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al intentar modificar el cliente: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            limpiarCampos();

            string fileName = $"clientes.json";
            string jsonString = JsonSerializer.Serialize(clientes);
            try
            {
                File.WriteAllText(fileName, jsonString);
                MessageBox.Show("Guardado correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al intentar guardar: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            limpiarCampos();

            bindingSource1.Clear();
            string fileName = $"clientes.json";
            try
            {
                string jsonString = File.ReadAllText(fileName);
                clientes = JsonSerializer.Deserialize<List<Cliente>>(jsonString);
                bindingSource1.DataSource = clientes;
                bindingSource1.ResetBindings(false);
                MessageBox.Show("Cargado correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al intentar cargar: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
