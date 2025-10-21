using System;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        private const string USUARIO_CORRECTO = "Rodrigo";
        private const string CONTRASENA_CORRECTA = "12345";


        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            this.errorProviderUsuario = new System.Windows.Forms.ErrorProvider();
            this.errorProviderContrasena = new System.Windows.Forms.ErrorProvider();

            this.errorProviderUsuario.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            this.errorProviderContrasena.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            txtUsuario.Leave += new EventHandler(txtUsuario_Leave);
            txtContrasena.Leave += new EventHandler(txtContrasena_Leave);

            btnIniciarSesion.Click += new EventHandler(btnIniciarSesion_Click);
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                errorProviderUsuario.SetError(txtUsuario, "Debe colocar su usuario");
            }
            else
            {
                errorProviderUsuario.SetError(txtUsuario, "");
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                errorProviderContrasena.SetError(txtContrasena, "Debe colocar su contraseña");
            }
            else
            {
                errorProviderContrasena.SetError(txtContrasena, "");
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            txtUsuario_Leave(null, null);
            txtContrasena_Leave(null, null);

            if (!string.IsNullOrEmpty(errorProviderUsuario.GetError(txtUsuario)) ||
                !string.IsNullOrEmpty(errorProviderContrasena.GetError(txtContrasena)))
            {
                MessageBox.Show("Complete ambos campos.");
                return;
            }

            if (txtUsuario.Text == USUARIO_CORRECTO && txtContrasena.Text == CONTRASENA_CORRECTA)
            {
                MessageBox.Show($"¡Bienvenido/a {USUARIO_CORRECTO}!");
                FormBienvenida bienvenida = new FormBienvenida();
                bienvenida.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos.");
                txtContrasena.Clear();
                txtContrasena.Focus();
            }
        }
    }

}
