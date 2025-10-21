using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    public partial class FormBienvenida : Form
    {
        public FormBienvenida()
        {
            InitializeComponent();

            this.Text = "Ventana Principal";
            this.BackColor = Color.FromArgb(192, 192, 255);
            this.ClientSize = new Size(400, 300); 

            Label lblMensaje = new Label();
            lblMensaje.Text = "Bienvenid@";
            lblMensaje.Font = new Font("Tw Cen MT Condensed Extra Bold", 16);
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(50, 50);
            this.Controls.Add(lblMensaje);
        }
    }
}