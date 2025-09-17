using System;
using System.Windows.Forms;
using GestorEstudiantes.Clases;

namespace GestorEstudiantes
{
    public partial class FrmResultado : Form
    {
        public FrmResultado(Estudiante estudiante)
        {
            InitializeComponent();

            if (estudiante != null)
            {
                lblInfo.Text = $"📌 Resultado del estudiante\n\n" +
                               $"👤 Nombre: {estudiante.Nombre}\n" +
                               $"🎂 Edad: {estudiante.Edad}\n" +
                               $"⚧ Género: {estudiante.Genero}\n" +
                               $"🎭 Intereses: {(estudiante.Deportes ? "Deportes " : "")}" +
                               $"{(estudiante.Musica ? "Música " : "")}" +
                               $"{(estudiante.Arte ? "Arte " : "")}\n\n" +
                               $"📊 Promedio: {estudiante.Promedio:F2}\n" +
                               $"✅ Estado: {estudiante.Estado}";
            }
            else
            {
                lblInfo.Text = "❌ No se pudo cargar la información del estudiante.";
            }
        }
    }
}
