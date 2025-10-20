using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PilaApp
{
    public partial class Form1 : Form
    {

        class Empleado
        {
            public string Nombre { get; set; }
            public string Cargo { get; set; }
            public decimal Salario { get; set; }


            public override string ToString()
            {
                return $"{Nombre} - {Cargo} - ${Salario}";
            }
        }


        Stack<Empleado> pilaEmpleados = new Stack<Empleado>();

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = tbNombres.Text.Trim();
            string cargo = tbCargos.Text.Trim();
            string salarioTexto = tbSalarios.Text.Trim();


            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(cargo) || string.IsNullOrEmpty(salarioTexto))
            {
                MessageBox.Show("Por favor, llena todos los campos antes de agregar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(salarioTexto, out decimal salario) || salario < 0)
            {
                MessageBox.Show("Ingresa un salario válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Empleado nuevo = new Empleado
            {
                Nombre = nombre,
                Cargo = cargo,
                Salario = salario
            };

            pilaEmpleados.Push(nuevo);
            ActualizarLista();


            tbNombres.Clear();
            tbCargos.Clear();
            tbSalarios.Clear();
            tbNombres.Focus();
        }

  
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (pilaEmpleados.Count == 0)
            {
                MessageBox.Show("La pila está vacía. No hay empleados para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Empleado eliminado = pilaEmpleados.Pop();
            MessageBox.Show($"Se eliminó: {eliminado.Nombre} ({eliminado.Cargo})", "Empleado eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActualizarLista();
        }


        private void btnTope_Click(object sender, EventArgs e)
        {
            if (pilaEmpleados.Count == 0)
            {
                MessageBox.Show("La pila está vacía.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Empleado tope = pilaEmpleados.Peek();
            MessageBox.Show($"Empleado en el tope:\n\nNombre: {tope.Nombre}\nCargo: {tope.Cargo}\nSalario: ${tope.Salario}", "Tope de la pila", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

   
        private void ActualizarLista()
        {
            Pila.Items.Clear();
            foreach (Empleado emp in pilaEmpleados)
            {
                Pila.Items.Add(emp);
            }
        }


        private void tbNombres_TextChanged(object sender, EventArgs e) { }
        private void tbCargos_TextChanged(object sender, EventArgs e) { }
        private void tbSalarios_TextChanged(object sender, EventArgs e) { }
        private void Pila_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
