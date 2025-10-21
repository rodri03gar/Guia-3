using System;
using System.Windows.Forms;

namespace promedio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "40%", "20%" });
            comboBox2.Items.AddRange(new string[] { "0%", "20%" });
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            lblResultado.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAlumno.Text) ||
                    string.IsNullOrWhiteSpace(textBox2.Text) ||
                    string.IsNullOrWhiteSpace(textBox3.Text) ||
                    string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    MessageBox.Show("Por favor completa todos los campos.");
                    return;
                }

                if (!double.TryParse(textBox2.Text, out double parcial) ||
                    !double.TryParse(textBox3.Text, out double guia) ||
                    !double.TryParse(textBox4.Text, out double control))
                {
                    MessageBox.Show("Por favor ingresa solo números válidos (0 a 10) en las notas.");
                    return;
                }

                if (parcial < 0 || parcial > 10 || guia < 0 || guia > 10 || control < 0 || control > 10)
                {
                    MessageBox.Show("Las notas deben estar entre 0 y 10.");
                    return;
                }

                string seleccionGuia = comboBox1.SelectedItem.ToString();
                string seleccionControl = comboBox2.SelectedItem.ToString();

                if ((seleccionGuia == "40%" && seleccionControl != "0%") ||
                    (seleccionGuia == "20%" && seleccionControl != "20%"))
                {
                    MessageBox.Show("Selección inválida:\n\n- Si la guía es 40%, el control debe ser 0%.\n- Si la guía es 20%, el control debe ser 20%.");
                    return;
                }

                double porcGuia = seleccionGuia == "40%" ? 0.4 : 0.2;
                double porcControl = seleccionControl == "0%" ? 0.0 : 0.2;
                double promedio = (parcial * 0.6) + (guia * porcGuia) + (control * porcControl);

                if (promedio > 10) promedio = 10;
                if (promedio < 0) promedio = 0;

                string resultado = promedio >= 6.0 ? "APROBÓ" : "REPROBÓ";
                lblResultado.ForeColor = resultado == "APROBÓ" ? System.Drawing.Color.Green : System.Drawing.Color.Red;
                lblResultado.Text = $"El estudiante {txtAlumno.Text} obtuvo {promedio:F2}. {resultado}.";
                MessageBox.Show(lblResultado.Text, "Resultado");
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al calcular el promedio.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Jose Rodrigo Segura Garcia\nCarnet: 27-2074-2025\n Pedro Ricardo Orantes Cuellar\nCarnet: 27-6587-2013",
                "Contacto", MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }
    }
}
