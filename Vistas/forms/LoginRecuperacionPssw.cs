using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.Net.Mail;
using ClaseBase.service;
namespace Vistas.forms
{
    public partial class LoginRecuperacionPssw : Form
    {
        private string hash;
        public LoginRecuperacionPssw()
        {
            InitializeComponent();
        }
        private void LoginRecuperacionPssw_Load(object sender, EventArgs e)
        {
            tbcGestion.Appearance = TabAppearance.FlatButtons;
            tbcGestion.ItemSize = new Size(0, 1);
            tbcGestion.SizeMode = TabSizeMode.Fixed;
        }
        //Usuario
        private void btnEnviarUser_Click(object sender, EventArgs e)
        {
            if (UsuarioService.nombreUsuarioExiste(txtUsuario.Text) )
            {
                string correoDelUsuario = UsuarioService.obtenerCorreoUsuario(txtUsuario.Text);

                if (!string.IsNullOrEmpty(correoDelUsuario))
                {
                    hash = generarHash();
                    EnviarCorreo(correoDelUsuario, hash);
                    tbcGestion.SelectedIndex = 1;
                }
                else
                {
                    MessageBox.Show("El usuario existe, pero no tiene un correo registrado en el sistema para recuperar la cuenta.", "Falta Correo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre de usuario valido");
            }
        }

        private string generarHash() 
        {
            string caracteresPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            string hashGenerado = "";

            for (int i = 0; i < 5; i++)
            {
                int indiceAleatorio = random.Next(caracteresPermitidos.Length);
                hashGenerado += caracteresPermitidos[indiceAleatorio];
            }

            return hashGenerado;
        }
        public static void EnviarCorreo(string correoDestino, string codigo)
        {
            MailMessage mensaje = new MailMessage();
            mensaje.From = new MailAddress("noresponderg11@gmail.com", "Óptica G11"); // Tu correo y el nombre que querés que aparezca
            mensaje.To.Add(correoDestino); // El correo del cliente o usuario
            mensaje.Subject = "Código de Recuperación de Cuenta - No responder";
            mensaje.Body = "No compartas este código, solo usalo para cambiar tu contraseña.\n\nTu código de seguridad es: " + codigo;
            mensaje.IsBodyHtml = false; // Ponelo en true si querés mandar el texto con etiquetas HTML (negritas, colores, etc.)

            // 2. Configuramos el cliente SMTP (El cartero - Configuración para Gmail)
            SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com");
            clienteSmtp.Port = 587; // Puerto estándar para conexiones seguras
            clienteSmtp.EnableSsl = true; // Fundamental para que Gmail no rechace la conexión

            // Ponemos las credenciales de tu cuenta
            clienteSmtp.Credentials = new NetworkCredential("noresponderg11@gmail.com", "vnls vmkj lziq lggp");

            // 3. Enviamos el correo
            clienteSmtp.Send(mensaje);
        }
        //Recuperacion
        private void btnVerificarEnviar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == hash)
            {
                tbcGestion.SelectedIndex = 2;
            }
            else
            {
                MessageBox.Show("Codigo invalido, Verifique su correo");
            }
        }
        //Cambio

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNuevaPass.Text) || string.IsNullOrEmpty(txtConfirmarPass.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                if (txtNuevaPass.Text == txtConfirmarPass.Text)
                {
                    if (UsuarioService.actualizarContraseña(txtUsuario.Text, txtNuevaPass.Text))
                    {
                        MessageBox.Show("Actualizacion de Contrseña, Exitosa!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error inesperado, Intentelo mas tarde");
                    }
                }
                else
                {
                    MessageBox.Show("Ambas contraseñas tienen que ser iguales");
                }
            }
        }
    }
}
