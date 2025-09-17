using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using GestorEstudiantes.Clases;
using LibreriaSerializadores;

namespace GestorEstudiantes
{
    public partial class FrmPrincipal : Form
    {
        private List<Estudiante> listaEstudiantes = new List<Estudiante>();
        private string rutaArchivo = Path.Combine(Application.StartupPath, "estudiantes.csv");

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        // === REGISTRAR ESTUDIANTE ===
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtEdad.Text))
                {
                    lblMensajeRegistro.Text = "⚠️ Nombre y edad son obligatorios.";
                    return;
                }

                if (!int.TryParse(txtEdad.Text, out int edad))
                {
                    lblMensajeRegistro.Text = "⚠️ La edad debe ser un número válido.";
                    return;
                }

                if (!double.TryParse(txtNota1.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double n1) ||
                    !double.TryParse(txtNota2.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double n2) ||
                    !double.TryParse(txtNota3.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double n3))
                {
                    lblMensajeRegistro.Text = "⚠️ Las notas deben ser números válidos (usa punto decimal).";
                    return;
                }

                var estudiante = new Estudiante
                {
                    Nombre = txtNombre.Text.Trim(),
                    Edad = edad,
                    Genero = rbtMasculino.Checked ? "Masculino" :
                             rbtFemenino.Checked ? "Femenino" : "No especificado",
                    Deportes = chkDeportes.Checked,
                    Musica = chkMusica.Checked,
                    Arte = chkArte.Checked,
                    Nota1 = n1,
                    Nota2 = n2,
                    Nota3 = n3
                };

                listaEstudiantes.Add(estudiante);
                ActualizarInterfaz();
                lblMensajeRegistro.Text = "✅ Estudiante registrado correctamente.";

                // limpiar campos
                txtNombre.Clear();
                txtEdad.Clear();
                txtNota1.Clear();
                txtNota2.Clear();
                txtNota3.Clear();
                chkDeportes.Checked = chkMusica.Checked = chkArte.Checked = false;
                rbtMasculino.Checked = rbtFemenino.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar estudiante: " + ex.Message);
            }
        }

        // === ACTUALIZAR INTERFAZ ===
        private void ActualizarInterfaz()
        {
            dgvEstudiantes.DataSource = null;
            dgvEstudiantes.DataSource = listaEstudiantes;

            lstNombres.Items.Clear();
            foreach (var est in listaEstudiantes)
            {
                lstNombres.Items.Add(est.Nombre);
            }
        }

        // === GUARDAR CSV ===
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var filas = new List<string[]>();
                // encabezado
                filas.Add(new string[]
                {
                    "Nombre","Edad","Genero","Deportes","Musica","Arte","Nota1","Nota2","Nota3"
                });

                foreach (var est in listaEstudiantes)
                    filas.Add(est.ToArray());

                SerializadorCsv.GuardarCsv(rutaArchivo, filas);

                MessageBox.Show("✅ Datos guardados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar CSV: " + ex.Message);
            }
        }

        // === CARGAR CSV ===
        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                var filas = SerializadorCsv.LeerCsv(rutaArchivo);

                if (filas == null || filas.Count <= 1)
                {
                    MessageBox.Show("Archivo vacío o sin datos.");
                    return;
                }

                listaEstudiantes.Clear();

                for (int i = 1; i < filas.Count; i++) // saltar encabezado
                {
                    var est = Estudiante.FromArray(filas[i]);
                    if (est != null) listaEstudiantes.Add(est);
                }

                ActualizarInterfaz();
                MessageBox.Show("✅ Datos cargados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar CSV: " + ex.Message);
            }
        }

        // === BUSCAR ESTUDIANTE ===
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingrese un nombre para buscar.");
                return;
            }

            var estudiante = listaEstudiantes
                .FirstOrDefault(e => e.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

            if (estudiante != null)
            {
                FrmResultado frm = new FrmResultado(estudiante);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("❌ Estudiante no encontrado.");
            }
        }

        // === SELECCIONAR NOMBRE EN LISTBOX ===
        private void lstNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNombres.SelectedIndex >= 0)
            {
                var est = listaEstudiantes[lstNombres.SelectedIndex];
                lblInfo.Text = $"👤 {est.Nombre} - 📊 Promedio: {est.Promedio:F2} - {est.Estado}";

                // Colorear el PictureBox en lugar de usar Properties.Resources
                pbEstado.Image = null;
                pbEstado.BackColor = est.Estado == "Aprobado"
                    ? System.Drawing.Color.LightGreen
                    : System.Drawing.Color.LightCoral;
            }
        }

        // === CAMBIO DE SELECCIÓN EN DATAGRID ===
        private void dgvEstudiantes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEstudiantes.CurrentRow != null &&
                dgvEstudiantes.CurrentRow.DataBoundItem is Estudiante est)
            {
                lblInfo.Text = $"👤 {est.Nombre} - 📊 Promedio: {est.Promedio:F2} - {est.Estado}";
            }
        }

        // === DOBLE CLIC EN UNA FILA DEL DATAGRID ===
        private void dgvEstudiantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvEstudiantes.Rows[e.RowIndex].DataBoundItem is Estudiante est)
            {
                FrmResultado frm = new FrmResultado(est);
                frm.ShowDialog();
            }
        }

        private void btnCorreo_Click(object sender, EventArgs e)
        {
            if (dgvEstudiantes.CurrentRow?.DataBoundItem is Estudiante est)
            {
                FrmCorreos frm = new FrmCorreos(est);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un estudiante para enviar correo.");
            }
        }

    }
}
