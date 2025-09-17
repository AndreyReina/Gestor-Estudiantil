using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using GestorEstudiantes.Clases;

namespace GestorEstudiantes
{
    public partial class FrmCorreos : Form
    {
        private Estudiante estudiante; // guardamos el estudiante recibido

        // 🔹 Constructor que recibe un Estudiante
        public FrmCorreos(Estudiante est)
        {
            InitializeComponent();
            estudiante = est;

            // Preparamos mensaje base
            txtAsunto.Text = "Resultado Académico";
            txtMensaje.Text =
                txtMensaje.Text =
                 $"Hola {estudiante.Nombre},{Environment.NewLine}{Environment.NewLine}" +
                 $"Tu promedio fue {estudiante.Promedio:F2}.{Environment.NewLine}" +
                 $"Estado: {estudiante.Estado}.{Environment.NewLine}{Environment.NewLine}" +
                 $"Saludos,{Environment.NewLine}Tu Docente Academico";

        }

        // 🔹 Botón enviar correo
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mensaje = new MailMessage();
                mensaje.From = new MailAddress("andrey.reina.ar@gmail.com"); // remitente
                mensaje.To.Add(txtCorreoDestino.Text.Trim());        // destinatario
                mensaje.Subject = txtAsunto.Text;
                mensaje.Body = txtMensaje.Text;

                SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587);
                cliente.Credentials = new NetworkCredential("andrey.reina.ar@gmail.com", "okfz cjdw lawv azgk");
                cliente.EnableSsl = true;

                cliente.Send(mensaje);

                lblEstado.Text = "✅ Correo enviado correctamente.";
            }
            catch (Exception ex)
            {
                lblEstado.Text = "❌ Error al enviar: " + ex.Message;
            }
        }
    }
}
